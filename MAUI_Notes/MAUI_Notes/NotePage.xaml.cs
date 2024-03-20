namespace MAUI_Notes;

public partial class NotePage : ContentPage
{
	string path = Path.Combine(FileSystem.AppDataDirectory,"notes.txt");
	string texto = "";
	public NotePage()
	{
		InitializeComponent();
		TextEditor.Text = File.ReadAllText(path);

	}

    private void SaveButton_Clicked(object sender, EventArgs e)
	{
		//Ler oque a pessoa digitou
		texto = TextEditor.Text;
		//Armazenar em uma variável 
		//Salvar (Criar um arquivo que o conteúdo é o que a pessoa digitou)
		File.WriteAllText(path, texto);
	}

	private void DeleteButton_Clicked(Object sender, EventArgs e)
	{

	}