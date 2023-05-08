# Importação das Bibliotecas
from pymongo import MongoClient
import pymongo

# Criação da String de Conexão
client = MongoClient("mongodb+srv://")

# Definindo o Banco de Dados
db = client.get_database('biblioteca')

# Definindo as Collections
records1 = db.plans
records2 = db.budgets
records3 = db.budgetcalculateds

# Fazendo uma busca full nas Collections
plans_docs1 = records1.find()
plans_docs2 = records2.find()
plans_docs3 = records3.find()
