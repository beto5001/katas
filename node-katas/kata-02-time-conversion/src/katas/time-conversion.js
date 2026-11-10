'use strict';

/**
 * Converte um horário de 12 horas para o formato de 24 horas.
 *
 * @param {string} time horário no formato hh:mm:ssAM ou hh:mm:ssPM
 * @returns {string} horário no formato HH:mm:ss
 */
function timeConversion(time) {
  let hora = Number(time.slice(0, 2));  
  const isAm = time.endsWith('AM');

  if (hora == 12) {
    hora = isAm ? 0 : 12;
  } else if (!isAm) {
    hora += 12;
  }

  const horaString = String(hora).padStart(2, '0');
  
  return `${horaString}${time.slice(2, 8)}`
}

module.exports = { timeConversion };
