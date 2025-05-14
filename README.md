🤖 Cybro – Your Friendly Cybersecurity Companion

**Cybro** is a console-based chatbot built in C# designed to raise awareness about cybersecurity. It educates users by providing tips on various cybersecurity topics and simulates natural conversation through dynamic responses, sentiment detection, and memory features.

🛠️ Features

✅ General Chat
- Cybro greets users and introduces its purpose.
- Responds naturally to user questions like “How are you?” with follow-up sentiment detection.

🧠 Keyword Recognition
- Detects and responds to cybersecurity-related keywords like `password`, `phishing`, `ransomware`, etc.
- Suggests relevant advice or tips based on user input.

🎲 Random Responses
- Provides a variety of tips for each cybersecurity topic.
- Responses are randomly selected from a predefined list to keep interaction engaging.

💬 Sentiment Detection
- Recognizes basic emotions like *worried*, *anxious*, *curious*, or *tired*.
- Adjusts its tone and message accordingly.

🧾 Memory & Recall
- Remembers what topic the user is interested in.
- Brings up relevant tips later in the conversation.

🧭 Navigation
- Menu system allows the user to:
  - Chat with Cybro
  - Explore a list of cybersecurity topics
  - Exit the application

🎨 Enhanced Console UX
- Colored text for clear distinction between user and bot.
- Typewriter effect for a more interactive feel.

📂 Project Structure
Cybro/
│
├── Program.cs # Entry point
├── Greeting.cs # Welcome message and audio
├── Menu.cs # Displays main options
├── Chat.cs # Handles chat logic, memory, sentiment, tips
├── Topics.cs # Educational cybersecurity content
├── TypeEffect.cs # Implements the typewriter effect
└── welcome2cybro.wav # Optional welcome sound (Windows only)


🔧 How to Run

1. Clone the repository:
2. Open the solution in Visual Studio.
3. Build and run the project.
4. Interact with Cybro from the terminal.

👨‍🎓 Educational Use

This chatbot is designed as part of a **Software Development** assignment to demonstrate:
- Use of collections
- Delegates (planned in later stages)
- Logical branching
- Modularity and maintainability
- Beginner-friendly implementation of AI-like behavior

📌 Future Improvements
- Expand sentiment detection with NLP
- GUI version using Windows Forms or WPF
- Logging user queries
- Voice output using TTS


Note: This is a console app meant for educational use and basic interactivity. It is not connected to the internet and does not store data externally.



📃 License

MIT License - You’re free to use, share, and modify this project with proper attribution.





