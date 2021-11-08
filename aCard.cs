﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;

namespace Project2
{
   
    public enum CardValue: int
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }

    public enum CardSuit
    {
        Spades = 1,
        Clubs = 2,
        Diamonds = 3,
        Hearts = 4,
    }


    /// <summary>
    /// a card contains value, face and picture? 
    /// </summary>
    public class aCard
    {
        /// <summary>
        /// card value
        /// </summary>
        /// this is an enum
        private CardValue cardValue;

        /// <summary>
        /// face 
        /// </summary>
        private CardSuit suit;


        /// <summary>
        /// the image
        /// </summary>
        private Image image;

        /// <summary>
        /// display card
        /// </summary>
        public PictureBox cardDisplay;

        public aCard(CardValue value, CardSuit suit, System.Drawing.Image image)
        {
            this.cardValue = value;
            this.suit = suit;
            this.image = image;
        }

        public Image getImage()
        {
            return this.image;
        }

        public int getValue()
        {
            if (this.cardValue == CardValue.Ace)
                return 1;
            else if (this.cardValue == CardValue.Two)
                return 2;
            else if (this.cardValue == CardValue.Three)
                return 3;
            else if (this.cardValue == CardValue.Four)
                return 4;
            else if (this.cardValue == CardValue.Five)
                return 5;
            else if (this.cardValue == CardValue.Six)
                return 6;
            else if (this.cardValue == CardValue.Seven)
                return 7;
            else if (this.cardValue == CardValue.Eight)
                return 8;
            else if (this.cardValue == CardValue.Nine)
                return 9;
            else if (this.cardValue == CardValue.Ten || this.cardValue == CardValue.Jack ||
                this.cardValue == CardValue.Queen || this.cardValue == CardValue.King)
                return 10;
            else
                return 0;
        }

    }
    
}
