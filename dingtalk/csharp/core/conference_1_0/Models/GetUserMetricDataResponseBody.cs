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
            /// <summary>
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("audioPlayLevel")]
            [Validation(Required=false)]
            public string AudioPlayLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("audioRecLevel")]
            [Validation(Required=false)]
            public string AudioRecLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>52939</para>
            /// </summary>
            [NameInMap("audioRecvBitRate")]
            [Validation(Required=false)]
            public string AudioRecvBitRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>59103</para>
            /// </summary>
            [NameInMap("audioSendBitRate")]
            [Validation(Required=false)]
            public string AudioSendBitRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>66160</para>
            /// </summary>
            [NameInMap("cameraRecvBitRate")]
            [Validation(Required=false)]
            public string CameraRecvBitRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("cameraRecvFrame")]
            [Validation(Required=false)]
            public string CameraRecvFrame { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1920*1080</para>
            /// </summary>
            [NameInMap("cameraRecvResolutionActual")]
            [Validation(Required=false)]
            public string CameraRecvResolutionActual { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1145172</para>
            /// </summary>
            [NameInMap("cameraSendBitRate")]
            [Validation(Required=false)]
            public string CameraSendBitRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("cameraSendFrame")]
            [Validation(Required=false)]
            public string CameraSendFrame { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1920*1080</para>
            /// </summary>
            [NameInMap("cameraSendResolutionActual")]
            [Validation(Required=false)]
            public string CameraSendResolutionActual { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("lostRate")]
            [Validation(Required=false)]
            public string LostRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>66160</para>
            /// </summary>
            [NameInMap("recvBitRate")]
            [Validation(Required=false)]
            public string RecvBitRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("roundTripTime")]
            [Validation(Required=false)]
            public string RoundTripTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("screenRecvBitRate")]
            [Validation(Required=false)]
            public string ScreenRecvBitRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("screenRecvFrame")]
            [Validation(Required=false)]
            public string ScreenRecvFrame { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1920*1080</para>
            /// </summary>
            [NameInMap("screenRecvResolutionActual")]
            [Validation(Required=false)]
            public string ScreenRecvResolutionActual { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15701</para>
            /// </summary>
            [NameInMap("screenSendBitRate")]
            [Validation(Required=false)]
            public string ScreenSendBitRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>14</para>
            /// </summary>
            [NameInMap("screenSendFrame")]
            [Validation(Required=false)]
            public string ScreenSendFrame { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1920*1080</para>
            /// </summary>
            [NameInMap("screenSendResolutionActual")]
            [Validation(Required=false)]
            public string ScreenSendResolutionActual { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1145172</para>
            /// </summary>
            [NameInMap("sendBitRate")]
            [Validation(Required=false)]
            public string SendBitRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1682562120000</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

    }

}
