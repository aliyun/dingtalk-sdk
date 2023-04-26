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

                [NameInMap("formCode")]
                [Validation(Required=false)]
                public string FormCode { get; set; }

                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("layoutDesign")]
                [Validation(Required=false)]
                public string LayoutDesign { get; set; }

                [NameInMap("sceneCode")]
                [Validation(Required=false)]
                public string SceneCode { get; set; }

                [NameInMap("schemaContent")]
                [Validation(Required=false)]
                public string SchemaContent { get; set; }

                [NameInMap("suiteKey")]
                [Validation(Required=false)]
                public string SuiteKey { get; set; }

                [NameInMap("systemTemplate")]
                [Validation(Required=false)]
                public bool? SystemTemplate { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("waterMarkId")]
                [Validation(Required=false)]
                public string WaterMarkId { get; set; }

            }

        }

    }

}
