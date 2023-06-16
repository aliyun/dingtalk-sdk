// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class GetUserMetricDataResponseBody : TeaModel {
        [NameInMap("metricDataList")]
        [Validation(Required=false)]
        public List<GetUserMetricDataResponseBodyMetricDataList> MetricDataList { get; set; }
        public class GetUserMetricDataResponseBodyMetricDataList : TeaModel {
            [NameInMap("audioPlayLevel")]
            [Validation(Required=false)]
            public string AudioPlayLevel { get; set; }

            [NameInMap("audioRecLevel")]
            [Validation(Required=false)]
            public string AudioRecLevel { get; set; }

            [NameInMap("audioRecvBitRate")]
            [Validation(Required=false)]
            public string AudioRecvBitRate { get; set; }

            [NameInMap("audioSendBitRate")]
            [Validation(Required=false)]
            public string AudioSendBitRate { get; set; }

            [NameInMap("cameraRecvBitRate")]
            [Validation(Required=false)]
            public string CameraRecvBitRate { get; set; }

            [NameInMap("cameraRecvFrame")]
            [Validation(Required=false)]
            public string CameraRecvFrame { get; set; }

            [NameInMap("cameraRecvResolutionActual")]
            [Validation(Required=false)]
            public string CameraRecvResolutionActual { get; set; }

            [NameInMap("cameraSendBitRate")]
            [Validation(Required=false)]
            public string CameraSendBitRate { get; set; }

            [NameInMap("cameraSendFrame")]
            [Validation(Required=false)]
            public string CameraSendFrame { get; set; }

            [NameInMap("cameraSendResolutionActual")]
            [Validation(Required=false)]
            public string CameraSendResolutionActual { get; set; }

            [NameInMap("lostRate")]
            [Validation(Required=false)]
            public string LostRate { get; set; }

            [NameInMap("recvBitRate")]
            [Validation(Required=false)]
            public string RecvBitRate { get; set; }

            [NameInMap("roundTripTime")]
            [Validation(Required=false)]
            public string RoundTripTime { get; set; }

            [NameInMap("screenRecvBitRate")]
            [Validation(Required=false)]
            public string ScreenRecvBitRate { get; set; }

            [NameInMap("screenRecvFrame")]
            [Validation(Required=false)]
            public string ScreenRecvFrame { get; set; }

            [NameInMap("screenRecvResolutionActual")]
            [Validation(Required=false)]
            public string ScreenRecvResolutionActual { get; set; }

            [NameInMap("screenSendBitRate")]
            [Validation(Required=false)]
            public string ScreenSendBitRate { get; set; }

            [NameInMap("screenSendFrame")]
            [Validation(Required=false)]
            public string ScreenSendFrame { get; set; }

            [NameInMap("screenSendResolutionActual")]
            [Validation(Required=false)]
            public string ScreenSendResolutionActual { get; set; }

            [NameInMap("sendBitRate")]
            [Validation(Required=false)]
            public string SendBitRate { get; set; }

            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

    }

}
