
const fs = require('fs');
const path = require('path');

fs.writeFileSync('example.txt', 'Hello from nidhi', 'utf8');
console.log(' File written successfully.');

const content = fs.readFileSync('example.txt', 'utf8');
console.log(' File content:', content);

fs.appendFileSync('example.txt', '\nThis is additional content.', 'utf8');
console.log(' Content appended.');

fs.renameSync('example.txt', 'renamed_example.txt');
console.log(' File renamed to renamed_example.txt');

const exists = fs.existsSync('renamed_example.txt');
console.log(` File exists? ${exists}`);

//fs.unlinkSync('renamed_example.txt');
//console.log(' File deleted.');