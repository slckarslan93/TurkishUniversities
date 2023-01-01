using System.ComponentModel.DataAnnotations;

namespace TurkishUniversity
{
    public enum University
    {
        [Display(Name = "ABDULLAH GÜL ÜNİVERSİTESİ")]
        ABDULLAHGÜLÜNİVERSİTESİ = 1,

        [Display(Name = "ACIBADEM MEHMET ALİ AYDINLAR ÜNİVERSİTESİ")]
        ACIBADEMMEHMETALİAYDINLARÜNİVERSİTESİ,

        [Display(Name = "ADANA ALPARSLAN TÜRKEŞ BİLİM VE TEKNOLOJİ ÜNİVERSİTESİ")]
        ADANAALPARSLANTÜRKEŞBİLİMVETEKNOLOJİÜNİVERSİTESİ,

        [Display(Name = "ADIYAMAN ÜNİVERSİTESİ")]
        ADIYAMANÜNİVERSİTESİ,

        [Display(Name = "AFYON KOCATEPE ÜNİVERSİTESİ")]
        AFYONKOCATEPEÜNİVERSİTESİ,

        [Display(Name = "AFYONKARAHİSAR SAĞLIK BİLİMLERİ ÜNİVERSİTESİ")]
        AFYONKARAHİSARSAĞLIKBİLİMLERİÜNİVERSİTESİ,

        [Display(Name = "AĞRI İBRAHİM ÇEÇEN ÜNİVERSİTESİ")]
        AĞRIİBRAHİMÇEÇENÜNİVERSİTESİ,

        [Display(Name = "AKDENİZ ÜNİVERSİTESİ")]
        AKDENİZÜNİVERSİTESİ,

        [Display(Name = "AKSARAY ÜNİVERSİTESİ")]
        AKSARAYÜNİVERSİTESİ,

        [Display(Name = "ALANYA ALAADDİN KEYKUBAT ÜNİVERSİTESİ")]
        ALANYAALAADDİNKEYKUBATÜNİVERSİTESİ,

        [Display(Name = "ALANYA HAMDULLAH EMİN PAŞA ÜNİVERSİTESİ")]
        ALANYAHAMDULLAHEMİNPAŞAÜNİVERSİTESİ,

        [Display(Name = "ALTINBAŞ ÜNİVERSİTESİ")]
        ALTINBAŞÜNİVERSİTESİ,

        [Display(Name = "AMASYA ÜNİVERSİTESİ")]
        AMASYAÜNİVERSİTESİ,

        [Display(Name = "ANADOLU ÜNİVERSİTESİ")]
        ANADOLUÜNİVERSİTESİ,

        [Display(Name = "ANKA TEKNOLOJİ ÜNİVERSİTESİ")]
        ANKATEKNOLOJİÜNİVERSİTESİ,

        [Display(Name = "ANKARA BİLİM ÜNİVERSİTESİ")]
        ANKARABİLİMÜNİVERSİTESİ,

        [Display(Name = "ANKARA HACI BAYRAM VELİ ÜNİVERSİTESİ")]
        ANKARAHACIBAYRAMVELİÜNİVERSİTESİ,

        [Display(Name = "ANKARA MEDİPOL ÜNİVERSİTESİ")]
        ANKARAMEDİPOLÜNİVERSİTESİ,

        [Display(Name = "ANKARA MÜZİK VE GÜZEL SANATLAR ÜNİVERSİTESİ")]
        ANKARAMÜZİKVEGÜZELSANATLARÜNİVERSİTESİ,

        [Display(Name = "ANKARA SOSYAL BİLİMLER ÜNİVERSİTESİ")]
        ANKARASOSYALBİLİMLERÜNİVERSİTESİ,

        [Display(Name = "ANKARA ÜNİVERSİTESİ")]
        ANKARAÜNİVERSİTESİ,

        [Display(Name = "ANKARA YILDIRIM BEYAZIT ÜNİVERSİTESİ")]
        ANKARAYILDIRIMBEYAZITÜNİVERSİTESİ,

        [Display(Name = "ANTALYA AKEV ÜNİVERSİTESİ")]
        ANTALYAAKEVÜNİVERSİTESİ,

        [Display(Name = "ANTALYA BİLİM ÜNİVERSİTESİ")]
        ANTALYABİLİMÜNİVERSİTESİ,

        [Display(Name = "ARDAHAN ÜNİVERSİTESİ")]
        ARDAHANÜNİVERSİTESİ,

        [Display(Name = "ARTVİN ÇORUH ÜNİVERSİTESİ")]
        ARTVİNÇORUHÜNİVERSİTESİ,

        [Display(Name = "ATAŞEHİR ADIGÜZEL MESLEK YÜKSEKOKULU")]
        ATAŞEHİRADIGÜZELMESLEKYÜKSEKOKULU,

        [Display(Name = "ATATÜRK ÜNİVERSİTESİ")]
        ATATÜRKÜNİVERSİTESİ,

        [Display(Name = "ATILIM ÜNİVERSİTESİ")]
        ATILIMÜNİVERSİTESİ,

        [Display(Name = "AVRASYA ÜNİVERSİTESİ")]
        AVRASYAÜNİVERSİTESİ,

        [Display(Name = "AYDIN ADNAN MENDERES ÜNİVERSİTESİ")]
        AYDINADNANMENDERESÜNİVERSİTESİ,

        [Display(Name = "BAHÇEŞEHİR ÜNİVERSİTESİ")]
        BAHÇEŞEHİRÜNİVERSİTESİ,

        [Display(Name = "BALIKESİR ÜNİVERSİTESİ")]
        BALIKESİRÜNİVERSİTESİ,

        [Display(Name = "BANDIRMA ONYEDİ EYLÜL ÜNİVERSİTESİ")]
        BANDIRMAONYEDİEYLÜLÜNİVERSİTESİ,

        [Display(Name = "BARTIN ÜNİVERSİTESİ")]
        BARTINÜNİVERSİTESİ,

        [Display(Name = "BAŞKENT ÜNİVERSİTESİ")]
        BAŞKENTÜNİVERSİTESİ,

        [Display(Name = "BATMAN ÜNİVERSİTESİ")]
        BATMANÜNİVERSİTESİ,

        [Display(Name = "BAYBURT ÜNİVERSİTESİ")]
        BAYBURTÜNİVERSİTESİ,

        [Display(Name = "BEYKENT ÜNİVERSİTESİ")]
        BEYKENTÜNİVERSİTESİ,

        [Display(Name = "BEYKOZ ÜNİVERSİTESİ")]
        BEYKOZÜNİVERSİTESİ,

        [Display(Name = "BEZM-İ ÂLEM VAKIF ÜNİVERSİTESİ")]
        BEZMİALEMVAKIFÜNİVERSİTESİ,

        [Display(Name = "BİLECİK ŞEYH EDEBALİ ÜNİVERSİTESİ")]
        BİLECİKŞEYHEDEBALİÜNİVERSİTESİ,

        [Display(Name = "BİNGÖL ÜNİVERSİTESİ")]
        BİNGÖLÜNİVERSİTESİ,

        [Display(Name = "BİRUNİ ÜNİVERSİTESİ")]
        BİRUNİÜNİVERSİTESİ,

        [Display(Name = "BİTLİS EREN ÜNİVERSİTESİ")]
        BİTLİSERENÜNİVERSİTESİ,

        [Display(Name = "BOĞAZİÇİ ÜNİVERSİTESİ")]
        BOĞAZİÇİÜNİVERSİTESİ,

        [Display(Name = "BOLU ABANT İZZET BAYSAL ÜNİVERSİTESİ")]
        BOLUABANTİZZETBAYSALÜNİVERSİTESİ,

        [Display(Name = "BURDUR MEHMET AKİF ERSOY ÜNİVERSİTESİ")]
        BURDURMEHMETAKİFERSOYÜNİVERSİTESİ,

        [Display(Name = "BURSA TEKNİK ÜNİVERSİTESİ")]
        BURSATEKNİKÜNİVERSİTESİ,

        [Display(Name = "BURSA ULUDAĞ ÜNİVERSİTESİ")]
        BURSAULUDAĞÜNİVERSİTESİ,

        [Display(Name = "ÇAĞ ÜNİVERSİTESİ")]
        ÇAĞÜNİVERSİTESİ,

        [Display(Name = "ÇANKAYA ÜNİVERSİTESİ")]
        ÇANKAYAÜNİVERSİTESİ,

        [Display(Name = "ÇANKIRI KARATEKİN ÜNİVERSİTESİ")]
        ÇANKIRIKARATEKİNÜNİVERSİTESİ,

        [Display(Name = "ÇUKUROVA ÜNİVERSİTESİ")]
        ÇUKUROVAÜNİVERSİTESİ,

        [Display(Name = "DEMİROĞLU BİLİM ÜNİVERSİTESİ")]
        DEMİROĞLUBİLİMÜNİVERSİTESİ,

        [Display(Name = "DİCLE ÜNİVERSİTESİ")]
        DİCLEÜNİVERSİTESİ,

        [Display(Name = "DOĞUŞ ÜNİVERSİTESİ")]
        DOĞUŞÜNİVERSİTESİ,

        [Display(Name = "DOKUZ EYLÜL ÜNİVERSİTESİ")]
        DOKUZEYLÜLÜNİVERSİTESİ,

        [Display(Name = "DÜZCE ÜNİVERSİTESİ")]
        DÜZCEÜNİVERSİTESİ,

        [Display(Name = "EGE ÜNİVERSİTESİ")]
        EGEÜNİVERSİTESİ,

        [Display(Name = "ERCİYES ÜNİVERSİTESİ")]
        ERCİYESÜNİVERSİTESİ,

        [Display(Name = "ERZİNCAN BİNALİ YILDIRIM ÜNİVERSİTESİ")]
        ERZİNCANBİNALİYILDIRIMÜNİVERSİTESİ,

        [Display(Name = "ERZURUM TEKNİK ÜNİVERSİTESİ")]
        ERZURUMTEKNİKÜNİVERSİTESİ,

        [Display(Name = "ESKİŞEHİR OSMANGAZİ ÜNİVERSİTESİ")]
        ESKİŞEHİROSMANGAZİÜNİVERSİTESİ,

        [Display(Name = "ESKİŞEHİR TEKNİK ÜNİVERSİTESİ")]
        ESKİŞEHİRTEKNİKÜNİVERSİTESİ,

        [Display(Name = "FATİH SULTAN MEHMET VAKIF ÜNİVERSİTESİ")]
        FATİHSULTANMEHMETVAKIFÜNİVERSİTESİ,

        [Display(Name = "FENERBAHÇE ÜNİVERSİTESİ")]
        FENERBAHÇEÜNİVERSİTESİ,

        [Display(Name = "FIRAT ÜNİVERSİTESİ")]
        FIRATÜNİVERSİTESİ,

        [Display(Name = "GALATASARAY ÜNİVERSİTESİ")]
        GALATASARAYÜNİVERSİTESİ,

        [Display(Name = "GAZİ ÜNİVERSİTESİ")]
        GAZİÜNİVERSİTESİ,

        [Display(Name = "GAZİANTEP İSLAM BİLİM VE TEKNOLOJİ ÜNİVERSİTESİ")]
        GAZİANTEPİSLAMBİLİMVETEKNOLOJİÜNİVERSİTESİ,

        [Display(Name = "GAZİANTEP ÜNİVERSİTESİ")]
        GAZİANTEPÜNİVERSİTESİ,

        [Display(Name = "GEBZE TEKNİK ÜNİVERSİTESİ")]
        GEBZETEKNİKÜNİVERSİTESİ,

        [Display(Name = "GİRESUN ÜNİVERSİTESİ")]
        GİRESUNÜNİVERSİTESİ,

        [Display(Name = "GÜMÜŞHANE ÜNİVERSİTESİ")]
        GÜMÜŞHANEÜNİVERSİTESİ,

        [Display(Name = "HACETTEPE ÜNİVERSİTESİ")]
        HACETTEPEÜNİVERSİTESİ,

        [Display(Name = "HAKKARİ ÜNİVERSİTESİ")]
        HAKKARİÜNİVERSİTESİ,

        [Display(Name = "HALİÇ ÜNİVERSİTESİ")]
        HALİÇÜNİVERSİTESİ,

        [Display(Name = "HARRAN ÜNİVERSİTESİ")]
        HARRANÜNİVERSİTESİ,

        [Display(Name = "HASAN KALYONCU ÜNİVERSİTESİ")]
        HASANKALYONCUÜNİVERSİTESİ,

        [Display(Name = "HATAY MUSTAFA KEMAL ÜNİVERSİTESİ")]
        HATAYMUSTAFAKEMALÜNİVERSİTESİ,

        [Display(Name = "HİTİT ÜNİVERSİTESİ")]
        HİTİTÜNİVERSİTESİ,

        [Display(Name = "IĞDIR ÜNİVERSİTESİ")]
        IĞDIRÜNİVERSİTESİ,

        [Display(Name = "ISPARTA UYGULAMALI BİLİMLER ÜNİVERSİTESİ")]
        ISPARTAUYGULAMALIBİLİMLERÜNİVERSİTESİ,

        [Display(Name = "IŞIK ÜNİVERSİTESİ")]
        IŞIKÜNİVERSİTESİ,

        [Display(Name = "İBN HALDUN ÜNİVERSİTESİ")]
        İBNHALDUNÜNİVERSİTESİ,

        [Display(Name = "İHSAN DOĞRAMACI BİLKENT ÜNİVERSİTESİ")]
        İHSANDOĞRAMACIBİLKENTÜNİVERSİTESİ,

        [Display(Name = "İNÖNÜ ÜNİVERSİTESİ")]
        İNÖNÜÜNİVERSİTESİ,

        [Display(Name = "İSKENDERUN TEKNİK ÜNİVERSİTESİ")]
        İSKENDERUNTEKNİKÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL AREL ÜNİVERSİTESİ")]
        İSTANBULARELÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL ATLAS ÜNİVERSİTESİ")]
        İSTANBULATLASÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL AYDIN ÜNİVERSİTESİ")]
        İSTANBULAYDINÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL BİLGİ ÜNİVERSİTESİ")]
        İSTANBULBİLGİÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL ESENYURT ÜNİVERSİTESİ")]
        İSTANBULESENYURTÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL GALATA ÜNİVERSİTESİ")]
        İSTANBULGALATAÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL GEDİK ÜNİVERSİTESİ")]
        İSTANBULGEDİKÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL GELİŞİM ÜNİVERSİTESİ")]
        İSTANBULGELİŞİMÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL KENT ÜNİVERSİTESİ")]
        İSTANBULKENTÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL KÜLTÜR ÜNİVERSİTESİ")]
        İSTANBULKÜLTÜRÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL MEDENİYET ÜNİVERSİTESİ")]
        İSTANBULMEDENİYETÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL MEDİPOL ÜNİVERSİTESİ")]
        İSTANBULMEDİPOLÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL OKAN ÜNİVERSİTESİ")]
        İSTANBULOKANÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL RUMELİ ÜNİVERSİTESİ")]
        İSTANBULRUMELİÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL SABAHATTİN ZAİM ÜNİVERSİTESİ")]
        İSTANBULSABAHATTİNZAİMÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL SAĞLIK VE SOSYAL BİLİMLER MESLEK YÜKSEKOKULU")]
        İSTANBULSAĞLIKVESOSYALBİLİMLERMESLEKYÜKSEKOKULU,

        [Display(Name = "İSTANBUL SAĞLIK VE TEKNOLOJİ ÜNİVERSİTESİ")]
        İSTANBULSAĞLIKVETEKNOLOJİÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL ŞİŞLİ MESLEK YÜKSEKOKULU")]
        İSTANBULŞİŞLİMESLEKYÜKSEKOKULU,

        [Display(Name = "İSTANBUL TEKNİK ÜNİVERSİTESİ")]
        İSTANBULTEKNİKÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL TİCARET ÜNİVERSİTESİ")]
        İSTANBULTİCARETÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL TOPKAPI ÜNİVERSİTESİ")]
        İSTANBULTOPKAPIÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL ÜNİVERSİTESİ")]
        İSTANBULÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL ÜNİVERSİTESİ-CERRAHPAŞA")]
        İSTANBULÜNİVERSİTESİCERRAHPAŞA,

        [Display(Name = "İSTANBUL YENİ YÜZYIL ÜNİVERSİTESİ")]
        İSTANBULYENİYÜZYILÜNİVERSİTESİ,

        [Display(Name = "İSTANBUL 29 MAYIS ÜNİVERSİTESİ")]
        İSTANBUL29MAYISÜNİVERSİTESİ,

        [Display(Name = "İSTİNYE ÜNİVERSİTESİ")]
        İSTİNYEÜNİVERSİTESİ,

        [Display(Name = "İZMİR BAKIRÇAY ÜNİVERSİTESİ")]
        İZMİRBAKIRÇAYÜNİVERSİTESİ,

        [Display(Name = "İZMİR DEMOKRASİ ÜNİVERSİTESİ")]
        İZMİRDEMOKRASİÜNİVERSİTESİ,

        [Display(Name = "İZMİR EKONOMİ ÜNİVERSİTESİ")]
        İZMİREKONOMİÜNİVERSİTESİ,

        [Display(Name = "İZMİR KATİP ÇELEBİ ÜNİVERSİTESİ")]
        İZMİRKATİPÇELEBİÜNİVERSİTESİ,

        [Display(Name = "İZMİR KAVRAM MESLEK YÜKSEKOKULU")]
        İZMİRKAVRAMMESLEKYÜKSEKOKULU,

        [Display(Name = "İZMİR TINAZTEPE ÜNİVERSİTESİ")]
        İZMİRTINAZTEPEÜNİVERSİTESİ,

        [Display(Name = "İZMİR YÜKSEK TEKNOLOJİ ENSTİTÜSÜ")]
        İZMİRYÜKSEKTEKNOLOJİENSTİTÜSÜ,

        [Display(Name = "KADİR HAS ÜNİVERSİTESİ")]
        KADİRHASÜNİVERSİTESİ,

        [Display(Name = "KAFKAS ÜNİVERSİTESİ")]
        KAFKASÜNİVERSİTESİ,

        [Display(Name = "KAHRAMANMARAŞ İSTİKLAL ÜNİVERSİTESİ")]
        KAHRAMANMARAŞİSTİKLALÜNİVERSİTESİ,

        [Display(Name = "KAHRAMANMARAŞ SÜTÇÜ İMAM ÜNİVERSİTESİ")]
        KAHRAMANMARAŞSÜTÇÜİMAMÜNİVERSİTESİ,

        [Display(Name = "KAPADOKYA ÜNİVERSİTESİ")]
        KAPADOKYAÜNİVERSİTESİ,

        [Display(Name = "KARABÜK ÜNİVERSİTESİ")]
        KARABÜKÜNİVERSİTESİ,

        [Display(Name = "KARADENİZ TEKNİK ÜNİVERSİTESİ")]
        KARADENİZTEKNİKÜNİVERSİTESİ,

        [Display(Name = "KARAMANOĞLU MEHMETBEY ÜNİVERSİTESİ")]
        KARAMANOĞLUMEHMETBEYÜNİVERSİTESİ,

        [Display(Name = "KASTAMONU ÜNİVERSİTESİ")]
        KASTAMONUÜNİVERSİTESİ,

        [Display(Name = "KAYSERİ ÜNİVERSİTESİ")]
        KAYSERİÜNİVERSİTESİ,

        [Display(Name = "KIRIKKALE ÜNİVERSİTESİ")]
        KIRIKKALEÜNİVERSİTESİ,

        [Display(Name = "KIRKLARELİ ÜNİVERSİTESİ")]
        KIRKLARELİÜNİVERSİTESİ,

        [Display(Name = "KIRŞEHİR AHİ EVRAN ÜNİVERSİTESİ")]
        KIRŞEHİRAHİEVRANÜNİVERSİTESİ,

        [Display(Name = "KİLİS 7 ARALIK ÜNİVERSİTESİ")]
        KİLİS7ARALIKÜNİVERSİTESİ,

        [Display(Name = "KOCAELİ SAĞLIK VE TEKNOLOJİ ÜNİVERSİTESİ")]
        KOCAELİSAĞLIKVETEKNOLOJİÜNİVERSİTESİ,

        [Display(Name = "KOCAELİ ÜNİVERSİTESİ")]
        KOCAELİÜNİVERSİTESİ,

        [Display(Name = "KOÇ ÜNİVERSİTESİ")]
        KOÇÜNİVERSİTESİ,

        [Display(Name = "KONYA GIDA VE TARIM ÜNİVERSİTESİ")]
        KONYAGIDAVETARIMÜNİVERSİTESİ,

        [Display(Name = "KONYA TEKNİK ÜNİVERSİTESİ")]
        KONYATEKNİKÜNİVERSİTESİ,

        [Display(Name = "KTO KARATAY ÜNİVERSİTESİ")]
        KTOKARATAYÜNİVERSİTESİ,

        [Display(Name = "KÜTAHYA DUMLUPINAR ÜNİVERSİTESİ")]
        KÜTAHYADUMLUPINARÜNİVERSİTESİ,

        [Display(Name = "KÜTAHYA SAĞLIK BİLİMLERİ ÜNİVERSİTESİ")]
        KÜTAHYASAĞLIKBİLİMLERİÜNİVERSİTESİ,

        [Display(Name = "LOKMAN HEKİM ÜNİVERSİTESİ")]
        LOKMANHEKİMÜNİVERSİTESİ,

        [Display(Name = "MALATYA TURGUT ÖZAL ÜNİVERSİTESİ")]
        MALATYATURGUTÖZALÜNİVERSİTESİ,

        [Display(Name = "MALTEPE ÜNİVERSİTESİ")]
        MALTEPEÜNİVERSİTESİ,

        [Display(Name = "MANİSA CELÂL BAYAR ÜNİVERSİTESİ")]
        MANİSACELÂLBAYARÜNİVERSİTESİ,

        [Display(Name = "MARDİN ARTUKLU ÜNİVERSİTESİ")]
        MARDİNARTUKLUÜNİVERSİTESİ,

        [Display(Name = "MARMARA ÜNİVERSİTESİ")]
        MARMARAÜNİVERSİTESİ,

        [Display(Name = "MEF ÜNİVERSİTESİ")]
        MEFÜNİVERSİTESİ,

        [Display(Name = "MERSİN ÜNİVERSİTESİ")]
        MERSİNÜNİVERSİTESİ,

        [Display(Name = "MİMAR SİNAN GÜZEL SANATLAR ÜNİVERSİTESİ")]
        MİMARSİNANGÜZELSANATLARÜNİVERSİTESİ,

        [Display(Name = "MUDANYA ÜNİVERSİTESİ")]
        MUDANYAÜNİVERSİTESİ,

        [Display(Name = "MUĞLA SITKI KOÇMAN ÜNİVERSİTESİ")]
        MUĞLASITKIKOÇMANÜNİVERSİTESİ,

        [Display(Name = "MUNZUR ÜNİVERSİTESİ")]
        MUNZURÜNİVERSİTESİ,

        [Display(Name = "MUŞ ALPARSLAN ÜNİVERSİTESİ")]
        MUŞALPARSLANÜNİVERSİTESİ,

        [Display(Name = "NECMETTİN ERBAKAN ÜNİVERSİTESİ")]
        NECMETTİNERBAKANÜNİVERSİTESİ,

        [Display(Name = "NEVŞEHİR HACI BEKTAŞ VELİ ÜNİVERSİTESİ")]
        NEVŞEHİRHACIBEKTAŞVELİÜNİVERSİTESİ,

        [Display(Name = "NİĞDE ÖMER HALİSDEMİR ÜNİVERSİTESİ")]
        NİĞDEÖMERHALİSDEMİRÜNİVERSİTESİ,

        [Display(Name = "NİŞANTAŞI ÜNİVERSİTESİ")]
        NİŞANTAŞIÜNİVERSİTESİ,

        [Display(Name = "NUH NACİ YAZGAN ÜNİVERSİTESİ")]
        NUHNACİYAZGANÜNİVERSİTESİ,

        [Display(Name = "ONDOKUZ MAYIS ÜNİVERSİTESİ")]
        ONDOKUZMAYISÜNİVERSİTESİ,

        [Display(Name = "ORDU ÜNİVERSİTESİ")]
        ORDUÜNİVERSİTESİ,

        [Display(Name = "ORTA DOĞU TEKNİK ÜNİVERSİTESİ")]
        ORTADOĞUTEKNİKÜNİVERSİTESİ,

        [Display(Name = "OSMANİYE KORKUT ATA ÜNİVERSİTESİ")]
        OSMANİYEKORKUTATAÜNİVERSİTESİ,

        [Display(Name = "OSTİM TEKNİK ÜNİVERSİTESİ")]
        OSTİMTEKNİKÜNİVERSİTESİ,

        [Display(Name = "ÖZYEĞİN ÜNİVERSİTESİ")]
        ÖZYEĞİNÜNİVERSİTESİ,

        [Display(Name = "PAMUKKALE ÜNİVERSİTESİ")]
        PAMUKKALEÜNİVERSİTESİ,

        [Display(Name = "PİRİ REİS ÜNİVERSİTESİ")]
        PİRİREİSÜNİVERSİTESİ,

        [Display(Name = "RECEP TAYYİP ERDOĞAN ÜNİVERSİTESİ")]
        RECEPTAYYİPERDOĞANÜNİVERSİTESİ,

        [Display(Name = "SABANCI ÜNİVERSİTESİ")]
        SABANCIÜNİVERSİTESİ,

        [Display(Name = "SAĞLIK BİLİMLERİ ÜNİVERSİTESİ")]
        SAĞLIKBİLİMLERİÜNİVERSİTESİ,

        [Display(Name = "SAKARYA UYGULAMALI BİLİMLER ÜNİVERSİTESİ")]
        SAKARYAUYGULAMALIBİLİMLERÜNİVERSİTESİ,

        [Display(Name = "SAKARYA ÜNİVERSİTESİ")]
        SAKARYAÜNİVERSİTESİ,

        [Display(Name = "SAMSUN ÜNİVERSİTESİ")]
        SAMSUNÜNİVERSİTESİ,

        [Display(Name = "SANKO ÜNİVERSİTESİ")]
        SANKOÜNİVERSİTESİ,

        [Display(Name = "SELÇUK ÜNİVERSİTESİ")]
        SELÇUKÜNİVERSİTESİ,

        [Display(Name = "SİİRT ÜNİVERSİTESİ")]
        SİİRTÜNİVERSİTESİ,

        [Display(Name = "SİNOP ÜNİVERSİTESİ")]
        SİNOPÜNİVERSİTESİ,

        [Display(Name = "SİVAS BİLİM VE TEKNOLOJİ ÜNİVERSİTESİ")]
        SİVASBİLİMVETEKNOLOJİÜNİVERSİTESİ,

        [Display(Name = "SİVAS CUMHURİYET ÜNİVERSİTESİ")]
        SİVASCUMHURİYETÜNİVERSİTESİ,

        [Display(Name = "SÜLEYMAN DEMİREL ÜNİVERSİTESİ")]
        SÜLEYMANDEMİRELÜNİVERSİTESİ,

        [Display(Name = "ŞIRNAK ÜNİVERSİTESİ")]
        ŞIRNAKÜNİVERSİTESİ,

        [Display(Name = "TARSUS ÜNİVERSİTESİ")]
        TARSUSÜNİVERSİTESİ,

        [Display(Name = "TED ÜNİVERSİTESİ")]
        TEDÜNİVERSİTESİ,

        [Display(Name = "TEKİRDAĞ NAMIK KEMAL ÜNİVERSİTESİ")]
        TEKİRDAĞNAMIKKEMALÜNİVERSİTESİ,

        [Display(Name = "TOBB EKONOMİ VE TEKNOLOJİ ÜNİVERSİTESİ")]
        TOBBEKONOMİVETEKNOLOJİÜNİVERSİTESİ,

        [Display(Name = "TOKAT GAZİOSMANPAŞA ÜNİVERSİTESİ")]
        TOKATGAZİOSMANPAŞAÜNİVERSİTESİ,

        [Display(Name = "TOROS ÜNİVERSİTESİ")]
        TOROSÜNİVERSİTESİ,

        [Display(Name = "TRABZON ÜNİVERSİTESİ")]
        TRABZONÜNİVERSİTESİ,

        [Display(Name = "TRAKYA ÜNİVERSİTESİ")]
        TRAKYAÜNİVERSİTESİ,

        [Display(Name = "TÜRK HAVA KURUMU ÜNİVERSİTESİ")]
        TÜRKHAVAKURUMUÜNİVERSİTESİ,

        [Display(Name = "TÜRK-ALMAN ÜNİVERSİTESİ")]
        TÜRKALMANÜNİVERSİTESİ,

        [Display(Name = "TÜRKİYE ULUSLARARASI İSLAM, BİLİM VE TEKNOLOJİ ÜNİVERSİTESİ")]
        TÜRKİYEULUSLARARASIİSLAMBİLİMVETEKNOLOJİÜNİVERSİTESİ,

        [Display(Name = "TÜRK-JAPON BİLİM VE TEKNOLOJİ ÜNİVERSİTESİ")]
        TÜRKJAPONBİLİMVETEKNOLOJİÜNİVERSİTESİ,

        [Display(Name = "UFUK ÜNİVERSİTESİ")]
        UFUKÜNİVERSİTESİ,

        [Display(Name = "UŞAK ÜNİVERSİTESİ")]
        UŞAKÜNİVERSİTESİ,

        [Display(Name = "ÜSKÜDAR ÜNİVERSİTESİ")]
        ÜSKÜDARÜNİVERSİTESİ,

        [Display(Name = "VAN YÜZÜNCÜ YIL ÜNİVERSİTESİ")]
        VANYÜZÜNCÜYILÜNİVERSİTESİ,

        [Display(Name = "YALOVA ÜNİVERSİTESİ")]
        YALOVAÜNİVERSİTESİ,

        [Display(Name = "YAŞAR ÜNİVERSİTESİ")]
        YAŞARÜNİVERSİTESİ,

        [Display(Name = "YEDİTEPE ÜNİVERSİTESİ")]
        YEDİTEPEÜNİVERSİTESİ,

        [Display(Name = "YILDIZ TEKNİK ÜNİVERSİTESİ")]
        YILDIZTEKNİKÜNİVERSİTESİ,

        [Display(Name = "YOZGAT BOZOK ÜNİVERSİTESİ")]
        YOZGATBOZOKÜNİVERSİTESİ,

        [Display(Name = "YÜKSEK İHTİSAS ÜNİVERSİTESİ")]
        YÜKSEKİHTİSASÜNİVERSİTESİ,

        [Display(Name = "ZONGULDAK BÜLENT ECEVİT ÜNİVERSİTESİ")]
        ZONGULDAKBÜLENTECEVİTÜNİVERSİTESİ,

        [Display(Name = "Diğer")]
        DIGER
    }
}