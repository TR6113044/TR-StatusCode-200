#pragma once

namespace CppCLRWinformsProjekt {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace System::Diagnostics;

	/// <summary>
	/// Zusammenfassung für Form1
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
			//
			//TODO: Konstruktorcode hier hinzufügen.
			//
		}

	protected:
		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ btnAskChatbot;
	protected:

	protected:

	private:
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		void InitializeComponent(void)
		{
			this->btnAskChatbot = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// btnAskChatbot
			// 
			this->btnAskChatbot->BackColor = System::Drawing::Color::Transparent;
			this->btnAskChatbot->BackgroundImageLayout = System::Windows::Forms::ImageLayout::None;
			this->btnAskChatbot->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9.75F));
			this->btnAskChatbot->ForeColor = System::Drawing::SystemColors::ControlText;
			this->btnAskChatbot->Location = System::Drawing::Point(66, 73);
			this->btnAskChatbot->Name = L"btnAskChatbot";
			this->btnAskChatbot->Size = System::Drawing::Size(96, 49);
			this->btnAskChatbot->TabIndex = 0;
			this->btnAskChatbot->Text = L"Ask-Chatbot";
			this->btnAskChatbot->UseVisualStyleBackColor = false;
			this->btnAskChatbot->Click += gcnew System::EventHandler(this, &Form1::btnAskChatbot_Click);
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(284, 261);
			this->Controls->Add(this->btnAskChatbot);
			this->Name = L"Form1";
			this->Text = L"Client Desktop App";
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void btnAskChatbot_Click(System::Object^ sender, System::EventArgs^ e) {
		Process::Start("C:\\TR-ChatBot\\TR-ChatBot\\bin\\Debug\\TR-ChatBot.exe");
	}
	};
}
