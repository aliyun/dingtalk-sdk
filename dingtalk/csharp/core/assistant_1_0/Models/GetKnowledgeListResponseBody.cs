// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_1_0.Models
{
    public class GetKnowledgeListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetKnowledgeListResponseBodyResult Result { get; set; }
        public class GetKnowledgeListResponseBodyResult : TeaModel {
            [NameInMap("knowledgeList")]
            [Validation(Required=false)]
            public List<GetKnowledgeListResponseBodyResultKnowledgeList> KnowledgeList { get; set; }
            public class GetKnowledgeListResponseBodyResultKnowledgeList : TeaModel {
                [NameInMap("docFormat")]
                [Validation(Required=false)]
                public string DocFormat { get; set; }

                [NameInMap("docName")]
                [Validation(Required=false)]
                public string DocName { get; set; }

                [NameInMap("docUrl")]
                [Validation(Required=false)]
                public string DocUrl { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("studyId")]
                [Validation(Required=false)]
                public string StudyId { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
