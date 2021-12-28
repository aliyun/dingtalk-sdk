// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateDeviceRequest extends TeaModel {
    // 钉钉物联组织ID, 第三方平台必填，企业内部系统忽略。
    @NameInMap("corpId")
    public String corpId;

    // 设备列表。
    @NameInMap("devices")
    public java.util.List<BatchUpdateDeviceRequestDevices> devices;

    public static BatchUpdateDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateDeviceRequest self = new BatchUpdateDeviceRequest();
        return TeaModel.build(map, self);
    }

    public BatchUpdateDeviceRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public BatchUpdateDeviceRequest setDevices(java.util.List<BatchUpdateDeviceRequestDevices> devices) {
        this.devices = devices;
        return this;
    }
    public java.util.List<BatchUpdateDeviceRequestDevices> getDevices() {
        return this.devices;
    }

    public static class BatchUpdateDeviceRequestDevices extends TeaModel {
        // 设备ID。
        @NameInMap("deviceId")
        public String deviceId;

        // 设备名称。
        @NameInMap("deviceName")
        public String deviceName;

        // 设备地址。
        @NameInMap("location")
        public String location;

        // 设备状态 0:在线 1:离线
        @NameInMap("deviceStatus")
        public Integer deviceStatus;

        // 视频流地址直播流地址，支持rtmp、flv、hls等格式，需要https协议。
        @NameInMap("liveUrl")
        public String liveUrl;

        // 第三方平台定制参数，企业内部系统忽略。
        @NameInMap("extraData")
        public java.util.Map<String, ?> extraData;

        public static BatchUpdateDeviceRequestDevices build(java.util.Map<String, ?> map) throws Exception {
            BatchUpdateDeviceRequestDevices self = new BatchUpdateDeviceRequestDevices();
            return TeaModel.build(map, self);
        }

        public BatchUpdateDeviceRequestDevices setDeviceId(String deviceId) {
            this.deviceId = deviceId;
            return this;
        }
        public String getDeviceId() {
            return this.deviceId;
        }

        public BatchUpdateDeviceRequestDevices setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public BatchUpdateDeviceRequestDevices setLocation(String location) {
            this.location = location;
            return this;
        }
        public String getLocation() {
            return this.location;
        }

        public BatchUpdateDeviceRequestDevices setDeviceStatus(Integer deviceStatus) {
            this.deviceStatus = deviceStatus;
            return this;
        }
        public Integer getDeviceStatus() {
            return this.deviceStatus;
        }

        public BatchUpdateDeviceRequestDevices setLiveUrl(String liveUrl) {
            this.liveUrl = liveUrl;
            return this;
        }
        public String getLiveUrl() {
            return this.liveUrl;
        }

        public BatchUpdateDeviceRequestDevices setExtraData(java.util.Map<String, ?> extraData) {
            this.extraData = extraData;
            return this;
        }
        public java.util.Map<String, ?> getExtraData() {
            return this.extraData;
        }

    }

}
