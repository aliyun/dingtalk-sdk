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
                public bool? CanModify { get; set; }
                public string FormCode { get; set; }
                public string Icon { get; set; }
                public string LayoutDesign { get; set; }
                public string SceneCode { get; set; }
                public string SchemaContent { get; set; }
                public string SuiteKey { get; set; }
                public bool? SystemTemplate { get; set; }
                public string Title { get; set; }
                public string WaterMarkId { get; set; }
            }
        };

    }

}
