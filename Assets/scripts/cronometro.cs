using UnityEngine;
using UnityEngine.UI;

public class cronometro : MonoBehaviour
{
    public Text cronometroTexto; // Referência ao texto que mostra o tempo
    public Button playPauseBotao; // Referência ao botão de play/pause
    public Button reiniciarBotao; // Referência ao botão de reiniciar
    public Button botaoFinalizar; // Referência ao botão de reiniciar
    public Sprite imagemIniciar; // Imagem para o estado "Iniciar"
    public Sprite imagemPausa; // Imagem para o estado "Pausa"

    private float tempoRestante; // Tempo inicial em segundos
    private bool estaRodando = false; // Estado do cronômetro

    void Start()
    {
        tempoRestante = 30f;
        AtualizarTexto();
        AtualizarImagemBotao(); // Atualiza a imagem do botão no início
        playPauseBotao.onClick.AddListener(TrocarEstado); // Adiciona listener ao botão play/pause
        reiniciarBotao.onClick.AddListener(ReiniciarTempo); // Adiciona listener ao botão de reiniciar
        botaoFinalizar.gameObject.SetActive(false); // Inicialmente o botão ficará invisível
    }

    void Update()
    {
        if (estaRodando && tempoRestante > 0)
        {
            tempoRestante -= Time.deltaTime; // Diminui o tempo baseado no deltaTime
            AtualizarTexto();

            if (tempoRestante <= 0)
            {
                tempoRestante = 0f; // Reseta o tempo para o valor inicial
                estaRodando = false; // Para o cronômetro
                AtualizarTexto(); // Atualiza o texto do cronômetro
                AtualizarImagemBotao(); // Atualiza a imagem do botão de play/pause
                botaoFinalizar.gameObject.SetActive(true); // Esconde o botão de finalizar
            }
        }
    }

    void TrocarEstado()
    {
        estaRodando = !estaRodando; // Alterna entre play e pause
        AtualizarImagemBotao(); // Atualiza a imagem do botão quando o estado muda
    }

    public void ReiniciarTempo()
    {
        tempoRestante = 30f; // Reseta o tempo para o valor inicial
        estaRodando = false; // Para o cronômetro
        AtualizarTexto(); // Atualiza o texto do cronômetro
        AtualizarImagemBotao(); // Atualiza a imagem do botão de play/pause
    }

    void AtualizarTexto()
    {
        int minutos = Mathf.FloorToInt(tempoRestante / 60);
        int segundos = Mathf.FloorToInt(tempoRestante % 60);
        cronometroTexto.text = string.Format("{0:00}:{1:00}", minutos, segundos); // Formata o tempo
    }

    void AtualizarImagemBotao()
    {
        Image botaoImagem = playPauseBotao.GetComponent<Image>();

        if (estaRodando)
        {
            botaoImagem.sprite = imagemPausa; // Define a imagem de pausa
        }
        else
        {
            botaoImagem.sprite = imagemIniciar; // Define a imagem de iniciar
        }
    }
}
