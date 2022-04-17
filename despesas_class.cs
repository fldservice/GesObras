using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbges;

namespace GesObras
{
   public  class despesas_class
    {
       private teteenginhierEntities si =new teteenginhierEntities ();
       private enum tpplanos {
           Despesas,
           Receitas,
           Outros,
          
       
       }
       
        private enum recitas
        {
           Hospedagem,
            Vendas,
            Lavandaria,
           


        }
        //formas de pagamento
        private enum formapad
       {
           Dinheiro,
           Cartao, Cheque,Seguros,

       }
       //tipos de lancamento
       private enum tipodes
       { 

      Standard,
         Sweets
       
       }
       
       //despessa
       private enum despfixas { 
      
        Aluguer,
        Agua,
        Energia,
        Internet,
        Telvisao,
        Combustivel,
        Salario,
        Telefone,
        Material_de_limpeza,
        Tarifaz_Bancarias,
        Taxa_de_licenca,
        Dividas,

       
       
       }
        private enum tp_funcionarios//Internos ou externos
        {

            Internos,
            Externos,
        }
        private enum tpoprocessos//tipo de processo
        {

            Salario,
            Horas,
        }
        public void Rexeitas()
        {
            //cadastrar receitas por defeito
            planos de = new planos();
            var despfixas = Enum.GetValues(typeof(recitas)).Cast<recitas>().ToList();
            Random r = new Random();
            foreach (var item in despfixas)
            {
                de.tipodplanoid = 2;
                de.codplano = r.Next(9999).ToString();
                de.plano = item.ToString();
                si.planos.Add(de);
                si.SaveChanges();
            }
           



        }
        public void inserides()
        {
            //cadastrar despesas por defeito
            planos de = new planos();
            var despfixas = Enum.GetValues(typeof(despfixas)).Cast<despfixas>().ToList();
            Random r = new Random();
            foreach (var item in despfixas)
            {
                de.tipodplanoid = 1;
                de.codplano = r.Next(9999).ToString();
                de.plano = item.ToString();
                si.planos.Add(de);
                si.SaveChanges();
            }
            banco b = new banco();
            b.nomebanco = "Caixa";
            b.saldo = 0;
            b.nrcontabanco = "000Bog";
            si.banco.Add(b);
            si.SaveChanges();


        }
            void Rh_objects()//inseri dados do rh
        {
           // si = new SISFINANCAEntities();
            //tipo funcionarios
            //rh_tipo_func rh = new rh_tipo_func();
            //// rh.Nome_tipo_func
            //var tpfunc = Enum.GetValues(typeof(tp_funcionarios)).Cast<tp_funcionarios>().ToList();

            //foreach (var item in tpfunc)
            //{
            //    rh.Nome_tipo_func=item.ToString();
              
            //    si.rh_tipo_func.Add(rh);
            //    si.SaveChanges();
            //}

        }

        void Rh_processo()//inseri tipo de processos
        {
           // si = new SISFINANCAEntities();
            //tipo funcionarios
            //rh_tipo_proceso rh = new rh_tipo_proceso();
            //// rh.Nome_tipo_func
            //var tpfunc = Enum.GetValues(typeof(tpoprocessos)).Cast<tpoprocessos>().ToList();

            //foreach (var item in tpfunc)
            //{
            //    rh.Nome_tipo_processo = item.ToString();

            //    si.rh_tipo_proceso.Add(rh);
            //    si.SaveChanges();
            //}

        }
        public void tspplanos()
       {
            //registar salario e horas

            TP_Plano de = new TP_Plano();
            var despfixas = Enum.GetValues(typeof(tpplanos)).Cast<tpplanos>().ToList();
            foreach (var item in despfixas)
            {
                de.tipodeplano = item.ToString();
                de.abreviatura = item.ToString();
                si.TP_Plano.Add(de);
                si.SaveChanges();
            }




        }

       public void frmPaga()
       {

            formaPagamento f = new formaPagamento();
            var formas = Enum.GetValues(typeof(formapad)).Cast<formapad>().ToList();
            foreach (var item in formas)
            {
                f.formPag = item.ToString();
                si.formaPagamento.Add(f);
                si.SaveChanges();

            }
            
           
          
          
            //corer metodo do rh


        }

       public void userpermi()
       {
           
 //          User_group perm = new User_group();
 //          var userper = Enum.GetValues(typeof(usergrup)).Cast<usergrup>().ToList();
 //          foreach (var item in userper)
	//{
	//	  perm.Userg_nome = item .ToString();
 //         perm.Descricao = "fulControl";
 //              si.User_group.Add(perm); 
 //              si.SaveChanges();
	//}
 //           insetModulos();
 //           Rh_objects();
 //           Rh_processo();
 //           //registrar categorias
 //           Categorias_prod ct = new Categorias_prod();
 //           ct.categoria_nome = "Servicos";
 //           ct.controlStock = "Nao";
 //           ct.cate_descri = "Servicos prestados";
 //           ct.idEmpresass = 1;
 //           si.Categorias_prod.Add(ct);
 //           si.SaveChanges();

        }
        public void insetModulos()
        {

            //Modulos perm = new Modulos();
            //var userper = Enum.GetValues(typeof(modulos)).Cast<modulos>().ToList();
            //foreach (var item in userper)
            //{
            //    perm.Modulos1 = item.ToString();
            //    perm.estado = "false";
            //    si.Modulos.Add(perm);
            //    si.SaveChanges();
                
            //}

        }
    }
}
