// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class ListGroupTemplatesByOrgIdResponseBody : TeaModel {
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("sceneGroupDetailModels")]
        [Validation(Required=false)]
        public List<ListGroupTemplatesByOrgIdResponseBodySceneGroupDetailModels> SceneGroupDetailModels { get; set; }
        public class ListGroupTemplatesByOrgIdResponseBodySceneGroupDetailModels : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("msgOpen")]
            [Validation(Required=false)]
            public bool? MsgOpen { get; set; }

            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("templateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
