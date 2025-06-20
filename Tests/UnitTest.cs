﻿using Itau.Trading.Domain;

namespace Itau.Tests;

public class UnitTest
{
    [Fact]
    public void Test()
    {
        var assets = new List<Asset>()
        {
            new("ALOS3", "ALLOS"),
            new("ABEV3", "AMBEV S/A"),
            new("ASAI3", "ASSAI"),
            new("AURE3", "AUREN"),
            new("AZZA3", "AZZAS 2154"),
            new("B3SA3", "B3"),
            new("BBSE3", "BBSEGURIDADE"),
            new("BBDC3", "BRADESCO"),
            new("BBDC4", "BRADESCO"),
            new("BRAP4", "BRADESPAR"),
            new("BBAS3", "BRASIL"),
            new("BRKM5", "BRASKEM"),
            new("BRAV3", "BRAVA"),
            new("BRFS3", "BRF SA"),
            new("BPAC11", "BTGP BANCO"),
            new("CXSE3", "CAIXA SEGURI"),
            new("CMIG4", "CEMIG"),
            new("COGN3", "COGNA ON"),
            new("CPLE6", "COPEL"),
            new("CSAN3", "COSAN"),
            new("CPFE3", "CPFL ENERGIA"),
            new("CMIN3", "CSNMINERACAO"),
            new("CVCB3", "CVC BRASIL"),
            new("CYRE3", "CYRELA REALT"),
            new("DIRR3", "DIRECIONAL"),
            new("ELET3", "ELETROBRAS"),
            new("ELET6", "ELETROBRAS"),
            new("EMBR3", "EMBRAER"),
            new("ENGI11", "ENERGISA"),
            new("ENEV3", "ENEVA"),
            new("EGIE3", "ENGIE BRASIL"),
            new("EQTL3", "EQUATORIAL"),
            new("FLRY3", "FLEURY"),
            new("GGBR4", "GERDAU"),
            new("GOAU4", "GERDAU MET"),
            new("NTCO3", "GRUPO NATURA"),
            new("HAPV3", "HAPVIDA"),
            new("HYPE3", "HYPERA"),
            new("IGTI11", "IGUATEMI S.A"),
            new("IRBR3", "IRBBRASIL RE"),
            new("ISAE4", "ISA ENERGIA"),
            new("ITSA4", "ITAUSA"),
            new("ITUB4", "ITAUUNIBANCO"),
            new("KLBN11", "KLABIN S/A"),
            new("RENT3", "LOCALIZA"),
            new("LREN3", "LOJAS RENNER"),
            new("MGLU3", "MAGAZ LUIZA"),
            new("POMO4", "MARCOPOLO"),
            new("MRFG3", "MARFRIG"),
            new("BEEF3", "MINERVA"),
            new("MOTV3", "MOTIVA SA"),
            new("MRVE3", "MRV"),
            new("MULT3", "MULTIPLAN"),
            new("PCAR3", "P.ACUCAR-CBD"),
            new("PETR3", "PETROBRAS"),
            new("PETR4", "PETROBRAS"),
            new("RECV3", "PETRORECSA"),
            new("PRIO3", "PETRORIO"),
            new("PETZ3", "PETZ"),
            new("PSSA3", "PORTO SEGURO"),
            new("RADL3", "RAIADROGASIL"),
            new("RAIZ4", "RAIZEN"),
            new("RDOR3", "REDE D OR"),
            new("RAIL3", "RUMO S.A."),
            new("SBSP3", "SABESP"),
            new("SANB11", "SANTANDER BR"),
            new("STBP3", "SANTOS BRP"),
            new("SMTO3", "SAO MARTINHO"),
            new("CSNA3", "SID NACIONAL"),
            new("SLCE3", "SLC AGRICOLA"),
            new("SMFT3", "SMART FIT"),
            new("SUZB3", "SUZANO S.A."),
            new("TAEE11", "TAESA"),
            new("VIVT3", "TELEF BRASIL"),
            new("TIMS3", "TIM"),
            new("TOTS3", "TOTVS"),
            new("UGPA3", "ULTRAPAR"),
            new("USIM5", "USIMINAS"),
            new("VALE3", "VALE"),
            new("VAMO3", "VAMOS"),
            new("VBBR3", "VIBRA"),
            new("VIVA3", "VIVARA S.A."),
            new("WEGE3", "WEG"),
            new("YDUQ3", "YDUQS PART"),
        };


        assets.Count.ShouldBe(84);
    }
}
