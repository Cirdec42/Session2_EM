using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTélécommande
{
    public class Téléviseur
    {
        #region CONSTANTE

        //  Canal
        public const int DÉFAUT_CANAL = 10;
        public const int MIN_CANAL = 2;
        public const int MAX_CANAL = 125;
        //  Volume
        public const int DÉFAUT_VOLUME = 15;
        public const int MIN_VOLUME = 0;
        public const int MAX_VOLUME = 50;
        // ModeImage
        public const int NB_MODE_IMAGE = 3;

        #endregion

        #region CHAMPS & PROPRIÉTÉ

        private int m_canal;// Mémoriser la valeur reçu par Canal
        public int Canal//Reçois la valeur et permet leur lecture
        {
            get { return m_canal; }
            set { m_canal = value; }
        }

        private int m_indexModeImage;
        public int IndexModeImage
        {
            get { return m_indexModeImage; }
            set { m_indexModeImage = value; }
        }

        private int m_indexSource;
        public int IndexSource
        {
            get { return m_indexSource; }
            set {m_indexSource = value;}
        }

        private ModeImage[] m_tabModeImage = { new ModeImage("Sport", 88, 57,52, 0,10), new ModeImage("Jeu",100,72,48,-2,4), new ModeImage("Cinéma",77,44,40,2,1)};
        public ModeImage ModeImageCourant
        {
            get { return m_tabModeImage[m_indexModeImage]; }
        }

        private string[] m_tabSources = {"HDMI 1", "HDMI 2", "HDMI 3", "Netflix", "Prime", "Crave", "Youtbe", "TV"};
        public int NbSource
        {
            get { return m_tabSources.Length; }
        }
        public string Source
        {
            get { return m_tabSources[m_indexSource];}
        }

        private int m_volume;
        public int Volume
        {
            get { return m_volume; }
            set { m_volume = value; }
        }
        public bool Sourdine { get; set; }
 
        #endregion
        #region MÉTHODE

        public void AugmenterCanal()
        {
            if (m_canal == MAX_CANAL)
            {
                m_canal = MIN_CANAL;
                
            }
            else
            {
                m_canal++;
                IndexSource=7; // a modifier quand le tableau source sera fini
            }
            
        } //Augmente de 1 le Canal courant
        public void AugmenterVolume()
        {
            m_volume++;
            if (m_volume>MAX_VOLUME)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            if (Sourdine==true)
            {
                Sourdine = false;
            }
            
        } //Augmente de 1 le Volume Courant

        public void DiminuerCanal()
        {
            if (m_canal==MIN_CANAL)
            {
                m_canal = MAX_CANAL;
                IndexSource = 7;
            }
            else
            {
                m_canal--;
                IndexSource=7;
            }
            
        } //Diminue de 1 le Canal courant
        public void DiminuerVolume()
        {
            m_volume--;
            if (m_volume<MIN_VOLUME)
            {
                throw new ArgumentOutOfRangeException("value");
            }
        } //Diminue de 1 le Volume Courant

        public void ModeImageSuivant()
        {
            m_indexModeImage++;
            if (m_indexModeImage == m_tabModeImage.Length)
            {
                m_indexModeImage = 0;
            }
        }

        public Téléviseur()
        {
            m_canal = DÉFAUT_CANAL;
            m_volume = DÉFAUT_VOLUME;
            Sourdine = false;
            IndexSource = 0;
            IndexModeImage = 0;

        }
        public Téléviseur( int pCanal, int pVolume)
        {
            m_canal = pCanal;
            if (pCanal > MAX_CANAL || pCanal < MIN_CANAL)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            m_volume = pVolume;
            if (pVolume > MAX_VOLUME || pVolume < MIN_VOLUME)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            Sourdine = false;
            IndexSource = 0;
            IndexModeImage = 0;
        }
        public Téléviseur(int pCanal, int pVolume, int pIndexSource, int pIndexModeImage)
        {
            m_canal = pCanal;
            if (pCanal > MAX_CANAL || pCanal < MIN_CANAL)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            m_volume = pVolume;
            if (pVolume > MAX_VOLUME || pVolume < MIN_VOLUME)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            Sourdine = false;
            IndexSource = 0;
            IndexModeImage = 0;
            m_indexSource = pIndexSource;
            if (pIndexSource>m_tabSources.Length-1 || pIndexSource<0)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            m_indexModeImage = pIndexModeImage;
            if (pIndexModeImage == NB_MODE_IMAGE || pIndexModeImage < 0)
            {
                throw new ArgumentOutOfRangeException("value");
            }
        }

        #endregion
    }
}
