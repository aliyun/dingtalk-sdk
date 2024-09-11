// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class AddOrgRequest : TeaModel {
        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        [NameInMap("industryCode")]
        [Validation(Required=false)]
        public int? IndustryCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("mobileNum")]
        [Validation(Required=false)]
        public string MobileNum { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("province")]
        [Validation(Required=false)]
        public string Province { get; set; }

    }

}
