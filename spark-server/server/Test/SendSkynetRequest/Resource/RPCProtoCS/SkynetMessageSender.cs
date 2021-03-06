// Generated by sprotodump. DO NOT EDIT!
// source: E:\SparkServer\spark-server\server\Test\SendSkynetRequest\Resource\RPCProtoSchema\\SkynetMessageSender.sproto

using System;
using Sproto;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace NetSprotoType { 
	public class RPCSendParam : SprotoTypeBase {
		private static int max_field_count = 2;
		
		
		private string _method; // tag 0
		public string method {
			get { return _method; }
			set { base.has_field.set_field (0, true); _method = value; }
		}
		public bool HasMethod {
			get { return base.has_field.has_field (0); }
		}

		private string _param; // tag 1
		public string param {
			get { return _param; }
			set { base.has_field.set_field (1, true); _param = value; }
		}
		public bool HasParam {
			get { return base.has_field.has_field (1); }
		}

		public RPCSendParam () : base(max_field_count) {}

		public RPCSendParam (byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}

		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				case 0:
					this.method = base.deserialize.read_string ();
					break;
				case 1:
					this.param = base.deserialize.read_string ();
					break;
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}

		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			if (base.has_field.has_field (0)) {
				base.serialize.write_string (this.method, 0);
			}

			if (base.has_field.has_field (1)) {
				base.serialize.write_string (this.param, 1);
			}

			return base.serialize.close ();
		}
	}


	public class SkynetMessageSender_OnProcessRequest : SprotoTypeBase {
		private static int max_field_count = 2;
		
		
		private Int64 _request_count; // tag 0
		public Int64 request_count {
			get { return _request_count; }
			set { base.has_field.set_field (0, true); _request_count = value; }
		}
		public bool HasRequest_count {
			get { return base.has_field.has_field (0); }
		}

		private string _request_text; // tag 1
		public string request_text {
			get { return _request_text; }
			set { base.has_field.set_field (1, true); _request_text = value; }
		}
		public bool HasRequest_text {
			get { return base.has_field.has_field (1); }
		}

		public SkynetMessageSender_OnProcessRequest () : base(max_field_count) {}

		public SkynetMessageSender_OnProcessRequest (byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}

		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				case 0:
					this.request_count = base.deserialize.read_integer ();
					break;
				case 1:
					this.request_text = base.deserialize.read_string ();
					break;
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}

		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			if (base.has_field.has_field (0)) {
				base.serialize.write_integer (this.request_count, 0);
			}

			if (base.has_field.has_field (1)) {
				base.serialize.write_string (this.request_text, 1);
			}

			return base.serialize.close ();
		}
	}


	public class SkynetMessageSender_OnProcessRequestResponse : SprotoTypeBase {
		private static int max_field_count = 2;
		
		
		private Int64 _request_count; // tag 0
		public Int64 request_count {
			get { return _request_count; }
			set { base.has_field.set_field (0, true); _request_count = value; }
		}
		public bool HasRequest_count {
			get { return base.has_field.has_field (0); }
		}

		private string _request_text; // tag 1
		public string request_text {
			get { return _request_text; }
			set { base.has_field.set_field (1, true); _request_text = value; }
		}
		public bool HasRequest_text {
			get { return base.has_field.has_field (1); }
		}

		public SkynetMessageSender_OnProcessRequestResponse () : base(max_field_count) {}

		public SkynetMessageSender_OnProcessRequestResponse (byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}

		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				case 0:
					this.request_count = base.deserialize.read_integer ();
					break;
				case 1:
					this.request_text = base.deserialize.read_string ();
					break;
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}

		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			if (base.has_field.has_field (0)) {
				base.serialize.write_integer (this.request_count, 0);
			}

			if (base.has_field.has_field (1)) {
				base.serialize.write_string (this.request_text, 1);
			}

			return base.serialize.close ();
		}
	}


}

