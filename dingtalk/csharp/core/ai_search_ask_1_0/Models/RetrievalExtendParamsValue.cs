// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_search_ask_1_0.Models
{
    public class RetrievalExtendParamsValue : TeaModel {
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("keywords")]
        [Validation(Required=false)]
        public List<string> Keywords { get; set; }

        [NameInMap("sourceUserParams")]
        [Validation(Required=false)]
        public List<RetrievalExtendParamsValueSourceUserParams> SourceUserParams { get; set; }
        public class RetrievalExtendParamsValueSourceUserParams : TeaModel {
            [NameInMap("nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            [NameInMap("staffId")]
            [Validation(Required=false)]
            public string StaffId { get; set; }

        }

        [NameInMap("targetUserParams")]
        [Validation(Required=false)]
        public List<RetrievalExtendParamsValueTargetUserParams> TargetUserParams { get; set; }
        public class RetrievalExtendParamsValueTargetUserParams : TeaModel {
            [NameInMap("nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            [NameInMap("staffId")]
            [Validation(Required=false)]
            public string StaffId { get; set; }

        }

    }

}
