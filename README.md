# Encryption API
Ett enkelt API för att kryptera och dekryptera text med hjälp av en enkel Ceaser cipher

[![Build and push to aws](https://github.com/RobertTVu/ExamCICD/actions/workflows/ci-cd-pineline.yml/badge.svg)](https://github.com/RobertTVu/ExamCICD/actions/workflows/ci-cd-pineline.yml)

## Funktioner
- **Encrypt**: Krypterar en given text.
- **Decrypt**: Dekrypterar en given text.

## Endpoints

### GET `/`
- **Beskrivning**: Startpunkt som ger en översikt över tillgängliga endpoints.

### GET `/encrypt`
**Query Parameters**:
- `input` (string): Texten som ska krypteras.
- **Exempel**: `/encrypt?input=hello`

### GET `/decrypt`
**Query Parameters**:
- `input` (string): Texten som ska dekrypteras.
- **Exempel**: `/decrypt?input=khoor`

## CI/CD-Process
- **Figma-Länk**: [CI/CD Process](https://www.figma.com/board/IW0zWaMNAmAkSJrP57qgN7/CI%2FCD-Process?node-id=0-1&p=f&t=f3L3FpnXPkeFG33q-0)
