const express = require('express');
const path = require('path');
const app = express();



app.use(express.static(path.join(__dirname, 'public')));


app.get('/gethello', (req, res) => {
    res.send('Hello NodeJS!!');
});
app.get('/', (req, res) => {
    res.sendFile(path.join(__dirname, 'public', 'q_1_hello.html'));
});
app.listen(8000, () => {
    console.log(`Server running on http://localhost:8000`);
});


