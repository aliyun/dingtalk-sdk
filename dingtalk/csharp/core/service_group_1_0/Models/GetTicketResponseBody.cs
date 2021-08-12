// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class GetTicketResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("openTicketId")]
        [Validation(Required=false)]
        public string OpenTicketId { get; set; }

        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("creator")]
        [Validation(Required=false)]
        public GetTicketResponseBodyCreator Creator { get; set; }
        public class GetTicketResponseBodyCreator : TeaModel {
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }
        };

        [NameInMap("processor")]
        [Validation(Required=false)]
        public GetTicketResponseBodyProcessor Processor { get; set; }
        public class GetTicketResponseBodyProcessor : TeaModel {
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }
        };

        [NameInMap("takers")]
        [Validation(Required=false)]
        public List<GetTicketResponseBodyTakers> Takers { get; set; }
        public class GetTicketResponseBodyTakers : TeaModel {
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

        }

        [NameInMap("stage")]
        [Validation(Required=false)]
        public string Stage { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("customFields")]
        [Validation(Required=false)]
        public string CustomFields { get; set; }

        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("sceneContext")]
        [Validation(Required=false)]
        public string SceneContext { get; set; }

        [NameInMap("template")]
        [Validation(Required=false)]
        public GetTicketResponseBodyTemplate Template { get; set; }
        public class GetTicketResponseBodyTemplate : TeaModel {
            [NameInMap("openTemplateId")]
            [Validation(Required=false)]
            public string OpenTemplateId { get; set; }
            [NameInMap("openTemplateBizId")]
            [Validation(Required=false)]
            public string OpenTemplateBizId { get; set; }
            [NameInMap("templateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }
        };

    }

}
