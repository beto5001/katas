# Kata 2 — Time Conversion

Converta um horário de 12 horas (`hh:mm:ssAM` ou `hh:mm:ssPM`) para o formato de 24 horas (`HH:mm:ss`).

Exemplos:

- `07:05:45PM` → `19:05:45`
- `12:00:00AM` → `00:00:00`
- `12:00:00PM` → `12:00:00`

## Sua tarefa

Implemente `timeConversion` em `src/katas/time-conversion.js`. A função deve devolver o horário convertido ou lançar um erro para uma entrada inválida.

## Testes

```bash
npm test
```

Os testes começam falhando: isso é esperado até você implementar a solução.

## API HTTP

Inicie o servidor:

```bash
npm start
```

Envie uma requisição `POST` para `http://localhost:3000/api/katas/2/time-conversion`:

```json
{
  "time": "07:05:45PM"
}
```

Após implementar o kata, a resposta de sucesso será:

```json
{
  "militaryTime": "19:05:45"
}
```

