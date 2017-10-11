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

public class Exercicio2 extends JFrame  {
	JTextField txtNum1 = new JTextField();
	
	JLabel lblDig1 = new JLabel ("Digite a temperatura em Fahrenheint");
	
	JButton btnRESULT = new JButton ("Resultado");
	
	JLabel lblResultC = new JLabel ();
	
	float temp;

	public Exercicio2(){
		
		super("Operações Temperaturas");
		Container paine = this.getContentPane();
					
				paine.add(lblDig1);
				lblDig1.setBounds(50, 20, 300, 25);
				
				paine.add(txtNum1);
				txtNum1.setBounds(50, 50, 200, 25);
				
				paine.add(btnRESULT);
				btnRESULT.setBounds(70, 400, 100, 25);
				btnRESULT.addActionListener(new ActionListener() {
					@Override
					public void actionPerformed(ActionEvent e) {
						// TODO Auto-generated method stub
						temp = Float.parseFloat(txtNum1.getText());
						//execut calc = new exec();
						
						lblResultC.setText ("Converção: "+((temp-32)/1.8)+"°C");
						
					}
				});
		
				paine.add(lblResultC);
				lblResultC.setBounds(50, 200, 200, 25);
		
		paine.setLayout(null); // posicionamento dos objetos do layout
		this.setSize(350,500); // tamanho da tela
		this.setVisible(true);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
	}
	
	public static void main (String[] args){
		Exercicio2 execut = new Exercicio2();
	}
}
