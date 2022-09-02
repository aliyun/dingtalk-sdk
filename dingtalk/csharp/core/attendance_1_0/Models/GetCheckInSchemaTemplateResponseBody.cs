// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetCheckInSchemaTemplateResponseBody : TeaModel {
        /// <summary>
        /// 返回对象。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetCheckInSchemaTemplateResponseBodyResult Result { get; set; }
        public class GetCheckInSchemaTemplateResponseBodyResult : TeaModel {
            /// <summary>
            /// 业务码。
            /// </summary>
            [NameInMap("bizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// 是否可以操作模板。
            /// </summary>
            [NameInMap("canModifyAndAddTemplate")]
            [Validation(Required=false)]
            public bool? CanModifyAndAddTemplate { get; set; }

            /// <summary>
            /// 是否群管理员。
            /// </summary>
            [NameInMap("conversationAdmin")]
            [Validation(Required=false)]
            public bool? ConversationAdmin { get; set; }

            /// <summary>
            /// 自定义模板的最大数量。
            /// </summary>
            [NameInMap("customTemplateMaxSize")]
            [Validation(Required=false)]
            public int? CustomTemplateMaxSize { get; set; }

            /// <summary>
            /// 群会话ID。
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            /// <summary>
            /// 是否展示统计入口。
            /// </summary>
            [NameInMap("showStat")]
            [Validation(Required=false)]
            public bool? ShowStat { get; set; }

            /// <summary>
            /// 是否开启水印模板降级。
            /// </summary>
            [NameInMap("templateDegrade")]
            [Validation(Required=false)]
            public bool? TemplateDegrade { get; set; }

            /// <summary>
            /// 模板列表。
            /// </summary>
            [NameInMap("waterMarkTemplateModels")]
            [Validation(Required=false)]
            public List<GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels> WaterMarkTemplateModels { get; set; }
            public class GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels : TeaModel {
                /// <summary>
                /// 是否可以修改。
                /// </summary>
                [NameInMap("canModify")]
                [Validation(Required=false)]
                public bool? CanModify { get; set; }

                /// <summary>
                /// 模板的表单Code。
                /// </summary>
                [NameInMap("formCode")]
                [Validation(Required=false)]
                public string FormCode { get; set; }

                /// <summary>
                /// 模板的预览图片。
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// 模板的布局信息。
                /// </summary>
                [NameInMap("layoutDesign")]
                [Validation(Required=false)]
                public string LayoutDesign { get; set; }

                /// <summary>
                /// 模板的场景码。
                /// </summary>
                [NameInMap("sceneCode")]
                [Validation(Required=false)]
                public string SceneCode { get; set; }

                /// <summary>
                /// 模板的内容。
                /// </summary>
                [NameInMap("schemaContent")]
                [Validation(Required=false)]
                public string SchemaContent { get; set; }

                /// <summary>
                /// suiteKey。
                /// </summary>
                [NameInMap("suiteKey")]
                [Validation(Required=false)]
                public string SuiteKey { get; set; }

                /// <summary>
                /// 是否系统模板。
                /// </summary>
                [NameInMap("systemTemplate")]
                [Validation(Required=false)]
                public bool? SystemTemplate { get; set; }

                /// <summary>
                /// 模板的标题。
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// 模板的水印ID。
                /// </summary>
                [NameInMap("waterMarkId")]
                [Validation(Required=false)]
                public string WaterMarkId { get; set; }

            }

        }

    }

}
