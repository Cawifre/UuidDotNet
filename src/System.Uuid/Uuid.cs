namespace System.Uuid
{
	public struct Uuid
	{
		private int _a; // time_low
		private short _b; // time_mid
		private short _c; // time_hi_and_version
		private byte _d; // clk_seq_hi_res
		private byte _e; // clk_seq_low
		private byte _f; // node 0
		private byte _g; // node 1
		private byte _h; // node 2
		private byte _i; // ndoe 3
		private byte _j; // node 4
		private byte _k; // node 5

		public Uuid ( Guid guid )
			: this( guid.ToByteArray() ) { }

		public Uuid ( byte[] bytes )
		{
			// time_low
			_a = bytes[3] << 24 | bytes[2] << 16 | bytes[1] << 8 | bytes[0];

			// time_mid
			_b = (short)( bytes[5] << 8 | bytes[4] );

			// time_hi_and_version
			_c = (short)( bytes[7] << 8 | bytes[6] );

			// clk_seq_hi_res
			_d = bytes[8];

			// clk_seq_low
			_e = bytes[9];

			// node
			_f = bytes[10];
			_g = bytes[11];
			_h = bytes[12];
			_i = bytes[13];
			_j = bytes[14];
			_k = bytes[15];
		}
	}
}
