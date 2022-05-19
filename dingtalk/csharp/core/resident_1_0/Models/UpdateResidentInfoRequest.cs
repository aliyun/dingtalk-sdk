// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class UpdateResidentInfoRequest : TeaModel {
        /// <summary>
        /// 小区地址
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// 小区类型1纯住宅；2:商住混合；3:办公；4:办公商业混合；5:商业；6:公共场所；7:其他
        /// </summary>
        [NameInMap("communityType")]
        [Validation(Required=false)]
        public long? CommunityType { get; set; }

        /// <summary>
        /// 小区名
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 小区状态：0正常/1关闭/2作废
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public long? State { get; set; }

    }

}
