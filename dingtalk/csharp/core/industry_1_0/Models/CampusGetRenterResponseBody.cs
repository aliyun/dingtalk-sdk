// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CampusGetRenterResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ding121313</para>
        /// </summary>
        [NameInMap("bindRenterCorpId")]
        [Validation(Required=false)]
        public string BindRenterCorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1655704317794</para>
        /// </summary>
        [NameInMap("bindTime")]
        [Validation(Required=false)]
        public long? BindTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>231313</para>
        /// </summary>
        [NameInMap("creditCode")]
        [Validation(Required=false)]
        public string CreditCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1655704317794</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>扩展</para>
        /// </summary>
        [NameInMap("extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>名称</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("renterDeptId")]
        [Validation(Required=false)]
        public long? RenterDeptId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1655704317794</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public int? State { get; set; }

    }

}
