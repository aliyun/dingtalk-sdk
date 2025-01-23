// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkflashmeeting_1_0.Models
{
    public class ExportShanhuiToDocRequest : TeaModel {
        [NameInMap("contentEnums")]
        [Validation(Required=false)]
        public List<string> ContentEnums { get; set; }

        [NameInMap("parentNodeKey")]
        [Validation(Required=false)]
        public string ParentNodeKey { get; set; }

        [NameInMap("shanhuiKey")]
        [Validation(Required=false)]
        public string ShanhuiKey { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("workspaceKey")]
        [Validation(Required=false)]
        public string WorkspaceKey { get; set; }

    }

}
