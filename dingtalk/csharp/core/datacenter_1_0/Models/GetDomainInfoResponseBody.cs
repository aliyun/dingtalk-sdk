// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetDomainInfoResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// EntName:企业名称
        /// Number:备案号
        /// Domain:域名
        /// SiteName:网站名称
        /// HomeUrl:网站首页链接
        /// CheckDate:备案日期
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
