using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CozerOvos : MonoBehaviour
{
    public Text cronometroTexto; // Referência ao texto que mostra o tempo
    public Text estadoTexto; // Referência ao texto que mostra o estado de cozimento
    public Text mexaTexto; // Novo texto para a mensagem "Mexa os ovos!!"
    public Button playPauseBotao; // Referência ao botão de play/pause
    public Text botaoTexto; // Referência ao texto do botão
    public Button botaoInvisivel; // Referência ao botão invisível que será mostrado quando o tempo chegar a zero

    private float tempoRestante = 60f; // Tempo inicial em segundos (3 minutos)
    private bool estaRodando = false; // Estado do cronômetro

    void Start()
    {
        AtualizarTexto();
        AtualizarTextoEstado(); // Atualiza o estado inicial do texto de cozimento
        AtualizarTextoBotao(); // Atualiza o texto do botão no início
        mexaTexto.gameObject.SetActive(false); // Oculta o texto "Mexa os ovos!!" inicialmente
        playPauseBotao.onClick.AddListener(TrocarEstado); // Adiciona listener ao botão
        botaoInvisivel.gameObject.SetActive(false); // Inicialmente o botão invisível está oculto
        StartCoroutine(MostrarMensagemPiscar()); // Inicia a coroutine para mostrar a mensagem a piscar
    }

        void Update()
        {
            if (estaRodando && tempoRestante > 0)
            {
                tempoRestante -= Time.deltaTime; // Diminui o tempo baseado no deltaTime
                AtualizarTexto();
                AtualizarTextoEstado();

                if (tempoRestante <= 0)
                {
                    tempoRestante = 0;
                    estaRodando = false; // Para o cronômetro quando chega a zero
                    AtualizarTexto();
                    AtualizarTextoEstado(); // Certifica-se de que o estado é atualizado
                    MostrarBotaoInvisivel(); // Torna o botão visível
                    StartCoroutine(MostrarMensagemPiscar()); // Inicia a coroutine para mostrar a mensagem a piscar
                }
            }
        }


    void TrocarEstado()
    {
        estaRodando = !estaRodando; // Alterna entre play e pause
        AtualizarTextoBotao(); // Atualiza o texto do botão quando o estado muda
    }

    void AtualizarTexto()
    {
        int minutos = Mathf.FloorToInt(tempoRestante / 60);
        int segundos = Mathf.FloorToInt(tempoRestante % 60);
        cronometroTexto.text = string.Format("{0:00}:{1:00}", minutos, segundos); // Formata o tempo
    }

    void AtualizarTextoEstado()
    {
        if (tempoRestante > 40) // Mais de 2 minutos restantes
        {
            estadoTexto.text = "Inicio! Continar a cozinhar devagar.";
            estadoTexto.color = Color.red; // Vermelho para quase pronto
        }
        else if (tempoRestante > 20) // Entre 1 e 2 minutos restantes
        {
            estadoTexto.text = "Quase pronto. Mexer bem!";
            estadoTexto.color = Color.yellow; // Amarelo para cozimento médio
        }
        else if (tempoRestante > 10) // Menos de 1 minuto restante
        {
            estadoTexto.text = "Falta pouco! Atenção.";
            estadoTexto.color = new Color32(144, 238, 144, 255); // Verde claro (Light Green)
        }
        else // Tempo esgotado
        {
            estadoTexto.text = "Pronto! Desligue o fogão.";
            estadoTexto.color = Color.green;
        }
    }

    void AtualizarTextoBotao()
    {
        if (estaRodando)
        {
            botaoTexto.text = "Pausa"; // Texto do botão quando o cronômetro está rodando
        }
        else
        {
            botaoTexto.text = ""; // Texto do botão quando o cronômetro está pausado
        }
    }

    public void MostrarBotaoInvisivel()
    {
        // Mostra o botão invisível quando o tempo acaba
        botaoInvisivel.gameObject.SetActive(true);
    }

    IEnumerator MostrarMensagemPiscar()
    {
        yield return null; // Certifique-se de que a execução continua corretamente
        bool tempoAcabou = false; // Flag para verificar se o tempo acabou

        while (true)
        {
            if (tempoRestante > 0)
            {
                // A cada 20 segundos, a mensagem "Mexer os ovos" irá piscar.
                yield return new WaitForSeconds(20f); // Espera 20 segundos

                mexaTexto.gameObject.SetActive(true); // Mostra o texto "Mexer os ovos!!"
                for (int i = 0; i < 6; i++) // Pisca 6 vezes (3 segundos)
                {
                    mexaTexto.text = "Mexer os ovos!!";
                    mexaTexto.color = new Color(1f, 0.647f, 0f); // Cor laranja
                    yield return new WaitForSeconds(0.5f);

                    mexaTexto.text = "";
                    yield return new WaitForSeconds(0.5f);
                }
                mexaTexto.gameObject.SetActive(false);
            }
            else if (tempoRestante <= 0 && !tempoAcabou)
            {
                // Quando o tempo chega a zero, começa a piscar "Desligar o fogão!" sem esperar mais nada
                tempoAcabou = true; // Marca que o tempo acabou, para evitar reiniciar o loop
                mexaTexto.gameObject.SetActive(true); // Mostra a mensagem "Desligar o fogão!"
                while (tempoRestante == 0) // Continuar piscando enquanto o tempo for zero
                {
                    mexaTexto.text = "Desligar o fogão!";
                    mexaTexto.color = Color.red; // Cor vermelha para a mensagem
                    yield return new WaitForSeconds(0.5f);

                    mexaTexto.text = "";
                    yield return new WaitForSeconds(0.5f);
                }
            }
        }
    }
}
