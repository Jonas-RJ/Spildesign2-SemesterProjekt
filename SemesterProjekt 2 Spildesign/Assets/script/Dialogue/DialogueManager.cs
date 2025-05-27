using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText; 
    public TextMeshProUGUI dialogueText;
    
    public Animator animator;
    
    public GameObject startJourneyButton;
    
    
    
    private Queue<string> sentences;                //Keeps track of all the sentences in our dialogue box.
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sentences = new Queue<string>();            //Initializes the queue.
        startJourneyButton.SetActive(false);
        
    }

    public void StartDialogue(Dialogue dialogue) //This function gets started on the click of the "Start Game" button.
    {
        animator.SetBool("IsOpen", true); //Makes sure the dialogue box actually gets on the screen.
        
        nameText.text = dialogue.name; //Actually sets the text in the dialogue box to our dialogue.
        
        sentences.Clear(); //Clearing any sentences in the queue from a previous conversation.

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence); //Puts every sentence in the queue.
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence() //This method gets called in the OnClick in the inspector on the continue button.
    {
        if (sentences.Count == 0) //Making sure that there is even more sentences to queue.
        {
            //EndDialogue(); //Ending the dialogue and sliding the canvas off the screen
            
            return;
        }
        else if (sentences.Count == 1)
        {
            startJourneyButton.SetActive(true);
        }
        string sentence = sentences.Dequeue(); //Gets the next sentence in the queue.
        StopAllCoroutines(); //Stop animating before an eventual new dialogue gets opened. So makes sure that if TypeSentence is already running it stops doing so.
        StartCoroutine(TypeSentence(sentence)); 
    }

    IEnumerator TypeSentence(string sentence) 
    {
        dialogueText.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter; //Appends a letter to the end of the string.
            yield return null; //Makes sure the text appears smoothly on the screen
        }
    }

    public void EndDialogue()
    {
        if (sentences.Count == 0)
        {
            animator.SetBool("IsOpen", false); //Makes sure the dialogue box gets off the screen.
        }
    }

    public void LoadSceneToStartGame()
    {
        SceneManager.LoadScene("Map");
        
    }

    public void CloseOnWalkaway()
    {
                    animator.SetBool("IsOpen", false); //Makes sure the dialogue box gets off the screen.
    }
}
