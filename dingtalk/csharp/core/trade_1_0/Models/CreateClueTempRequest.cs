// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrade_1_0.Models
{
    public class CreateClueTempRequest : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("phoneNum")]
        [Validation(Required=false)]
        public string PhoneNum { get; set; }

        [NameInMap("position")]
        [Validation(Required=false)]
        public string Position { get; set; }

        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("salesId")]
        [Validation(Required=false)]
        public long? SalesId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
