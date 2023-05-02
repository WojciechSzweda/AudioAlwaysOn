ManualResetEvent _quitEvent = new ManualResetEvent(false);
Console.CancelKeyPress += (sender, eArgs) => {
	_quitEvent.Set();
	eArgs.Cancel = true;
};

System.Media.SoundPlayer player = new System.Media.SoundPlayer(@".\Audio\Silence.wav");
player.PlayLooping();

_quitEvent.WaitOne();
