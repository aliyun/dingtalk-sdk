// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class AddApproveDentryAuthRequest : TeaModel {
        [NameInMap("fileInfos")]
        [Validation(Required=false)]
        public List<AddApproveDentryAuthRequestFileInfos> FileInfos { get; set; }
        public class AddApproveDentryAuthRequestFileInfos : TeaModel {
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public long? SpaceId { get; set; }

        }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
