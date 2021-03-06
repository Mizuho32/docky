
// This file has been generated by the GUI designer. Do not modify.
namespace Docky.Widgets
{
	public partial class AbstractLoginWidget
	{
		private global::Gtk.VBox wrapper_vbox;
		private global::Gtk.VBox vbox2;
		private global::Gtk.VBox account_vbox;
		private global::Gtk.Table login_tbl;
		private global::Docky.Widgets.SearchEntry password_entry;
		private global::Gtk.Label password_lbl;
		private global::Docky.Widgets.SearchEntry username_entry;
		private global::Gtk.Label username_lbl;
		private global::Gtk.Label validate_lbl;
		private global::Gtk.HButtonBox hbuttonbox1;
		private global::Gtk.Button validate_btn;
		private global::Gtk.VBox middle_box;
		private global::Gtk.VBox new_account_vbox;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.Label new_account_lbl;
		private global::Gtk.HButtonBox new_account_button_box;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Docky.Widgets.AbstractLoginWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Docky.Widgets.AbstractLoginWidget";
			// Container child Docky.Widgets.AbstractLoginWidget.Gtk.Container+ContainerChild
			this.wrapper_vbox = new global::Gtk.VBox ();
			this.wrapper_vbox.Name = "wrapper_vbox";
			this.wrapper_vbox.Spacing = 6;
			this.wrapper_vbox.BorderWidth = ((uint)(10));
			// Container child wrapper_vbox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.account_vbox = new global::Gtk.VBox ();
			this.account_vbox.Name = "account_vbox";
			this.account_vbox.Spacing = 6;
			// Container child account_vbox.Gtk.Box+BoxChild
			this.login_tbl = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.login_tbl.Name = "login_tbl";
			this.login_tbl.RowSpacing = ((uint)(6));
			this.login_tbl.ColumnSpacing = ((uint)(6));
			// Container child login_tbl.Gtk.Table+TableChild
			this.password_entry = new global::Docky.Widgets.SearchEntry ();
			this.password_entry.Name = "password_entry";
			this.password_entry.EmptyMessage = "Password";
			this.password_entry.Ready = true;
			this.password_entry.HasFocus = false;
			this.login_tbl.Add (this.password_entry);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.login_tbl [this.password_entry]));
			w1.TopAttach = ((uint)(1));
			w1.BottomAttach = ((uint)(2));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			// Container child login_tbl.Gtk.Table+TableChild
			this.password_lbl = new global::Gtk.Label ();
			this.password_lbl.Name = "password_lbl";
			this.password_lbl.Xalign = 1F;
			this.password_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Password");
			this.login_tbl.Add (this.password_lbl);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.login_tbl [this.password_lbl]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child login_tbl.Gtk.Table+TableChild
			this.username_entry = new global::Docky.Widgets.SearchEntry ();
			this.username_entry.Name = "username_entry";
			this.username_entry.EmptyMessage = "Username";
			this.username_entry.Ready = true;
			this.username_entry.HasFocus = false;
			this.login_tbl.Add (this.username_entry);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.login_tbl [this.username_entry]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			// Container child login_tbl.Gtk.Table+TableChild
			this.username_lbl = new global::Gtk.Label ();
			this.username_lbl.Name = "username_lbl";
			this.username_lbl.Xalign = 1F;
			this.username_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Username");
			this.login_tbl.Add (this.username_lbl);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.login_tbl [this.username_lbl]));
			w4.XOptions = ((global::Gtk.AttachOptions)(0));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			this.account_vbox.Add (this.login_tbl);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.account_vbox [this.login_tbl]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child account_vbox.Gtk.Box+BoxChild
			this.validate_lbl = new global::Gtk.Label ();
			this.validate_lbl.Name = "validate_lbl";
			this.validate_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("<i>Verify and save account information</i>");
			this.validate_lbl.UseMarkup = true;
			this.account_vbox.Add (this.validate_lbl);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.account_vbox [this.validate_lbl]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child account_vbox.Gtk.Box+BoxChild
			this.hbuttonbox1 = new global::Gtk.HButtonBox ();
			this.hbuttonbox1.Name = "hbuttonbox1";
			this.hbuttonbox1.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.validate_btn = new global::Gtk.Button ();
			this.validate_btn.CanFocus = true;
			this.validate_btn.Name = "validate_btn";
			this.validate_btn.UseStock = true;
			this.validate_btn.UseUnderline = true;
			this.validate_btn.Label = "gtk-apply";
			this.hbuttonbox1.Add (this.validate_btn);
			global::Gtk.ButtonBox.ButtonBoxChild w7 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.validate_btn]));
			w7.Expand = false;
			w7.Fill = false;
			this.account_vbox.Add (this.hbuttonbox1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.account_vbox [this.hbuttonbox1]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			this.vbox2.Add (this.account_vbox);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.account_vbox]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.middle_box = new global::Gtk.VBox ();
			this.middle_box.Name = "middle_box";
			this.middle_box.Spacing = 6;
			this.vbox2.Add (this.middle_box);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.middle_box]));
			w10.Position = 1;
			this.wrapper_vbox.Add (this.vbox2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.wrapper_vbox [this.vbox2]));
			w11.Position = 1;
			// Container child wrapper_vbox.Gtk.Box+BoxChild
			this.new_account_vbox = new global::Gtk.VBox ();
			this.new_account_vbox.Name = "new_account_vbox";
			this.new_account_vbox.Spacing = 6;
			// Container child new_account_vbox.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.new_account_vbox.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.new_account_vbox [this.hseparator1]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child new_account_vbox.Gtk.Box+BoxChild
			this.new_account_lbl = new global::Gtk.Label ();
			this.new_account_lbl.Name = "new_account_lbl";
			this.new_account_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Don't have an account?");
			this.new_account_vbox.Add (this.new_account_lbl);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.new_account_vbox [this.new_account_lbl]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child new_account_vbox.Gtk.Box+BoxChild
			this.new_account_button_box = new global::Gtk.HButtonBox ();
			this.new_account_button_box.Name = "new_account_button_box";
			this.new_account_button_box.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(1));
			this.new_account_vbox.Add (this.new_account_button_box);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.new_account_vbox [this.new_account_button_box]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			this.wrapper_vbox.Add (this.new_account_vbox);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.wrapper_vbox [this.new_account_vbox]));
			w15.Position = 2;
			w15.Expand = false;
			w15.Fill = false;
			this.Add (this.wrapper_vbox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.validate_btn.Clicked += new global::System.EventHandler (this.OnValidateBtnClicked);
		}
	}
}
