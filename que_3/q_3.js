
const responses = {
  'hello': 'Hi there! How can I help you today?',
  'symptoms': 'Can you describe your symptoms in detail?',
  'fever': 'For a fever, you should stay hydrated and consider seeing a doctor if it persists.',
  'headache': 'Try resting in a quiet dark room and stay hydrated. Consult a doctor if it’s frequent.',
  'exit': 'Take care! Goodbye.'
};

function getBotResponse(input) {
  input = input.toLowerCase().trim();
  return responses[input] || 'Sorry, I didn’t understand that. Can you rephrase?';
}

module.exports = { getBotResponse };