// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class MoveDentriesResponseBody : TeaModel {
        [NameInMap("resultItems")]
        [Validation(Required=false)]
        public List<MoveDentriesResponseBodyResultItems> ResultItems { get; set; }
        public class MoveDentriesResponseBodyResultItems : TeaModel {
            [NameInMap("async")]
            [Validation(Required=false)]
            public bool? Async { get; set; }

            [NameInMap("dentryId")]
            [Validation(Required=false)]
            public string DentryId { get; set; }

            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("targetDentryId")]
            [Validation(Required=false)]
            public string TargetDentryId { get; set; }

            [NameInMap("targetSpaceId")]
            [Validation(Required=false)]
            public string TargetSpaceId { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
