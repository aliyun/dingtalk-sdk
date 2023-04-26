// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class InstallAppRequest : TeaModel {
        [NameInMap("bizGroup")]
        [Validation(Required=false)]
        public string BizGroup { get; set; }

        [NameInMap("installOption")]
        [Validation(Required=false)]
        public InstallAppRequestInstallOption InstallOption { get; set; }
        public class InstallAppRequestInstallOption : TeaModel {
            [NameInMap("isSync")]
            [Validation(Required=false)]
            public bool? IsSync { get; set; }

        }

        [NameInMap("sourceDirName")]
        [Validation(Required=false)]
        public string SourceDirName { get; set; }

    }

}
