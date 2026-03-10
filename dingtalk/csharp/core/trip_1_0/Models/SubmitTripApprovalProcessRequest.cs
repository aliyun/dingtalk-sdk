// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SubmitTripApprovalProcessRequest : TeaModel {
        [NameInMap("itineraries")]
        [Validation(Required=false)]
        public List<SubmitTripApprovalProcessRequestItineraries> Itineraries { get; set; }
        public class SubmitTripApprovalProcessRequestItineraries : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-01-20 09:00</para>
            /// </summary>
            [NameInMap("departureTime")]
            [Validation(Required=false)]
            public string DepartureTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>北京</para>
            /// </summary>
            [NameInMap("destination")]
            [Validation(Required=false)]
            public string Destination { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>望京阿里巴巴园区</para>
            /// </summary>
            [NameInMap("destinationDetail")]
            [Validation(Required=false)]
            public string DestinationDetail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>杭州</para>
            /// </summary>
            [NameInMap("placeOfDeparture")]
            [Validation(Required=false)]
            public string PlaceOfDeparture { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>余杭区文一西路969号</para>
            /// </summary>
            [NameInMap("placeOfDepartureDetail")]
            [Validation(Required=false)]
            public string PlaceOfDepartureDetail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-01-22 09:00</para>
            /// </summary>
            [NameInMap("returnTime")]
            [Validation(Required=false)]
            public string ReturnTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>单程</para>
            /// </summary>
            [NameInMap("singleOrReturn")]
            [Validation(Required=false)]
            public string SingleOrReturn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>飞机</para>
            /// </summary>
            [NameInMap("vehicle")]
            [Validation(Required=false)]
            public string Vehicle { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PROC_XXXX</para>
        /// </summary>
        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>拜访客户</para>
        /// </summary>
        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5046195764756652</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
