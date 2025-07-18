const AdmZip = require('adm-zip');
const path = require('path');
const zipPath = path.join(__dirname, 'my-folder.zip');
const outputDir = path.join(__dirname, 'q_5');

try {
  const zip = new AdmZip(zipPath);
  zip.extractAllTo(outputDir, true);
  console.log(` Extracted to: ${outputDir}`);
} catch (err) {
  console.error(' Failed to extract ZIP:', err.message);
}