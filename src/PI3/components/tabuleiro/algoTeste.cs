private void attachClickEventHandler() {
   for (int i = 0; i < 6; i++) {
      for (int k = 0; k < 6; k++) {
         Panel p = new Panel();
         p.BackgroundImage = Properties.Resourses.peao
         p.BackgroundImageLayout = ImageLayout.Stretch
         p.Top  = 20 + 120*((i%2 == 0 ? 0 : 5) + (k*(i%2 == 0 ? 1 :  -1)))
         p.Left = 20 + 120*i
         p.Width = 100
         p.Height = 100

         p.Tag = "i:" + (6*i + (k+i)) + 
                 ",x1:" + (p.Left + 25) + 
                 ",x2:" + (p.Left + 50) + 
                 ",x3:" + (p.Left + 75) +
                 ",y1:" + (p.Top - 25) +
                 ",y2:" + (p.Top - 75) +
                 ",y3:" + (p.Top - 75) 

         p.Click += new EventHandler(tileClick());

         // Precisa ver onde vai adicionar
         //
         // flowLayoutPanel1.Controls.Add(p);
         //
         // ou
         //
         // this.Controls.Add(p);
      }
   }
}

void tileClick(object sender, EventArgs e) {
   // do click stuff
   Console.WriteLine(sender.Tag.ToString())
}