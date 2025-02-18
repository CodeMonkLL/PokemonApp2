// Importiere notwendige Module
const express = require('express');
const mongoose = require('mongoose');
const app = express();
const port = 3000;

// Importiere das Pokémon-Modell (das Schema)
const Pokemon = require('./models/pokemon');

// Middleware, um JSON-Daten im Request zu verarbeiten
app.use(express.json());

// Verbinde mit der MongoDB-Datenbank
mongoose.connect('mongodb://localhost:27017/pokemonDB', {
    useNewUrlParser: true,
    useUnifiedTopology: true
})
.then(() => console.log('Erfolgreich mit der Datenbank verbunden!'))
.catch((error) => console.log('Fehler beim Verbinden mit der Datenbank:', error));

// Endpunkt, um ein Pokémon zu speichern
app.post('/api/pokemon/save', async (req, res) => {
    try {
        const newPokemon = new Pokemon(req.body);  // Pokémon aus den Request-Daten erstellen
        await newPokemon.save();  // Pokémon in der MongoDB speichern
        res.status(201).json({ message: 'Pokémon erfolgreich gespeichert!', pokemon: newPokemon });
    } catch (error) {
        res.status(400).json({ message: 'Fehler beim Speichern des Pokémon.' });
    }
});

// Server starten
app.listen(port, () => {
    console.log(`Server läuft auf http://localhost:${port}`);
});
