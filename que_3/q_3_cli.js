
const readline = require('readline');
const { getBotResponse } = require('./q_3');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

console.log('🩺 Medical Assistant Chatbot (Type "exit" to quit)');
rl.setPrompt('You: ');
rl.prompt();

rl.on('line', (input) => {
  const response = getBotResponse(input);
  console.log(`Bot: ${response}`);

  if (input.toLowerCase().trim() === 'exit') {
    rl.close();
  } else {
    rl.prompt();
  }
});