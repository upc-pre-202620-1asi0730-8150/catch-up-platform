# Changelog

All notable changes to this project are documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.0.0] - 2026-10-26

### Added

- REST API for creating and retrieving users' favorite news sources, including lookups by identifier and by news API key/source identifier.
- Domain and application layers for favorite-source use cases, with validated value objects, repository abstractions, and command/query services.
- Entity Framework Core persistence with MySQL, duplicate-pair protection, and automatic creation/update audit timestamps.
- Localized validation responses, standardized API errors, and interactive OpenAPI documentation through Scalar.
- Development and production database configuration, plus a Dockerfile for building and running the API.

### Documentation

- Added project setup and database-migration guidance, API user stories, architecture decision records, and a class diagram.
- Expanded XML documentation for the `NewsApiKey` value object and shared domain contracts.
