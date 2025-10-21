// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetTrustDeviceListRequest : TeaModel {
        [NameInMap("deviceUuid")]
        [Validation(Required=false)]
        public string DeviceUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1721718854814</para>
        /// </summary>
        [NameInMap("gmtCreateEnd")]
        [Validation(Required=false)]
        public long? GmtCreateEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1721718854814</para>
        /// </summary>
        [NameInMap("gmtCreateStart")]
        [Validation(Required=false)]
        public long? GmtCreateStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1721718854814</para>
        /// </summary>
        [NameInMap("gmtModifiedEnd")]
        [Validation(Required=false)]
        public long? GmtModifiedEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1721718854814</para>
        /// </summary>
        [NameInMap("gmtModifiedStart")]
        [Validation(Required=false)]
        public long? GmtModifiedStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xx:xx:xx:xx:xx:xx</para>
        /// </summary>
        [NameInMap("macAddress")]
        [Validation(Required=false)]
        public string MacAddress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Android</para>
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("serialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
