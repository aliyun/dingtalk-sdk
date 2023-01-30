// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetAdministrativeLicensingResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// LicenseNo:许可文件编号
        /// LicenseName:许可文件名称
        /// Department:许可机关
        /// StartDate:有效期自
        /// EndDate:有效期至
        /// Content:许可内容
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
