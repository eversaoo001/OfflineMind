import requests
import json

def ask_offlinemind(prompt):
    """Pergunta para IA 100% offline via Ollama"""
    url = "http://localhost:11434/api/generate"
    
    data = {
        "model": "phi3",
        "prompt": prompt,
        "stream": False
    }
    
    try:
        response = requests.post(url, json=data)
        result = response.json()
        return result['response']
    except Exception as e:
        return f"Erro: Verifique se o Ollama está rodando com 'ollama run phi3'. Detalhe: {e}"

# Teste inicial
if __name__ == "__main__":
    print("🧠 OfflineMind iniciado - 100% offline no seu Dell")
    print("Digite 'sair' para encerrar\n")
    
    while True:
        pergunta = input("Você: ")
        if pergunta.lower() in ['sair', 'exit', 'quit']:
            break
        
        print("OfflineMind pensando...")
        resposta = ask_offlinemind(pergunta)
        print(f"\nOfflineMind: {resposta}\n")
