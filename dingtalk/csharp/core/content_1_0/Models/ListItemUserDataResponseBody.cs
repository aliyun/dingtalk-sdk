// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class ListItemUserDataResponseBody : TeaModel {
        [NameInMap("studyInfos")]
        [Validation(Required=false)]
        public List<ListItemUserDataResponseBodyStudyInfos> StudyInfos { get; set; }
        public class ListItemUserDataResponseBodyStudyInfos : TeaModel {
            [NameInMap("durationMillis")]
            [Validation(Required=false)]
            public long? DurationMillis { get; set; }

            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

    }

}
