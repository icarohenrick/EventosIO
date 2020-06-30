﻿using Eventos.IO.TestesAutomatizados.Config;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit;

namespace Eventos.IO.TestesAutomatizados.CadastroOrganizador
{
    [Binding]
    public class CadastroDeOrganizadorSteps
    {
        public SeleniumHelper Browser;

        public CadastroDeOrganizadorSteps()
        {
            Browser = SeleniumHelper.Instance();
        }

        [Given(@"que o Organizador está no site, na página inicial")]
        public void DadoQueOOrganizadorEstaNoSiteNaPaginaInicial()
        {
            var url = Browser.NavegarParaUrl(ConfigurationHelper.SiteUrl);
            Assert.Equal(ConfigurationHelper.SiteUrl, url);
        }
        
        [Given(@"clica no link de registro")]
        public void DadoClicaNoLinkDeRegistro()
        {
            Browser.ClicarLinkPorTexto("Registre-se");
        }
        
        [Given(@"Preenche os campos com os valores")]
        public void DadoPreencheOsCamposComOsValores(Table table)
        {
            Browser.PreencherTextBoxPorId(table.Rows[0][0], table.Rows[0][1]);
            Browser.PreencherTextBoxPorId(table.Rows[1][0], table.Rows[1][1]);
            Browser.PreencherTextBoxPorId(table.Rows[2][0], table.Rows[2][1]);
            Browser.PreencherTextBoxPorId(table.Rows[3][0], table.Rows[3][1]);
            Browser.PreencherTextBoxPorId(table.Rows[4][0], table.Rows[4][1]);
        }
        
        [When(@"clicar no botão registrar")]
        public void QuandoClicarNoBotaoRegistrar()
        {
            Browser.ClicarBotaoPorId("Registrar");
            Thread.Sleep(5000);
        }
        
        [Then(@"Será registrado e redirecionado com sucesso")]
        public void EntaoSeraRegistradoERedirecionadoComSucesso()
        {
            var returnText = Browser.ObterTextoPorXPath("/html/body/app-root/app-menu-superior/nav/div/app-menu-login/ul/li[1]/a");
            Assert.Contains("olá patrizia.mastrodonato@apeoesp.br", returnText.ToLower());
            Browser.ObterScreenShot("EvidenciaCadastro");
        }
    }
}
