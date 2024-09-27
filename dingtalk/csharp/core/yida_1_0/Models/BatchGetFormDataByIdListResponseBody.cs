// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class BatchGetFormDataByIdListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<BatchGetFormDataByIdListResponseBodyResult> Result { get; set; }
        public class BatchGetFormDataByIdListResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-05-01</para>
            /// </summary>
            [NameInMap("createTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding12345</para>
            /// </summary>
            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;addressField_l0c1cwiy_id&quot;:&quot;&quot;海南省/469027/国营红岗农场/111&quot;&quot;,&quot;associationFormField_l0c1hdz4_id&quot;:&quot;&quot;[{\&quot;formType\&quot;:\&quot;receipt\&quot;,\&quot;formUuid\&quot;:\&quot;FORM-QQ866JB1QW8YM5XZZZ64VQB61OGM1MLWE1C0LG\&quot;,\&quot;instanceId\&quot;:\&quot;FINST-CC666Y6198RY0LAN39XGND212MSX3TFT95S0LN31\&quot;,\&quot;subTitle\&quot;:\&quot;{\\\&quot;type\\\&quot;:\\\&quot;div\\\&quot;,\\\&quot;props\\\&quot;:{\\\&quot;children\\\&quot;:{\\\&quot;type\\\&quot;:\\\&quot;a\\\&quot;,\\\&quot;props\\\&quot;:{\\\&quot;children\\\&quot;:\\\&quot;查看签名\\\&quot;,\\\&quot;className\\\&quot;:\\\&quot;inst-cell-item-link\\\&quot;,\\\&quot;style\\\&quot;:{\\\&quot;cursor\\\&quot;:\\\&quot;pointer\\\&quot;,\\\&quot;color\\\&quot;:\\\&quot;#0068ff\\\&quot;}}},\\\&quot;className\\\&quot;:\\\&quot;inst-cell-item\\\&quot;}}\&quot;,\&quot;appType\&quot;:\&quot;APP_K6IGJJ6PFAARLPDSWKXQ\&quot;,\&quot;title\&quot;:\&quot;1\&quot;}]&quot;&quot;,&quot;countrySelectField_l0c1cwiu_id&quot;:[&quot;PG&quot;]}</para>
            /// </summary>
            [NameInMap("formData")]
            [Validation(Required=false)]
            public Dictionary<string, object> FormData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FINST-J8766S91O2UYN87ZX3XOF1MY8MBA2912BSV0L24</para>
            /// </summary>
            [NameInMap("formInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA</para>
            /// </summary>
            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>符合宜搭表单实例格式的json数据</para>
            /// </summary>
            [NameInMap("instanceValue")]
            [Validation(Required=false)]
            public string InstanceValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-05-01</para>
            /// </summary>
            [NameInMap("modifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>manager123</para>
            /// </summary>
            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            [NameInMap("modifyUser")]
            [Validation(Required=false)]
            public BatchGetFormDataByIdListResponseBodyResultModifyUser ModifyUser { get; set; }
            public class BatchGetFormDataByIdListResponseBodyResultModifyUser : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public BatchGetFormDataByIdListResponseBodyResultModifyUserName Name { get; set; }
                public class BatchGetFormDataByIdListResponseBodyResultModifyUserName : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("nameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ZhangSan</para>
                    /// </summary>
                    [NameInMap("nameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ding173982232112232</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("originator")]
            [Validation(Required=false)]
            public BatchGetFormDataByIdListResponseBodyResultOriginator Originator { get; set; }
            public class BatchGetFormDataByIdListResponseBodyResultOriginator : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public BatchGetFormDataByIdListResponseBodyResultOriginatorName Name { get; set; }
                public class BatchGetFormDataByIdListResponseBodyResultOriginatorName : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("nameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ZhangSan</para>
                    /// </summary>
                    [NameInMap("nameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ding173982232112232</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IMPORT-388664B1BAUVB3AYZE1RIUE88TDM1QI9WIOWK2</para>
            /// </summary>
            [NameInMap("sequence")]
            [Validation(Required=false)]
            public string Sequence { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>YIDA909202202250027</para>
            /// </summary>
            [NameInMap("serialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>李四发起的请购单</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

    }

}
