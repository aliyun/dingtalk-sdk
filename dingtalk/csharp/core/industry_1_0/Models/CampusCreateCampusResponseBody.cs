// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CampusCreateCampusResponseBody : TeaModel {
        /// <summary>
        /// 园区组织ID
        /// </summary>
        [NameInMap("campusCorpId")]
        [Validation(Required=false)]
        public string CampusCorpId { get; set; }

        /// <summary>
        /// 园区部门ID
        /// </summary>
        [NameInMap("campusDeptId")]
        [Validation(Required=false)]
        public string CampusDeptId { get; set; }

    }

}
