// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class QueryDigitalDistrictOrgInfoRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("corpIds")]
        [Validation(Required=false)]
        public List<string> CorpIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("statDates")]
        [Validation(Required=false)]
        public List<string> StatDates { get; set; }

    }

}
