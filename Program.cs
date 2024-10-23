using abstraction;

 employees Employe1 = new projectManager { Name = "Hasan", Surname = "Çıldırmış", Department = "Project Manager" };

Employe1.Info();
Employe1.Mission();

employees Employe2 = new softwareDeveloper { Name = "Emily", Surname = "Cooper", Department = "Software Developer" };

Employe2.Info();
Employe2.Mission();

employees Employe3 = new salesRepresentative { Name = "Mindy", Surname = "Chen", Department = "Sales Represantative" };

Employe3.Info();
Employe3.Mission();