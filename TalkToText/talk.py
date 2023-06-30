import tkinter as tk
import speech_recognition as sr
from tkinter import messagebox

def Speech_to_Text():
    
    r = sr.Recognizer()

    with sr.Microphone() as source:
        try:
            audio = r.listen(source)
            text = r.recognize_google(audio)
            txtSpeech.insert(tk.END, text + "\n")
        except sr.UnknownValueError:
            txtSpeech.insert(tk.END, text + "Could not understand audio!\n")
        except sr.RequestError as e:
            txtSpeech.insert(tk.END, text + "Error: {0}\n".format(e))

def Exit_Speech():
    iExit = messagebox.askquestion("Exit", "Confirm if you want to exit?")
    if iExit == 'yes':
        messagebox.showinfo("Exit Speech", "See you later")
        root.destroy()

def Reset_Speech():
    txtSpeech.delete("1.0", tk.END)

root = tk.Tk()
root.title ("Speech to Text")

RootFrame = tk.Frame(root, width= 800, height= 600, bd=20, bg='aliceblue')
RootFrame.pack()

MainFrame = tk.Frame(RootFrame, width= 720, height= 540, bd=20)
MainFrame.pack()

lblTitle = tk.Label(MainFrame, font=('kristen itc', 60, 'bold'), width= 20, text="Speech to Text")
lblTitle.pack()

txtSpeech = tk.Text(MainFrame, font=('kristen itc', 30, 'bold'), width= 70, height= 13)
txtSpeech.pack()

btnConvert = tk.Button(MainFrame, font=('kristen itc', 30, 'bold'), width= 20, height= 2, text="Convert",
                        command=Speech_to_Text)
btnConvert .pack(side='left',padx=10)

btnReset = tk.Button(MainFrame, font=('kristen itc', 30, 'bold'), width= 20, height= 2, text="Reset",
                    command=Reset_Speech)
btnReset .pack(side='left',padx=10)

btnExit = tk.Button(MainFrame, font=('kristen itc', 30, 'bold'), width= 20, height= 2, text="Exit", 
                    command=Exit_Speech)
btnExit .pack(side='left',padx=10)

root.mainloop()