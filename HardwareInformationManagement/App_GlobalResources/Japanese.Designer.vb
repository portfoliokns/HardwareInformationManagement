﻿'------------------------------------------------------------------------------
' <auto-generated>
'     このコードはツールによって生成されました。
'     ランタイム バージョン:4.0.30319.42000
'
'     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
'     コードが再生成されるときに損失したりします。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'このクラスは StronglyTypedResourceBuilder クラスが ResGen
    'または Visual Studio のようなツールを使用して自動生成されました。
    'メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    'ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    '''<summary>
    '''  ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Public Class Japanese
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("HardwareInformationManagement.Japanese", GetType(Japanese).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        '''  現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  戻る に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Public Shared ReadOnly Property back() As String
            Get
                Return ResourceManager.GetString("back", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  削除 に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Public Shared ReadOnly Property delete() As String
            Get
                Return ResourceManager.GetString("delete", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  完全に削除 に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Public Shared ReadOnly Property delete_complete() As String
            Get
                Return ResourceManager.GetString("delete_complete", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  詳細 に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Public Shared ReadOnly Property detail() As String
            Get
                Return ResourceManager.GetString("detail", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  編集 に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Public Shared ReadOnly Property edit() As String
            Get
                Return ResourceManager.GetString("edit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  コメント に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Public Shared ReadOnly Property hard_comment() As String
            Get
                Return ResourceManager.GetString("hard_comment", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  管理機器一覧 に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Public Shared ReadOnly Property hard_index() As String
            Get
                Return ResourceManager.GetString("hard_index", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  機器名 に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Public Shared ReadOnly Property hard_name() As String
            Get
                Return ResourceManager.GetString("hard_name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  新規追加 に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Public Shared ReadOnly Property new_create() As String
            Get
                Return ResourceManager.GetString("new_create", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  設置場所 に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Public Shared ReadOnly Property position_name() As String
            Get
                Return ResourceManager.GetString("position_name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  保存 に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Public Shared ReadOnly Property save() As String
            Get
                Return ResourceManager.GetString("save", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  ユーザー名 に類似しているローカライズされた文字列を検索します。
        '''</summary>
        Public Shared ReadOnly Property user_name() As String
            Get
                Return ResourceManager.GetString("user_name", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
