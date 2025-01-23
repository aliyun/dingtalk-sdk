// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SubmitTaskPackageRequest : TeaModel {
        [NameInMap("appId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("appSecret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<SubmitTaskPackageRequestData> Data { get; set; }
        public class SubmitTaskPackageRequestData : TeaModel {
            [NameInMap("extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            [NameInMap("fileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            [NameInMap("fileUrls")]
            [Validation(Required=false)]
            public List<string> FileUrls { get; set; }

            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("textContent")]
            [Validation(Required=false)]
            public string TextContent { get; set; }

        }

        [NameInMap("desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("fileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        [NameInMap("taskPackageName")]
        [Validation(Required=false)]
        public string TaskPackageName { get; set; }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
