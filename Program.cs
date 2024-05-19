

Console.WriteLine("こんにちは！　東武鉄道ファンよ。");
Console.WriteLine("ここでは東武線の放送を再現をしているよ！");
Console.WriteLine("早速東武の放送を設定していこう！");
Console.WriteLine("※注意事項");
Console.WriteLine("放送を終了するときはCtrl+Cを押して終了してください");
                 string? station = "";
                 string? lineName = "";
                 string? direction = "";
                 string? carnumber = "";
                 string? homenumber = "";
                 string? traintime = "";
                 string? traintype = "";

Console.WriteLine("[ATOS] 駅名を入力してください");
  station = Console.ReadLine();
Console.WriteLine("[ATOS] 路線名を入力してください");
  lineName = Console.ReadLine();
Console.WriteLine("[ATOS] 上り方面か下り方面を入力してください");
  direction = Console.ReadLine();
Console.WriteLine("[ATOS] 列車の種別を入力してください");
  traintype = Console.ReadLine();
Console.WriteLine("[ATOS] 列車の編成数を入力してください");
  carnumber = Console.ReadLine();
Console.WriteLine("[ATOS] 発車するホーム番号を入力してください");
  homenumber = Console.ReadLine();
Console.WriteLine("[ATOS] 列車の発車時刻を入力してください");
  traintime = Console.ReadLine();