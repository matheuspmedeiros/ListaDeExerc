package exercicio1;
		import java.awt.Container;
		import java.awt.event.ActionEvent;
		import java.awt.event.ActionListener;
		
		import javax.swing.JLabel;
		import javax.swing.JRadioButton;
		import javax.swing.ButtonGroup;
		import javax.swing.JFrame;
		import javax.swing.JTextField;
		import javax.swing.JButton;
		import javax.swing.JComboBox;
		import javax.swing.JFormattedTextField;
		import javax.swing.text.MaskFormatter;
		
		
		
public class exec extends JFrame {
	
	//numeros 
	JTextField txtNum1 = new JTextField();
	JTextField txtNum2 = new JTextField();
	
	// 
	JLabel lblDig1 = new JLabel ("Digite o 1° numero");
	JLabel lblDig2 = new JLabel ("Digite o 2° numero");
	
	JButton btnRESULT = new JButton ("Resultado");
	
	JLabel lblResultM = new JLabel ();
	JLabel lblResultD = new JLabel ();
	JLabel lblResultP = new JLabel ();
	
	double valor1, valor2, resultM;
	
	public exec(){
		
		super("Operações matematicas");
		Container paine = this.getContentPane();
		
		//primeiro label 
			paine.add(lblDig1);
			lblDig1.setBounds(120, 20, 200, 25);
			
			paine.add(txtNum1);
			txtNum1.setBounds(70, 50, 200, 25);
			
			
		//segundo numero
			paine.add(lblDig2);
			lblDig2.setBounds(120, 80, 200, 25);
			
			paine.add(txtNum2);
			txtNum2.setBounds(70, 110, 200, 25);
			
			
			
			paine.add(btnRESULT);
			btnRESULT.setBounds(70, 400, 100, 25);
			btnRESULT.addActionListener(new ActionListener() {
				@Override
				public void actionPerformed(ActionEvent e) {
					// TODO Auto-generated method stub
					valor1 = Double.parseDouble(txtNum1.getText());
					valor2 = Double.parseDouble(txtNum2.getText());
					exec calc = new exec();
					
					lblResultM.setText ("Soma: "+(valor1+valor2));
					lblResultD.setText ("Diferença : "+(valor1-valor2));
					lblResultP.setText ("Produto: " +(valor1*valor2));
				}
			});
			
			
			paine.add(lblResultM);
			lblResultM.setBounds(120, 200, 200, 25);
			
			paine.add(lblResultD);
			lblResultD.setBounds(120, 220, 200, 25);
			
			paine.add(lblResultP);
			lblResultP.setBounds(120, 240, 200, 25);
			
			
		paine.setLayout(null); // posicionamento dos objetos do layout
		this.setSize(350,500); // tamanho da tela
		this.setVisible(true);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
	}
	
	public static void main (String[] args){
		exec executar = new exec();
	}
}
