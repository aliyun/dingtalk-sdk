// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class HrmProcessUpdateTerminationInfoRequest : TeaModel {
        /// <summary>
        /// 离职备注
        /// </summary>
        [NameInMap("dismissionMemo")]
        [Validation(Required=false)]
        public string DismissionMemo { get; set; }

        /// <summary>
        /// 最后工作日(离职日期)
        /// </summary>
        [NameInMap("lastWorkDate")]
        [Validation(Required=false)]
        public long? LastWorkDate { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
