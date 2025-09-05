# Budget-Tracker

Description
A platform that helps users manage expenses, set savings goals, and receive AI-powered recommendations for smarter financial decisions.

## Tech Stack
- PyTorch
- FastAPI
- ASP.NET Core

## Requirements
- Transaction categorization system (support custom and auto-categorized transactions)
- Budget tracking with goal progress (recalculate after each transaction)
- AI-powered spending insights (start with static rules before integrating AI models)

## Installation
1. Clone the repository:
   bash
   git clone https://github.com/yourusername/Budget-Tracker.git
   
2. ASP.NET Core Backend:
   bash
   cd Budget-Tracker/backend-dotnet
   dotnet restore
   dotnet build
   
3. FastAPI AI Service:
   bash
   cd Budget-Tracker/ai-service
   python3 -m venv venv
   source venv/bin/activate   # On Windows use venv\\Scripts\\activate
   pip install -r requirements.txt
   
4. Set environment variables:
   - DATABASE_URL: Connection string for your database
   - AI_MODEL_PATH: Path to store or load static rules or ML model artifacts

## Usage
1. Start the ASP.NET Core backend:
   bash
   cd backend-dotnet
   dotnet run
   
2. Start the FastAPI AI service:
   bash
   cd ai-service
   uvicorn main:app --reload
   
3. Use the API endpoints (see API Endpoints section) to manage transactions, budgets, and get spending insights.

## Implementation Steps
1. Initialize the ASP.NET Core Web API project and configure Entity Framework Core with the database context.
2. Define models for Users, Transactions, Categories, and Budgets in the ASP.NET Core project.
3. Implement transaction CRUD endpoints in ASP.NET Core:
   - POST /transactions
   - GET /transactions
   - PUT /transactions/{id}
   - DELETE /transactions/{id}
4. Add budget management endpoints in ASP.NET Core:
   - POST /budgets
   - GET /budgets
   - GET /budgets/{id}
5. Create a FastAPI service that loads static categorization rules and implements a POST /insights/spending endpoint.
6. Integrate PyTorch and define placeholder logic for AI-powered insights, starting with static rule-based recommendations.
7. Configure the ASP.NET Core backend to call the FastAPI AI service for spending insights after each transaction.
8. Ensure that after each transaction the budget goal progress is recalculated and updated.
9. Write unit and integration tests for both services to validate functionality.

## API Endpoints
### ASP.NET Core Backend
- POST /transactions: Create a new transaction
- GET /transactions: List all transactions
- PUT /transactions/{id}: Update an existing transaction
- DELETE /transactions/{id}: Remove a transaction
- POST /budgets: Create a new budget goal
- GET /budgets: List all budget goals
- GET /budgets/{id}: Get specific budget goal details

### FastAPI AI Service
- POST /insights/spending: Provide spending data and receive categorization and saving insights