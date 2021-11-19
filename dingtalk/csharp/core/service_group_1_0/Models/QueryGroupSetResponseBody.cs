// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueryGroupSetResponseBody : TeaModel {
        /// <summary>
        /// records
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<QueryGroupSetResponseBodyRecords> Records { get; set; }
        public class QueryGroupSetResponseBodyRecords : TeaModel {
            [NameInMap("openGroupSetId")]
            [Validation(Required=false)]
            public string OpenGroupSetId { get; set; }

            [NameInMap("groupSetName")]
            [Validation(Required=false)]
            public string GroupSetName { get; set; }

            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

        }

    }

}
