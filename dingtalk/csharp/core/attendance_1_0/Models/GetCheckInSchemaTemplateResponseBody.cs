// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetCheckInSchemaTemplateResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetCheckInSchemaTemplateResponseBodyResult Result { get; set; }
        public class GetCheckInSchemaTemplateResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>water_mark_checkin</para>
            /// </summary>
            [NameInMap("bizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            [NameInMap("canModifyAndAddTemplate")]
            [Validation(Required=false)]
            public bool? CanModifyAndAddTemplate { get; set; }

            [NameInMap("conversationAdmin")]
            [Validation(Required=false)]
            public bool? ConversationAdmin { get; set; }

            [NameInMap("customTemplateMaxSize")]
            [Validation(Required=false)]
            public int? CustomTemplateMaxSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            [NameInMap("showStat")]
            [Validation(Required=false)]
            public bool? ShowStat { get; set; }

            [NameInMap("templateDegrade")]
            [Validation(Required=false)]
            public bool? TemplateDegrade { get; set; }

            [NameInMap("waterMarkTemplateModels")]
            [Validation(Required=false)]
            public List<GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels> WaterMarkTemplateModels { get; set; }
            public class GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels : TeaModel {
                [NameInMap("canModify")]
                [Validation(Required=false)]
                public bool? CanModify { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PROC-292988B1-5064-4A42-9389-xxxxx</para>
                /// </summary>
                [NameInMap("formCode")]
                [Validation(Required=false)]
                public string FormCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://xx.xx.png">https://xx.xx.png</a></para>
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{     &quot;widgetName&quot;:&quot;dd_watermark_xxx_xxx&quot;,     &quot;miniAppId&quot;:&quot;50000xxx&quot;,     &quot;templateRule&quot;:{         &quot;maxItems&quot;:6,         &quot;canEditColor&quot;:true,         &quot;canEditTitle&quot;:true,         &quot;items&quot;:[          ]     },     &quot;layoutDesignId&quot;:&quot;industry_xx_xx&quot;,     &quot;width&quot;:&quot;111&quot; }</para>
                /// </summary>
                [NameInMap("layoutDesign")]
                [Validation(Required=false)]
                public string LayoutDesign { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>water_mark_checkin_open</para>
                /// </summary>
                [NameInMap("sceneCode")]
                [Validation(Required=false)]
                public string SceneCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{     &quot;items&quot;:[         {             &quot;componentName&quot;:&quot;HiddenField&quot;,             &quot;props&quot;:{                 &quot;bizAlias&quot;:&quot;enableModifyPlace&quot;,                 &quot;id&quot;:&quot;enableModifyPlace-undefined&quot;,                 &quot;value&quot;:&quot;true&quot;             }         },         {             &quot;componentName&quot;:&quot;HiddenField&quot;,             &quot;props&quot;:{                 &quot;bizAlias&quot;:&quot;modifyPlaceDistance&quot;,                 &quot;id&quot;:&quot;modifyPlaceDistance-undefined&quot;,                 &quot;value&quot;:200             }         },         {             &quot;componentName&quot;:&quot;HiddenField&quot;,             &quot;props&quot;:{                 &quot;bizAlias&quot;:&quot;title&quot;,                 &quot;id&quot;:&quot;title-undefined&quot;,                 &quot;value&quot;:&quot;wofu1&quot;             }         },         {             &quot;componentName&quot;:&quot;HiddenField&quot;,             &quot;props&quot;:{                 &quot;bizAlias&quot;:&quot;titleBgColor&quot;,                 &quot;id&quot;:&quot;titleBgColor-undefined&quot;,                 &quot;value&quot;:&quot;#0089FF&quot;             }         }     ] }</para>
                /// </summary>
                [NameInMap("schemaContent")]
                [Validation(Required=false)]
                public string SchemaContent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>suiteKey</para>
                /// </summary>
                [NameInMap("suiteKey")]
                [Validation(Required=false)]
                public string SuiteKey { get; set; }

                [NameInMap("systemTemplate")]
                [Validation(Required=false)]
                public bool? SystemTemplate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>标题</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PROC-292988B1-5064-4A42-9389-xxxxx</para>
                /// </summary>
                [NameInMap("waterMarkId")]
                [Validation(Required=false)]
                public string WaterMarkId { get; set; }

            }

        }

    }

}
