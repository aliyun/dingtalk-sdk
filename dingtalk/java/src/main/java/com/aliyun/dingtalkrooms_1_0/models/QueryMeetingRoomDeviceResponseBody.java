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
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("deviceId")
        public String deviceId;

        @NameInMap("deviceMac")
        public String deviceMac;

        @NameInMap("deviceModel")
        public String deviceModel;

        @NameInMap("deviceName")
        public String deviceName;

        @NameInMap("deviceServiceId")
        public Integer deviceServiceId;

        @NameInMap("deviceSn")
        public String deviceSn;

        @NameInMap("deviceStatus")
        public String deviceStatus;

        @NameInMap("deviceType")
        public String deviceType;

        @NameInMap("deviceUnionId")
        public String deviceUnionId;

        @NameInMap("openRoomId")
        public String openRoomId;

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
        @NameInMap("activeTime")
        public Long activeTime;

        @NameInMap("controllers")
        public java.util.List<QueryMeetingRoomDeviceResponseBodyResultControllers> controllers;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("creatorUnionId")
        public String creatorUnionId;

        @NameInMap("devCamera")
        public String devCamera;

        @NameInMap("devHdmi")
        public String devHdmi;

        @NameInMap("devMic")
        public String devMic;

        @NameInMap("devMirror")
        public String devMirror;

        @NameInMap("devNetIp")
        public String devNetIp;

        @NameInMap("devNetType")
        public String devNetType;

        @NameInMap("devVoice")
        public String devVoice;

        @NameInMap("devWifiMac")
        public String devWifiMac;

        @NameInMap("devWireMac")
        public String devWireMac;

        @NameInMap("deviceId")
        public String deviceId;

        @NameInMap("deviceMac")
        public String deviceMac;

        @NameInMap("deviceModel")
        public String deviceModel;

        @NameInMap("deviceName")
        public String deviceName;

        @NameInMap("deviceServiceId")
        public Integer deviceServiceId;

        @NameInMap("deviceSn")
        public String deviceSn;

        @NameInMap("deviceStatus")
        public String deviceStatus;

        @NameInMap("deviceType")
        public String deviceType;

        @NameInMap("deviceUnionId")
        public String deviceUnionId;

        @NameInMap("firmwareVersion")
        public String firmwareVersion;

        @NameInMap("openRoomId")
        public String openRoomId;

        @NameInMap("roomName")
        public String roomName;

        @NameInMap("shareCode")
        public String shareCode;

        @NameInMap("sipAccountName")
        public String sipAccountName;

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
