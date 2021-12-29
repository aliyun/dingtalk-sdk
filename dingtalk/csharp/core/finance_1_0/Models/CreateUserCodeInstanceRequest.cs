// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class CreateUserCodeInstanceRequest : TeaModel {
        /// <summary>
        /// 有效时间列表，对于连续时间段，只需传入一个对象即可，注意过期时间必须晚于最晚结束时间
        /// </summary>
        [NameInMap("availableTimes")]
        [Validation(Required=false)]
        public List<CreateUserCodeInstanceRequestAvailableTimes> AvailableTimes { get; set; }
        public class CreateUserCodeInstanceRequestAvailableTimes : TeaModel {
            /// <summary>
            /// 开始时间
            /// </summary>
            [NameInMap("gmtStart")]
            [Validation(Required=false)]
            public string GmtStart { get; set; }

            /// <summary>
            /// 结束时间
            /// </summary>
            [NameInMap("gmtEnd")]
            [Validation(Required=false)]
            public string GmtEnd { get; set; }

        }

        /// <summary>
        /// 码标识，由钉钉颁发
        /// </summary>
        [NameInMap("codeIdentity")]
        [Validation(Required=false)]
        public string CodeIdentity { get; set; }

        /// <summary>
        /// 码值
        /// </summary>
        [NameInMap("codeValue")]
        [Validation(Required=false)]
        public string CodeValue { get; set; }

        /// <summary>
        /// 码值类型，钉钉静态码值：DING_STATIC，访客码或会展码传入
        /// </summary>
        [NameInMap("codeValueType")]
        [Validation(Required=false)]
        public string CodeValueType { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtInfo { get; set; }

        /// <summary>
        /// 临时码，传入过期时间
        /// </summary>
        [NameInMap("gmtExpired")]
        [Validation(Required=false)]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 业务幂等ID
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 状态，传入关闭状态需要用户手动开启后才会渲染二维
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 用户和企业的关系类型，区分内部员工，外部联系人，无关系普通用户
        /// </summary>
        [NameInMap("userCorpRelationType")]
        [Validation(Required=false)]
        public string UserCorpRelationType { get; set; }

        /// <summary>
        /// 用户身份标识，取值和用户企业关系类型相关，如果企业无关，传入手机号
        /// </summary>
        [NameInMap("userIdentity")]
        [Validation(Required=false)]
        public string UserIdentity { get; set; }

    }

}
