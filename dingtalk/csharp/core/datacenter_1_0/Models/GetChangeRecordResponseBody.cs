// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetChangeRecordResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[         {             &quot;Type&quot;:&quot;投资人变更(包括出资额、出资方式、出资日期、投资人名称等)&quot;,             &quot;ChangeDate&quot;:&quot;2014-12-23&quot;,             &quot;AfterContent&quot;:&quot;股东名称:华为投资控股有限公司、出资额:3990813.182000、出资比例:100.000000;&quot;,             &quot;BeforeContent&quot;:&quot;股东名称:华为投资控股有限公司、出资额:3960813.182000、出资比例:100.000000;&quot;         },         {             &quot;Type&quot;:&quot;期限变更(经营期限、营业期限、驻在期限、合伙期限等变更)&quot;,             &quot;ChangeDate&quot;:&quot;1997-12-04&quot;,             &quot;AfterContent&quot;:&quot;1987-09-15,2040-04-09&quot;,             &quot;BeforeContent&quot;:&quot;1987-09-15,1998-12-31&quot;         } ]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
