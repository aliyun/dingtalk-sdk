// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetQualificationCertResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// EntName:企业名称
        /// CertType:证书类型
        /// CertNum:证书认证编号
        /// ValidStartDate:有效期开始日期
        /// ValidEndDate:有效期截止日期
        /// AuthorizeDate:授权日期
        /// AuthorizeDepartment:授权部门
        /// PubDate:公示日期
        /// Province:省份
        /// CertScope:认证范围
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
