using PJ01DAO_SQL;
using PJ01Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ01AcessoBancoDados
{
    public class PessoaEquipamentoDAO
    {

        Banco banco = new Banco();
        DataTable tabelaSelect;


        public void AlterarEquipamento(PessoaEquipamentoModel Equipamento)
        {
            // section -64--88-56-1-189bbc2c:155330fba3d:-8000:0000000000000B08 begin
            // section -64--88-56-1-189bbc2c:155330fba3d:-8000:0000000000000B08 end

        }


        private void InserirPessoaEquipamento(PessoaEquipamentoModel Equipamento)
        {
            string sql = "INSERT INTO PESSOAEQUIPAMENTO ("
                + "EQUIPAMENTOID, PESSOAID, EQUIPAMENTOTIPOID, DATACADASTRO, FABRICANTE,"
                + "MODELO, NUMEROSERIE, ETIQUETAID, PRATIMONIOID, NOMEPCREDE, REDEIPFIXO,"
                + "PROCESSADOR, PLACAMAE, MEMORIA, PLACAVGA, PLACAREDE, HD, DRIVERDVD, MONITOR,"
                + "FONTEALIMENTACAO, IMPRESSORAS, IMPRESSORASIP, SCANNER, FORNECEDOR, COMPRADATA, "
                + "COMPRAGARANTIA, NOTAFISCAL, EQUIPAMENTOESTADO, EQUIPAMENTOVALOR, OBSERVACOES) "
                + "VALUES ("
                + "@EQUIPAMENTOID, @PESSOAID, @EQUIPAMENTOTIPOID, '@DATACADASTRO', '@FABRICANTE',"
                + "'@MODELO', '@NUMEROSERIE', '@ETIQUETAID', '@PRATIMONIOID', '@NOMEPCREDE', '@REDEIPFIXO',"
                + "'@PROCESSADOR', '@PLACAMAE', '@MEMORIA, '@PLACAVGA', '@PLACAREDE', '@HD', '@DRIVERDVD', @MONITOR,"
                + "'@FONTEALIMENTACAO', '@IMPRESSORAS', '@IMPRESSORASIP', '@SCANNER','@FORNECEDOR', '@COMPRADATA', "
                + "'@COMPRAGARANTIA', '@NOTAFISCAL', 'EQUIPAMENTOESTADO', '@EQUIPAMENTOVALOR', '@OBSERVACOES')";

            sql = sql.Replace("@EQUIPAMENTOID", Equipamento.equipamentoId.ToString());
            sql = sql.Replace("@PESSOAID", Equipamento.pessoaID.ToString());
            sql = sql.Replace("@EQUIPAMENTOTIPOID", Equipamento.equipamentoTipoId.ToString());
            sql = sql.Replace("@DATACADASTRO", Equipamento.dataCadastro.ToString());
            sql = sql.Replace("@FABRICANTE", Equipamento.fabricante);
            sql = sql.Replace("@MODELO", Equipamento.modelo);
            sql = sql.Replace("@NUMEROSERIE", Equipamento.numeroSerie);
            sql = sql.Replace("@ETIQUETAID", Equipamento.etiquetaId);
            sql = sql.Replace("@PRATIMONIOID", Equipamento.pratimonioId);
            sql = sql.Replace("@NOMEPCREDE", Equipamento.nomePcRede);
            sql = sql.Replace("@REDEIPFIXO", Equipamento.redeIpFixo);
            sql = sql.Replace("@PROCESSADOR", Equipamento.processador);
            sql = sql.Replace("@PLACAMAE", Equipamento.placaMae);
            sql = sql.Replace("@MEMORIA", Equipamento.memoria);
            sql = sql.Replace("@PLACAVGA", Equipamento.placaVga);
            sql = sql.Replace("@PLACAREDE", Equipamento.placaRede);
            sql = sql.Replace("@HD", Equipamento.hd);
            sql = sql.Replace("@DRIVERDVD", Equipamento.driverDVD);
            sql = sql.Replace("@MONITOR", Equipamento.monitor);
            sql = sql.Replace("@FONTEALIMENTACAO", Equipamento.fonteAlimentacao);
            sql = sql.Replace("@IMPRESSORAS", Equipamento.impressoras);
            sql = sql.Replace("@IMPRESSORASIP", Equipamento.impressorasIP);
            sql = sql.Replace("@SCANNER", Equipamento.fabricante);
            sql = sql.Replace("@COMPRADATA", Equipamento.compraData.ToString());
            sql = sql.Replace("@COMPRAGARANTIA", Equipamento.compraGarantia.ToString());
            sql = sql.Replace("@NOTAFISCAL", Equipamento.notaFiscal);
            sql = sql.Replace("@EQUIPAMENTOESTADO", Equipamento.equipamentoEstado);
            sql = sql.Replace("@EQUIPAMENTOVALOR", Equipamento.equipamentoValor.ToString());
            sql = sql.Replace("@OBSERVACOES", Equipamento.observacaoes);
        }


        public void ExcluirPessoaEquipamento(int EquipamentoId)
        {
            // section -64--88-56-1-189bbc2c:155330fba3d:-8000:0000000000000B13 begin
            // section -64--88-56-1-189bbc2c:155330fba3d:-8000:0000000000000B13 end

        }

        public DataTable PesquisaPessoaEquipamento(int EquipamentoId)
        {
            return null;

        }


        public DataTable PesquisaPessoasEquipamentos(int pessoaId)
        {
            return null;
        }


        public DataTable PesquisaEquipamentoTipos()
        {
            return null;
        }

    }
}
