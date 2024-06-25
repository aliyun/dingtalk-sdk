// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomDeviceResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryMeetingRoomDeviceResponseBodyResult result;

    public static QueryMeetingRoomDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMeetingRoomDeviceResponseBody self = new QueryMeetingRoomDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMeetingRoomDeviceResponseBody setResult(QueryMeetingRoomDeviceResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryMeetingRoomDeviceResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryMeetingRoomDeviceResponseBodyResultControllers extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>&quot;ding994a046bca84545935c2f4657eb6378f&quot;</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>2345</p>
         */
        @NameInMap("deviceId")
        public String deviceId;

        /**
         * <strong>example:</strong>
         * <p>&quot;d8:2f:e6:d9:ab:5b&quot;</p>
         */
        @NameInMap("deviceMac")
        public String deviceMac;

        /**
         * <strong>example:</strong>
         * <p>&quot;AILABS_S3_T1&quot;</p>
         */
        @NameInMap("deviceModel")
        public String deviceModel;

        /**
         * <strong>example:</strong>
         * <p>会控平板_xxxx</p>
         */
        @NameInMap("deviceName")
        public String deviceName;

        /**
         * <strong>example:</strong>
         * <p>1190</p>
         */
        @NameInMap("deviceServiceId")
        public Integer deviceServiceId;

        /**
         * <strong>example:</strong>
         * <p>&quot;02caa8169c80f74a2d375093a6107017&quot;</p>
         */
        @NameInMap("deviceSn")
        public String deviceSn;

        /**
         * <strong>example:</strong>
         * <p>空闲：idle  投屏中：projection   会议响铃中：conf_incoming   会议中：conf_running   使用白板中：white_board   离线: offline</p>
         */
        @NameInMap("deviceStatus")
        public String deviceStatus;

        /**
         * <strong>example:</strong>
         * <p>视频会议设备:&quot;touyingyi&quot;   设备控制器:&quot;meetingaccessory&quot;</p>
         */
        @NameInMap("deviceType")
        public String deviceType;

        /**
         * <strong>example:</strong>
         * <p>&quot;lmvUrRkpboRrSMtgsiS9V4AiEiE&quot;</p>
         */
        @NameInMap("deviceUnionId")
        public String deviceUnionId;

        /**
         * <strong>example:</strong>
         * <p>&quot;7263defed6b361fedf0fe6a3b578b96e808b09d6ca6282ed&quot;</p>
         */
        @NameInMap("openRoomId")
        public String openRoomId;

        /**
         * <strong>example:</strong>
         * <p>234567</p>
         */
        @NameInMap("shareCode")
        public String shareCode;

        public static QueryMeetingRoomDeviceResponseBodyResultControllers build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomDeviceResponseBodyResultControllers self = new QueryMeetingRoomDeviceResponseBodyResultControllers();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setDeviceId(String deviceId) {
            this.deviceId = deviceId;
            return this;
        }
        public String getDeviceId() {
            return this.deviceId;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setDeviceMac(String deviceMac) {
            this.deviceMac = deviceMac;
            return this;
        }
        public String getDeviceMac() {
            return this.deviceMac;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setDeviceModel(String deviceModel) {
            this.deviceModel = deviceModel;
            return this;
        }
        public String getDeviceModel() {
            return this.deviceModel;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setDeviceServiceId(Integer deviceServiceId) {
            this.deviceServiceId = deviceServiceId;
            return this;
        }
        public Integer getDeviceServiceId() {
            return this.deviceServiceId;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setDeviceSn(String deviceSn) {
            this.deviceSn = deviceSn;
            return this;
        }
        public String getDeviceSn() {
            return this.deviceSn;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setDeviceStatus(String deviceStatus) {
            this.deviceStatus = deviceStatus;
            return this;
        }
        public String getDeviceStatus() {
            return this.deviceStatus;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setDeviceType(String deviceType) {
            this.deviceType = deviceType;
            return this;
        }
        public String getDeviceType() {
            return this.deviceType;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setDeviceUnionId(String deviceUnionId) {
            this.deviceUnionId = deviceUnionId;
            return this;
        }
        public String getDeviceUnionId() {
            return this.deviceUnionId;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setOpenRoomId(String openRoomId) {
            this.openRoomId = openRoomId;
            return this;
        }
        public String getOpenRoomId() {
            return this.openRoomId;
        }

        public QueryMeetingRoomDeviceResponseBodyResultControllers setShareCode(String shareCode) {
            this.shareCode = shareCode;
            return this;
        }
        public String getShareCode() {
            return this.shareCode;
        }

    }

    public static class QueryMeetingRoomDeviceResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1697198045000</p>
         */
        @NameInMap("activeTime")
        public Long activeTime;

        @NameInMap("controllers")
        public java.util.List<QueryMeetingRoomDeviceResponseBodyResultControllers> controllers;

        /**
         * <strong>example:</strong>
         * <p>&quot;ding994a046bca84545935c2f4657eb6378f&quot;</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>lPHhSZDLXXXXXXpBlC9lxLwiEiE</p>
         */
        @NameInMap("creatorUnionId")
        public String creatorUnionId;

        /**
         * <strong>example:</strong>
         * <p>Smart Camera</p>
         */
        @NameInMap("devCamera")
        public String devCamera;

        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("devHdmi")
        public String devHdmi;

        /**
         * <strong>example:</strong>
         * <p>Microphone (2- Built-in Audio)</p>
         */
        @NameInMap("devMic")
        public String devMic;

        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("devMirror")
        public String devMirror;

        /**
         * <strong>example:</strong>
         * <p>127.0.0.10</p>
         */
        @NameInMap("devNetIp")
        public String devNetIp;

        /**
         * <strong>example:</strong>
         * <p>net_wired</p>
         */
        @NameInMap("devNetType")
        public String devNetType;

        /**
         * <strong>example:</strong>
         * <p>Speaker (2- Built-in Audio)</p>
         */
        @NameInMap("devVoice")
        public String devVoice;

        /**
         * <strong>example:</strong>
         * <p>d4:aa:ee:e8:4d:55</p>
         */
        @NameInMap("devWifiMac")
        public String devWifiMac;

        /**
         * <strong>example:</strong>
         * <p>d4:3a:ee:aa:45:85</p>
         */
        @NameInMap("devWireMac")
        public String devWireMac;

        /**
         * <strong>example:</strong>
         * <p>1234</p>
         */
        @NameInMap("deviceId")
        public String deviceId;

        /**
         * <strong>example:</strong>
         * <p>&quot;14:85:7f:e5:f3:f3&quot;</p>
         */
        @NameInMap("deviceMac")
        public String deviceMac;

        /**
         * <strong>example:</strong>
         * <p>winbox</p>
         */
        @NameInMap("deviceModel")
        public String deviceModel;

        /**
         * <strong>example:</strong>
         * <p>钉钉会议设备_xxxx</p>
         */
        @NameInMap("deviceName")
        public String deviceName;

        /**
         * <strong>example:</strong>
         * <p>1204</p>
         */
        @NameInMap("deviceServiceId")
        public Integer deviceServiceId;

        /**
         * <strong>example:</strong>
         * <p>&quot;02caa8169c80f74a2d375093a6107016&quot;</p>
         */
        @NameInMap("deviceSn")
        public String deviceSn;

        /**
         * <strong>example:</strong>
         * <p>空闲：idle  投屏中：projection   会议响铃中：conf_incoming   会议中：conf_running   使用白板中：white_board   离线: offline</p>
         */
        @NameInMap("deviceStatus")
        public String deviceStatus;

        /**
         * <strong>example:</strong>
         * <p>视频会议设备:&quot;touyingyi&quot;   设备控制器:&quot;meetingaccessory&quot;</p>
         */
        @NameInMap("deviceType")
        public String deviceType;

        /**
         * <strong>example:</strong>
         * <p>&quot;lmvUrRkpboRrSMtgsiS9V3AiEiE&quot;</p>
         */
        @NameInMap("deviceUnionId")
        public String deviceUnionId;

        /**
         * <strong>example:</strong>
         * <p>LMVXXX.20XX0818</p>
         */
        @NameInMap("firmwareVersion")
        public String firmwareVersion;

        /**
         * <strong>example:</strong>
         * <p>&quot;7263defed6b361fedf0fe6a3b578b96e808b09d6ca6282ed&quot;</p>
         */
        @NameInMap("openRoomId")
        public String openRoomId;

        /**
         * <strong>example:</strong>
         * <p>测试会议室</p>
         */
        @NameInMap("roomName")
        public String roomName;

        /**
         * <strong>example:</strong>
         * <p>123456</p>
         */
        @NameInMap("shareCode")
        public String shareCode;

        /**
         * <strong>example:</strong>
         * <p>sip13492</p>
         */
        @NameInMap("sipAccountName")
        public String sipAccountName;

        /**
         * <strong>example:</strong>
         * <p>7.14.1</p>
         */
        @NameInMap("softwareVersion")
        public String softwareVersion;

        public static QueryMeetingRoomDeviceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryMeetingRoomDeviceResponseBodyResult self = new QueryMeetingRoomDeviceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryMeetingRoomDeviceResponseBodyResult setActiveTime(Long activeTime) {
            this.activeTime = activeTime;
            return this;
        }
        public Long getActiveTime() {
            return this.activeTime;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setControllers(java.util.List<QueryMeetingRoomDeviceResponseBodyResultControllers> controllers) {
            this.controllers = controllers;
            return this;
        }
        public java.util.List<QueryMeetingRoomDeviceResponseBodyResultControllers> getControllers() {
            return this.controllers;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setCreatorUnionId(String creatorUnionId) {
            this.creatorUnionId = creatorUnionId;
            return this;
        }
        public String getCreatorUnionId() {
            return this.creatorUnionId;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDevCamera(String devCamera) {
            this.devCamera = devCamera;
            return this;
        }
        public String getDevCamera() {
            return this.devCamera;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDevHdmi(String devHdmi) {
            this.devHdmi = devHdmi;
            return this;
        }
        public String getDevHdmi() {
            return this.devHdmi;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDevMic(String devMic) {
            this.devMic = devMic;
            return this;
        }
        public String getDevMic() {
            return this.devMic;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDevMirror(String devMirror) {
            this.devMirror = devMirror;
            return this;
        }
        public String getDevMirror() {
            return this.devMirror;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDevNetIp(String devNetIp) {
            this.devNetIp = devNetIp;
            return this;
        }
        public String getDevNetIp() {
            return this.devNetIp;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDevNetType(String devNetType) {
            this.devNetType = devNetType;
            return this;
        }
        public String getDevNetType() {
            return this.devNetType;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDevVoice(String devVoice) {
            this.devVoice = devVoice;
            return this;
        }
        public String getDevVoice() {
            return this.devVoice;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDevWifiMac(String devWifiMac) {
            this.devWifiMac = devWifiMac;
            return this;
        }
        public String getDevWifiMac() {
            return this.devWifiMac;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDevWireMac(String devWireMac) {
            this.devWireMac = devWireMac;
            return this;
        }
        public String getDevWireMac() {
            return this.devWireMac;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDeviceId(String deviceId) {
            this.deviceId = deviceId;
            return this;
        }
        public String getDeviceId() {
            return this.deviceId;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDeviceMac(String deviceMac) {
            this.deviceMac = deviceMac;
            return this;
        }
        public String getDeviceMac() {
            return this.deviceMac;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDeviceModel(String deviceModel) {
            this.deviceModel = deviceModel;
            return this;
        }
        public String getDeviceModel() {
            return this.deviceModel;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDeviceServiceId(Integer deviceServiceId) {
            this.deviceServiceId = deviceServiceId;
            return this;
        }
        public Integer getDeviceServiceId() {
            return this.deviceServiceId;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDeviceSn(String deviceSn) {
            this.deviceSn = deviceSn;
            return this;
        }
        public String getDeviceSn() {
            return this.deviceSn;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDeviceStatus(String deviceStatus) {
            this.deviceStatus = deviceStatus;
            return this;
        }
        public String getDeviceStatus() {
            return this.deviceStatus;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDeviceType(String deviceType) {
            this.deviceType = deviceType;
            return this;
        }
        public String getDeviceType() {
            return this.deviceType;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setDeviceUnionId(String deviceUnionId) {
            this.deviceUnionId = deviceUnionId;
            return this;
        }
        public String getDeviceUnionId() {
            return this.deviceUnionId;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setFirmwareVersion(String firmwareVersion) {
            this.firmwareVersion = firmwareVersion;
            return this;
        }
        public String getFirmwareVersion() {
            return this.firmwareVersion;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setOpenRoomId(String openRoomId) {
            this.openRoomId = openRoomId;
            return this;
        }
        public String getOpenRoomId() {
            return this.openRoomId;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setRoomName(String roomName) {
            this.roomName = roomName;
            return this;
        }
        public String getRoomName() {
            return this.roomName;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setShareCode(String shareCode) {
            this.shareCode = shareCode;
            return this;
        }
        public String getShareCode() {
            return this.shareCode;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setSipAccountName(String sipAccountName) {
            this.sipAccountName = sipAccountName;
            return this;
        }
        public String getSipAccountName() {
            return this.sipAccountName;
        }

        public QueryMeetingRoomDeviceResponseBodyResult setSoftwareVersion(String softwareVersion) {
            this.softwareVersion = softwareVersion;
            return this;
        }
        public String getSoftwareVersion() {
            return this.softwareVersion;
        }

    }

}
