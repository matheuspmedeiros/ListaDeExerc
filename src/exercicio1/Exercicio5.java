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

public class Exercicio5 extends JFrame {
		
		JTextField txtNum1 = new JTextField();
		JLabel lblDig1 = new JLabel ("Digite a altura do Triangulo");
		
		
		JLabel lblDig2 = new JLabel ("Digite a base do triangulo");
		JTextField txtNum2 = new JTextField();
		
		JButton btnRESULT = new JButton ("Resultado");
		
		JLabel lblResultC = new JLabel ();
		
		float base, alt;
		public Exercicio5(){
			
			super("Operações Temperaturas");
			Container paine = this.getContentPane();
						
					paine.add(lblDig1);
					lblDig1.setBounds(50, 20, 300, 25);
					
					paine.add(txtNum1);
					txtNum1.setBounds(50, 50, 200, 25);
					
					paine.add(lblDig2);
					lblDig2.setBounds(50, 70, 300, 25);
					
					paine.add(txtNum2);
					txtNum2.setBounds(50, 100, 200, 25);
					
					
					paine.add(btnRESULT);
					btnRESULT.setBounds(70, 400, 100, 25);
					btnRESULT.addActionListener(new ActionListener() {
						@Override
						public void actionPerformed(ActionEvent e) {
							// TODO Auto-generated method stub
							alt = Float.parseFloat(txtNum1.getText());
							base = Float.parseFloat(txtNum2.getText());
							//execut calc = new exec();
							
							lblResultC.setText ("area do triangulo "+((alt*base)/2));
							
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
			Exercicio5 executa = new Exercicio5();
		}
}
