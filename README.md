
# Calculadora API

Este projeto é uma API de calculadora simples desenvolvida em C# que oferece operações básicas de adição, subtração, multiplicação e divisão.

## Endpoints

### Adição
- **Descrição**: Soma dois números.
- **Rota**: `/api/calculadora/Addition`
- **Método**: `GET`
- **Parâmetros**:
  - `value1` (double): Primeiro número.
  - `value2` (double): Segundo número.
- **Exemplo**:
  ```plaintext
  GET /api/calculadora/Addition?value1=5&value2=3
  ```
  **Resposta**:
  ```json
  {
    "value1": 5,
    "value2": 3,
    "resultado": 8
  }
  ```

### Subtração
- **Descrição**: Subtrai o segundo número do primeiro.
- **Rota**: `/api/calculadora/Subtraction`
- **Método**: `GET`
- **Parâmetros**:
  - `value1` (double): Primeiro número.
  - `value2` (double): Segundo número.
- **Exemplo**:
  ```plaintext
  GET /api/calculadora/Subtraction?value1=5&value2=3
  ```
  **Resposta**:
  ```json
  {
    "value1": 5,
    "value2": 3,
    "resultado": 2
  }
  ```

### Multiplicação
- **Descrição**: Multiplica dois números.
- **Rota**: `/api/calculadora/Multiplication`
- **Método**: `GET`
- **Parâmetros**:
  - `value1` (double): Primeiro número.
  - `value2` (double): Segundo número.
- **Exemplo**:
  ```plaintext
  GET /api/calculadora/Multiplication?value1=5&value2=3
  ```
  **Resposta**:
  ```json
  {
    "value1": 5,
    "value2": 3,
    "resultado": 15
  }
  ```

### Divisão
- **Descrição**: Divide o primeiro número pelo segundo.
- **Rota**: `/api/calculadora/Division`
- **Método**: `GET`
- **Parâmetros**:
  - `value1` (double): Primeiro número.
  - `value2` (double): Segundo número.
- **Exemplo**:
  ```plaintext
  GET /api/calculadora/Division?value1=6&value2=3
  ```
  **Resposta**:
  ```json
  {
    "value1": 6,
    "value2": 3,
    "resultado": 2
  }
  ```

## Configuração do Projeto

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/marcosfov/Calculadora.git
   ```

2. **Navegue até o diretório do projeto**:
   ```bash
   cd Calculadora
   ```

3. **Restaure as dependências**:
   ```bash
   dotnet restore
   ```

4. **Execute o projeto**:
   ```bash
   dotnet run
   ```


## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
