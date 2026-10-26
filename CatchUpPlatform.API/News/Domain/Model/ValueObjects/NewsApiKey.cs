namespace CatchUpPlatform.API.News.Domain.Model.ValueObjects;

/// <summary>
///     Value object representing a validated News API key.
/// </summary>
public sealed record NewsApiKey
{
    private const int MaxLength = 255;

    /// <summary>
    ///     Gets the underlying API key value.
    /// </summary>
    public string Value { get; }

    /// <summary>
    ///     Initializes a new <see cref="NewsApiKey"/> with the given raw string value.
    /// </summary>
    /// <param name="value">The API key string. Must be non-null, non-whitespace, and at most 255 characters.</param>
    /// <exception cref="ArgumentException">Thrown when <paramref name="value"/> is null, empty, whitespace, or exceeds the maximum length.</exception>
    public NewsApiKey(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("News API key cannot be null or whitespace.", nameof(value));
        if (value.Length > MaxLength)
            throw new ArgumentException($"News API key cannot exceed {MaxLength} characters.", nameof(value));
        Value = value;
    }

    /// <inheritdoc />
    public override string ToString() => Value;

    /// <summary>
    ///     Masks an API key for logging while retaining its last four characters when available.
    /// </summary>
    /// <param name="value">The API key to mask, or null.</param>
    /// <returns>An empty string for a null or empty value, a fully masked value of four or fewer characters, or a masked value with its last four characters visible.</returns>
    public static string MaskedForLogging(string? value) =>
        string.IsNullOrEmpty(value)
            ? string.Empty
            : value.Length <= 4
                ? new string('*', value.Length)
                : new string('*', value.Length - 4) + value[^4..];

    /// <summary>
    ///     Masks this API key for logging while retaining its last four characters when available.
    /// </summary>
    /// <returns>A masked representation of this API key.</returns>
    public string MaskedForLogging() => MaskedForLogging(Value);
}