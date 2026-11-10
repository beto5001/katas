'use strict';

const assert = require('assert');
const { timeConversion } = require('../src/katas/time-conversion');

const cases = [
  ['converte um horário PM comum', '07:05:45PM', '19:05:45'],
  ['mantém meio-dia como 12 horas', '12:00:00PM', '12:00:00'],
  ['converte meia-noite para zero hora', '12:00:00AM', '00:00:00'],
  ['mantém um horário AM comum', '01:01:01AM', '01:01:01']
];

let failures = 0;

for (const [description, input, expected] of cases) {
  try {
    assert.strictEqual(timeConversion(input), expected);
    console.log(`✓ ${description}`);
  } catch (error) {
    failures += 1;
    console.error(`✗ ${description}`);
    console.error(`  ${error.message}`);
  }
}

assert.strictEqual(failures, 0, `${failures} teste(s) falharam.`);
