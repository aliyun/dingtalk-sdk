// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapp_market_1_0.Models
{
    public class GetPersonalExperienceInfoResponseBody : TeaModel {
        /// <summary>
        /// 数据对象
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetPersonalExperienceInfoResponseBodyResult Result { get; set; }
        public class GetPersonalExperienceInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// 主组织corpId
            /// </summary>
            [NameInMap("mainCorpId")]
            [Validation(Required=false)]
            public string MainCorpId { get; set; }

        }

    }

}
