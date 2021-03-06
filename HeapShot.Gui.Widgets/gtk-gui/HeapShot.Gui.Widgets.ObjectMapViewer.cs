
// This file has been generated by the GUI designer. Do not modify.
namespace HeapShot.Gui.Widgets
{
	public partial class ObjectMapViewer
	{
		private global::Gtk.HBox hbox3;
		private global::Gtk.ScrolledWindow scrolledwindow2;
		private global::Gtk.TreeView fileList;
		private global::Gtk.Notebook notebook;
		private global::Gtk.Table table1;
		private global::Gtk.Label label3;
		private global::Gtk.Label label4;
		private global::Gtk.Label label5;
		private global::Gtk.Label labelCount;
		private global::Gtk.Label labelMemory;
		private global::Gtk.Label labelName;
		private global::Gtk.Label label9;
		private global::HeapShot.Gui.Widgets.ReferenceTreeViewer allObjectsTree;
		private global::Gtk.Label label2;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget HeapShot.Gui.Widgets.ObjectMapViewer
			global::Stetic.BinContainer.Attach (this);
			this.Events = ((global::Gdk.EventMask)(256));
			this.Name = "HeapShot.Gui.Widgets.ObjectMapViewer";
			// Container child HeapShot.Gui.Widgets.ObjectMapViewer.Gtk.Container+ContainerChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.scrolledwindow2 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow2.CanFocus = true;
			this.scrolledwindow2.Name = "scrolledwindow2";
			this.scrolledwindow2.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow2.Gtk.Container+ContainerChild
			this.fileList = new global::Gtk.TreeView ();
			this.fileList.CanFocus = true;
			this.fileList.Name = "fileList";
			this.fileList.HeadersVisible = false;
			this.scrolledwindow2.Add (this.fileList);
			this.hbox3.Add (this.scrolledwindow2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.scrolledwindow2]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.notebook = new global::Gtk.Notebook ();
			this.notebook.CanFocus = true;
			this.notebook.Name = "notebook";
			this.notebook.CurrentPage = 0;
			this.notebook.Scrollable = true;
			// Container child notebook.Gtk.Notebook+NotebookChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(12));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Name:");
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Object count:");
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Total memory:");
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelCount = new global::Gtk.Label ();
			this.labelCount.Name = "labelCount";
			this.labelCount.Xalign = 0F;
			this.table1.Add (this.labelCount);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelCount]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelMemory = new global::Gtk.Label ();
			this.labelMemory.Name = "labelMemory";
			this.labelMemory.Xalign = 0F;
			this.table1.Add (this.labelMemory);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelMemory]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelName = new global::Gtk.Label ();
			this.labelName.Name = "labelName";
			this.labelName.Xalign = 0F;
			this.table1.Add (this.labelName);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelName]));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			this.notebook.Add (this.table1);
			// Notebook tab
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.LabelProp = "Summary";
			this.notebook.SetTabLabel (this.table1, this.label9);
			this.label9.ShowAll ();
			// Container child notebook.Gtk.Notebook+NotebookChild
			this.allObjectsTree = new global::HeapShot.Gui.Widgets.ReferenceTreeViewer ();
			this.allObjectsTree.Events = ((global::Gdk.EventMask)(256));
			this.allObjectsTree.Name = "allObjectsTree";
			this.allObjectsTree.InverseReferences = false;
			this.notebook.Add (this.allObjectsTree);
			global::Gtk.Notebook.NotebookChild w10 = ((global::Gtk.Notebook.NotebookChild)(this.notebook [this.allObjectsTree]));
			w10.Position = 1;
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = "All objects";
			this.notebook.SetTabLabel (this.allObjectsTree, this.label2);
			this.label2.ShowAll ();
			this.hbox3.Add (this.notebook);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.notebook]));
			w11.Position = 1;
			this.Add (this.hbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
		}
	}
}
