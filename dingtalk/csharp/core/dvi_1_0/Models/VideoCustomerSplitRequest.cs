// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class VideoCustomerSplitRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("customer")]
        [Validation(Required=false)]
        public VideoCustomerSplitRequestCustomer Customer { get; set; }
        public class VideoCustomerSplitRequestCustomer : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("customers")]
            [Validation(Required=false)]
            public List<VideoCustomerSplitRequestCustomerCustomers> Customers { get; set; }
            public class VideoCustomerSplitRequestCustomerCustomers : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("appearance")]
                [Validation(Required=false)]
                public VideoCustomerSplitRequestCustomerCustomersAppearance Appearance { get; set; }
                public class VideoCustomerSplitRequestCustomerCustomersAppearance : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    [NameInMap("videoId")]
                    [Validation(Required=false)]
                    public string VideoId { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("customerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("segmentId")]
        [Validation(Required=false)]
        public string SegmentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
