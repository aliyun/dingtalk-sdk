// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class InstallAppRequest : TeaModel {
        /// <summary>
        /// 安装选项
        /// 
        /// </summary>
        [NameInMap("installOption")]
        [Validation(Required=false)]
        public InstallAppRequestInstallOption InstallOption { get; set; }
        public class InstallAppRequestInstallOption : TeaModel {
            /// <summary>
            /// 是否同步，目前只有同步
            /// </summary>
            [NameInMap("isSync")]
            [Validation(Required=false)]
            public bool? IsSync { get; set; }

        }

        /// <summary>
        /// 安装的目录名称
        /// </summary>
        [NameInMap("sourceDirName")]
        [Validation(Required=false)]
        public string SourceDirName { get; set; }

    }

}
