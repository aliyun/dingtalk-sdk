// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class AddRosterFieldFormResponseBody : TeaModel {
        [NameInMap("dingOpenErrcode")]
        [Validation(Required=false)]
        public int? DingOpenErrcode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public AddRosterFieldFormResponseBodyResult Result { get; set; }
        public class AddRosterFieldFormResponseBodyResult : TeaModel {
            [NameInMap("bizGroupId")]
            [Validation(Required=false)]
            public long? BizGroupId { get; set; }

            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("deleteFlag")]
            [Validation(Required=false)]
            public string DeleteFlag { get; set; }

            [NameInMap("detail")]
            [Validation(Required=false)]
            public bool? Detail { get; set; }

            [NameInMap("formId")]
            [Validation(Required=false)]
            public string FormId { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public object GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public object GmtModified { get; set; }

            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("sortOrder")]
            [Validation(Required=false)]
            public int? SortOrder { get; set; }

            [NameInMap("versionId")]
            [Validation(Required=false)]
            public int? VersionId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
