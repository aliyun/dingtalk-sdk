// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class GetProductResponseBody : TeaModel {
        [NameInMap("accountantBookIdList")]
        [Validation(Required=false)]
        public List<string> AccountantBookIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PROD-xxx</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1634786828686</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>和外部合作</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("information")]
        [Validation(Required=false)]
        public string Information { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>外包商品</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>规格型号</para>
        /// </summary>
        [NameInMap("specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>valid</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>个</para>
        /// </summary>
        [NameInMap("unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

        [NameInMap("userDefineCode")]
        [Validation(Required=false)]
        public string UserDefineCode { get; set; }

    }

}
