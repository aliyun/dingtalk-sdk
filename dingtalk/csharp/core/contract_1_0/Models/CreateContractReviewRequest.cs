// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class CreateContractReviewRequest : TeaModel {
        [NameInMap("companyList")]
        [Validation(Required=false)]
        public List<string> CompanyList { get; set; }

        [NameInMap("customReviewRules")]
        [Validation(Required=false)]
        public string CustomReviewRules { get; set; }

        [NameInMap("fileInfo")]
        [Validation(Required=false)]
        public CreateContractReviewRequestFileInfo FileInfo { get; set; }
        public class CreateContractReviewRequestFileInfo : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public string FileSize { get; set; }

            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

        }

        [NameInMap("originatorUserId")]
        [Validation(Required=false)]
        public string OriginatorUserId { get; set; }

        [NameInMap("reviewPosition")]
        [Validation(Required=false)]
        public string ReviewPosition { get; set; }

        [NameInMap("reviewResultType")]
        [Validation(Required=false)]
        public string ReviewResultType { get; set; }

        [NameInMap("reviewType")]
        [Validation(Required=false)]
        public string ReviewType { get; set; }

    }

}
