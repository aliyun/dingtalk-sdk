// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcredit_1_0.Models
{
    public class QueryScoreRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("encryption")]
        [Validation(Required=false)]
        public string Encryption { get; set; }

        [NameInMap("fullName")]
        [Validation(Required=false)]
        public string FullName { get; set; }

        [NameInMap("idCardCode")]
        [Validation(Required=false)]
        public string IdCardCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        [NameInMap("uniScCode")]
        [Validation(Required=false)]
        public string UniScCode { get; set; }

    }

}
