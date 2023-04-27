ManualResetEvent _quitEvent = new ManualResetEvent(false);
Console.CancelKeyPress += (sender, eArgs) => {
	_quitEvent.Set();
	eArgs.Cancel = true;
};

System.Media.SoundPlayer player = new System.Media.SoundPlayer(@".\Silence.wav");
player.PlayLooping();

_quitEvent.WaitOne();
