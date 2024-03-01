// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class ListUserVisibleBpmsProcessesResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListUserVisibleBpmsProcessesResponseBodyResult Result { get; set; }
        public class ListUserVisibleBpmsProcessesResponseBodyResult : TeaModel {
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public long? NextToken { get; set; }

            [NameInMap("processList")]
            [Validation(Required=false)]
            public List<ListUserVisibleBpmsProcessesResponseBodyResultProcessList> ProcessList { get; set; }
            public class ListUserVisibleBpmsProcessesResponseBodyResultProcessList : TeaModel {
                [NameInMap("dirId")]
                [Validation(Required=false)]
                public string DirId { get; set; }

                [NameInMap("dirName")]
                [Validation(Required=false)]
                public string DirName { get; set; }

                [NameInMap("iconUrl")]
                [Validation(Required=false)]
                public string IconUrl { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("processCode")]
                [Validation(Required=false)]
                public string ProcessCode { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

    }

}
