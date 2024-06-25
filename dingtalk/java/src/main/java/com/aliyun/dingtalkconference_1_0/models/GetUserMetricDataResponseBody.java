// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GetUserMetricDataResponseBody extends TeaModel {
    @NameInMap("metricDataList")
    public java.util.List<GetUserMetricDataResponseBodyMetricDataList> metricDataList;

    public static GetUserMetricDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserMetricDataResponseBody self = new GetUserMetricDataResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserMetricDataResponseBody setMetricDataList(java.util.List<GetUserMetricDataResponseBodyMetricDataList> metricDataList) {
        this.metricDataList = metricDataList;
        return this;
    }
    public java.util.List<GetUserMetricDataResponseBodyMetricDataList> getMetricDataList() {
        return this.metricDataList;
    }

    public static class GetUserMetricDataResponseBodyMetricDataList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>27</p>
         */
        @NameInMap("audioPlayLevel")
        public String audioPlayLevel;

        /**
         * <strong>example:</strong>
         * <p>25</p>
         */
        @NameInMap("audioRecLevel")
        public String audioRecLevel;

        /**
         * <strong>example:</strong>
         * <p>52939</p>
         */
        @NameInMap("audioRecvBitRate")
        public String audioRecvBitRate;

        /**
         * <strong>example:</strong>
         * <p>59103</p>
         */
        @NameInMap("audioSendBitRate")
        public String audioSendBitRate;

        /**
         * <strong>example:</strong>
         * <p>66160</p>
         */
        @NameInMap("cameraRecvBitRate")
        public String cameraRecvBitRate;

        /**
         * <strong>example:</strong>
         * <p>20</p>
         */
        @NameInMap("cameraRecvFrame")
        public String cameraRecvFrame;

        /**
         * <strong>example:</strong>
         * <p>1920*1080</p>
         */
        @NameInMap("cameraRecvResolutionActual")
        public String cameraRecvResolutionActual;

        /**
         * <strong>example:</strong>
         * <p>1145172</p>
         */
        @NameInMap("cameraSendBitRate")
        public String cameraSendBitRate;

        /**
         * <strong>example:</strong>
         * <p>20</p>
         */
        @NameInMap("cameraSendFrame")
        public String cameraSendFrame;

        /**
         * <strong>example:</strong>
         * <p>1920*1080</p>
         */
        @NameInMap("cameraSendResolutionActual")
        public String cameraSendResolutionActual;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("lostRate")
        public String lostRate;

        /**
         * <strong>example:</strong>
         * <p>66160</p>
         */
        @NameInMap("recvBitRate")
        public String recvBitRate;

        /**
         * <strong>example:</strong>
         * <p>20</p>
         */
        @NameInMap("roundTripTime")
        public String roundTripTime;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("screenRecvBitRate")
        public String screenRecvBitRate;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("screenRecvFrame")
        public String screenRecvFrame;

        /**
         * <strong>example:</strong>
         * <p>1920*1080</p>
         */
        @NameInMap("screenRecvResolutionActual")
        public String screenRecvResolutionActual;

        /**
         * <strong>example:</strong>
         * <p>15701</p>
         */
        @NameInMap("screenSendBitRate")
        public String screenSendBitRate;

        /**
         * <strong>example:</strong>
         * <p>14</p>
         */
        @NameInMap("screenSendFrame")
        public String screenSendFrame;

        /**
         * <strong>example:</strong>
         * <p>1920*1080</p>
         */
        @NameInMap("screenSendResolutionActual")
        public String screenSendResolutionActual;

        /**
         * <strong>example:</strong>
         * <p>1145172</p>
         */
        @NameInMap("sendBitRate")
        public String sendBitRate;

        /**
         * <strong>example:</strong>
         * <p>1682562120000</p>
         */
        @NameInMap("timestamp")
        public Long timestamp;

        public static GetUserMetricDataResponseBodyMetricDataList build(java.util.Map<String, ?> map) throws Exception {
            GetUserMetricDataResponseBodyMetricDataList self = new GetUserMetricDataResponseBodyMetricDataList();
            return TeaModel.build(map, self);
        }

        public GetUserMetricDataResponseBodyMetricDataList setAudioPlayLevel(String audioPlayLevel) {
            this.audioPlayLevel = audioPlayLevel;
            return this;
        }
        public String getAudioPlayLevel() {
            return this.audioPlayLevel;
        }

        public GetUserMetricDataResponseBodyMetricDataList setAudioRecLevel(String audioRecLevel) {
            this.audioRecLevel = audioRecLevel;
            return this;
        }
        public String getAudioRecLevel() {
            return this.audioRecLevel;
        }

        public GetUserMetricDataResponseBodyMetricDataList setAudioRecvBitRate(String audioRecvBitRate) {
            this.audioRecvBitRate = audioRecvBitRate;
            return this;
        }
        public String getAudioRecvBitRate() {
            return this.audioRecvBitRate;
        }

        public GetUserMetricDataResponseBodyMetricDataList setAudioSendBitRate(String audioSendBitRate) {
            this.audioSendBitRate = audioSendBitRate;
            return this;
        }
        public String getAudioSendBitRate() {
            return this.audioSendBitRate;
        }

        public GetUserMetricDataResponseBodyMetricDataList setCameraRecvBitRate(String cameraRecvBitRate) {
            this.cameraRecvBitRate = cameraRecvBitRate;
            return this;
        }
        public String getCameraRecvBitRate() {
            return this.cameraRecvBitRate;
        }

        public GetUserMetricDataResponseBodyMetricDataList setCameraRecvFrame(String cameraRecvFrame) {
            this.cameraRecvFrame = cameraRecvFrame;
            return this;
        }
        public String getCameraRecvFrame() {
            return this.cameraRecvFrame;
        }

        public GetUserMetricDataResponseBodyMetricDataList setCameraRecvResolutionActual(String cameraRecvResolutionActual) {
            this.cameraRecvResolutionActual = cameraRecvResolutionActual;
            return this;
        }
        public String getCameraRecvResolutionActual() {
            return this.cameraRecvResolutionActual;
        }

        public GetUserMetricDataResponseBodyMetricDataList setCameraSendBitRate(String cameraSendBitRate) {
            this.cameraSendBitRate = cameraSendBitRate;
            return this;
        }
        public String getCameraSendBitRate() {
            return this.cameraSendBitRate;
        }

        public GetUserMetricDataResponseBodyMetricDataList setCameraSendFrame(String cameraSendFrame) {
            this.cameraSendFrame = cameraSendFrame;
            return this;
        }
        public String getCameraSendFrame() {
            return this.cameraSendFrame;
        }

        public GetUserMetricDataResponseBodyMetricDataList setCameraSendResolutionActual(String cameraSendResolutionActual) {
            this.cameraSendResolutionActual = cameraSendResolutionActual;
            return this;
        }
        public String getCameraSendResolutionActual() {
            return this.cameraSendResolutionActual;
        }

        public GetUserMetricDataResponseBodyMetricDataList setLostRate(String lostRate) {
            this.lostRate = lostRate;
            return this;
        }
        public String getLostRate() {
            return this.lostRate;
        }

        public GetUserMetricDataResponseBodyMetricDataList setRecvBitRate(String recvBitRate) {
            this.recvBitRate = recvBitRate;
            return this;
        }
        public String getRecvBitRate() {
            return this.recvBitRate;
        }

        public GetUserMetricDataResponseBodyMetricDataList setRoundTripTime(String roundTripTime) {
            this.roundTripTime = roundTripTime;
            return this;
        }
        public String getRoundTripTime() {
            return this.roundTripTime;
        }

        public GetUserMetricDataResponseBodyMetricDataList setScreenRecvBitRate(String screenRecvBitRate) {
            this.screenRecvBitRate = screenRecvBitRate;
            return this;
        }
        public String getScreenRecvBitRate() {
            return this.screenRecvBitRate;
        }

        public GetUserMetricDataResponseBodyMetricDataList setScreenRecvFrame(String screenRecvFrame) {
            this.screenRecvFrame = screenRecvFrame;
            return this;
        }
        public String getScreenRecvFrame() {
            return this.screenRecvFrame;
        }

        public GetUserMetricDataResponseBodyMetricDataList setScreenRecvResolutionActual(String screenRecvResolutionActual) {
            this.screenRecvResolutionActual = screenRecvResolutionActual;
            return this;
        }
        public String getScreenRecvResolutionActual() {
            return this.screenRecvResolutionActual;
        }

        public GetUserMetricDataResponseBodyMetricDataList setScreenSendBitRate(String screenSendBitRate) {
            this.screenSendBitRate = screenSendBitRate;
            return this;
        }
        public String getScreenSendBitRate() {
            return this.screenSendBitRate;
        }

        public GetUserMetricDataResponseBodyMetricDataList setScreenSendFrame(String screenSendFrame) {
            this.screenSendFrame = screenSendFrame;
            return this;
        }
        public String getScreenSendFrame() {
            return this.screenSendFrame;
        }

        public GetUserMetricDataResponseBodyMetricDataList setScreenSendResolutionActual(String screenSendResolutionActual) {
            this.screenSendResolutionActual = screenSendResolutionActual;
            return this;
        }
        public String getScreenSendResolutionActual() {
            return this.screenSendResolutionActual;
        }

        public GetUserMetricDataResponseBodyMetricDataList setSendBitRate(String sendBitRate) {
            this.sendBitRate = sendBitRate;
            return this;
        }
        public String getSendBitRate() {
            return this.sendBitRate;
        }

        public GetUserMetricDataResponseBodyMetricDataList setTimestamp(Long timestamp) {
            this.timestamp = timestamp;
            return this;
        }
        public Long getTimestamp() {
            return this.timestamp;
        }

    }

}
