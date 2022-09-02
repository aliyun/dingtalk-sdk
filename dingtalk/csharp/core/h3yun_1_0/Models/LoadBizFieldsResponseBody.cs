// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class LoadBizFieldsResponseBody : TeaModel {
        /// <summary>
        /// 状态码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public LoadBizFieldsResponseBodyData Data { get; set; }
        public class LoadBizFieldsResponseBodyData : TeaModel {
            /// <summary>
            /// 子表结构
            /// </summary>
            [NameInMap("childForms")]
            [Validation(Required=false)]
            public List<LoadBizFieldsResponseBodyDataChildForms> ChildForms { get; set; }
            public class LoadBizFieldsResponseBodyDataChildForms : TeaModel {
                /// <summary>
                /// 子表字段
                /// </summary>
                [NameInMap("fields")]
                [Validation(Required=false)]
                public List<LoadBizFieldsResponseBodyDataChildFormsFields> Fields { get; set; }
                public class LoadBizFieldsResponseBodyDataChildFormsFields : TeaModel {
                    /// <summary>
                    /// 字段数据类型
                    /// </summary>
                    [NameInMap("bizDataType")]
                    [Validation(Required=false)]
                    public string BizDataType { get; set; }

                    /// <summary>
                    /// 字段名或组件名
                    /// </summary>
                    [NameInMap("fieldName")]
                    [Validation(Required=false)]
                    public string FieldName { get; set; }

                    /// <summary>
                    /// 显示名称
                    /// </summary>
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                /// <summary>
                /// 子表名称
                /// </summary>
                [NameInMap("formName")]
                [Validation(Required=false)]
                public string FormName { get; set; }

                /// <summary>
                /// 子表编码
                /// </summary>
                [NameInMap("schemaCode")]
                [Validation(Required=false)]
                public string SchemaCode { get; set; }

            }

            /// <summary>
            /// 字段、组件结构数组
            /// </summary>
            [NameInMap("fields")]
            [Validation(Required=false)]
            public List<LoadBizFieldsResponseBodyDataFields> Fields { get; set; }
            public class LoadBizFieldsResponseBodyDataFields : TeaModel {
                /// <summary>
                /// 字段、自定义组件的数据类型。Bool=逻辑型，DataTime=日期型、日期组件，Double=双精度数值型，Int=整形，Long=长整形，String=长文本，ShortString=短文本，ByteArray=二进制流， Image=图片类型、图片组件，File=附件类型组件，TimeSpan=时间段。Unit=参与者（单人），UnitArray=参与者（多人），Html=html类型，Xml=xml类型 BizObject=业务对象，BizObjectArray=业务对象数组、子表组件，Association=关联到其他对象、关联组件，AssociationArray=关联对象数组，Map=地图类型，Address=地址类型，Formula=公式型空间，Signature=签名控件，Plugin=文字识别Bool
                /// </summary>
                [NameInMap("bizDataType")]
                [Validation(Required=false)]
                public string BizDataType { get; set; }

                /// <summary>
                /// 字段名称
                /// </summary>
                [NameInMap("fieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// 显示名称
                /// </summary>
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            /// <summary>
            /// 表单名称
            /// </summary>
            [NameInMap("formName")]
            [Validation(Required=false)]
            public string FormName { get; set; }

            /// <summary>
            /// 表单编码
            /// </summary>
            [NameInMap("schemaCode")]
            [Validation(Required=false)]
            public string SchemaCode { get; set; }

        }

        /// <summary>
        /// 提示信息
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
