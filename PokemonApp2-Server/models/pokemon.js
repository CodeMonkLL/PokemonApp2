// models/pokemon.js - Mongoose-Schema für Pokémon

const mongoose = require('mongoose');  // Importiere Mongoose

// Erstelle das Schema für ein Pokémon
const pokemonSchema = new mongoose.Schema({
    name: {
        type: String,  // Der Name des Pokémon ist ein String
        required: true,  // Der Name ist erforderlich
        unique: true,  // Der Name muss eindeutig sein
    },
    id: {
        type: Number,  // Die ID des Pokémon ist eine Zahl
        required: true,
        unique: true,  // ID muss ebenfalls einzigartig sein
    },
    types: [String],  // Ein Array von Typen (z.B. ['Electric', 'Fire'])
    height: {
        type: Number,  // Die Höhe des Pokémon in Metern
        required: true,
    },
    weight: {
        type: Number,  // Das Gewicht des Pokémon in Kilogramm
        required: true,
    }
});

// Erstelle ein Mongoose-Modell aus dem Schema
const Pokemon = mongoose.model('Pokemon', pokemonSchema);

// Exportiere das Modell, um es in anderen Dateien zu verwenden
module.exports = Pokemon;
