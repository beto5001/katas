'use strict';

const http = require('http');
const { timeConversion } = require('./katas/time-conversion');

const PORT = process.env.PORT || 3000;
const TIME_CONVERSION_PATH = '/api/katas/2/time-conversion';

function writeJson(response, statusCode, body) {
  response.writeHead(statusCode, { 'Content-Type': 'application/json; charset=utf-8' });
  response.end(JSON.stringify(body));
}

function readJson(request) {
  return new Promise((resolve, reject) => {
    let body = '';

    request.on('data', (chunk) => {
      body += chunk;
    });

    request.on('end', () => {
      try {
        resolve(JSON.parse(body));
      } catch (error) {
        reject(new Error('O corpo da requisição deve ser um JSON válido.'));
      }
    });

    request.on('error', reject);
  });
}

const server = http.createServer(async (request, response) => {
  if (request.method === 'GET' && request.url === '/health') {
    writeJson(response, 200, { status: 'ok' });
    return;
  }

  if (request.method === 'POST' && request.url === TIME_CONVERSION_PATH) {
    try {
      const { time } = await readJson(request);
      writeJson(response, 200, { militaryTime: timeConversion(time) });
    } catch (error) {
      writeJson(response, 400, { error: error.message });
    }
    return;
  }

  writeJson(response, 404, { error: 'Rota não encontrada.' });
});

server.listen(PORT, () => {
  console.log(`API disponível em http://localhost:${PORT}`);
});

