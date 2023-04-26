// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class BatchRegisterDeviceRequest extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("devices")
    public java.util.List<BatchRegisterDeviceRequestDevices> devices;

    public static BatchRegisterDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchRegisterDeviceRequest self = new BatchRegisterDeviceRequest();
        return TeaModel.build(map, self);
    }

    public BatchRegisterDeviceRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public BatchRegisterDeviceRequest setDevices(java.util.List<BatchRegisterDeviceRequestDevices> devices) {
        this.devices = devices;
        return this;
    }
    public java.util.List<BatchRegisterDeviceRequestDevices> getDevices() {
        return this.devices;
    }

    public static class BatchRegisterDeviceRequestDevicesLiveUrls extends TeaModel {
        @NameInMap("flv")
        public String flv;

        @NameInMap("hls")
        public String hls;

        @NameInMap("rtmp")
        public String rtmp;

        public static BatchRegisterDeviceRequestDevicesLiveUrls build(java.util.Map<String, ?> map) throws Exception {
            BatchRegisterDeviceRequestDevicesLiveUrls self = new BatchRegisterDeviceRequestDevicesLiveUrls();
            return TeaModel.build(map, self);
        }

        public BatchRegisterDeviceRequestDevicesLiveUrls setFlv(String flv) {
            this.flv = flv;
            return this;
        }
        public String getFlv() {
            return this.flv;
        }

        public BatchRegisterDeviceRequestDevicesLiveUrls setHls(String hls) {
            this.hls = hls;
            return this;
        }
        public String getHls() {
            return this.hls;
        }

        public BatchRegisterDeviceRequestDevicesLiveUrls setRtmp(String rtmp) {
            this.rtmp = rtmp;
            return this;
        }
        public String getRtmp() {
            return this.rtmp;
        }

    }

    public static class BatchRegisterDeviceRequestDevices extends TeaModel {
        @NameInMap("deviceId")
        public String deviceId;

        @NameInMap("deviceName")
        public String deviceName;

        @NameInMap("deviceStatus")
        public Integer deviceStatus;

        @NameInMap("deviceType")
        public String deviceType;

        @NameInMap("deviceTypeName")
        public String deviceTypeName;

        @NameInMap("extraData")
        public java.util.Map<String, ?> extraData;

        @NameInMap("liveUrls")
        public BatchRegisterDeviceRequestDevicesLiveUrls liveUrls;

        @NameInMap("location")
        public String location;

        @NameInMap("parentId")
        public String parentId;

        @NameInMap("productType")
        public String productType;

        public static BatchRegisterDeviceRequestDevices build(java.util.Map<String, ?> map) throws Exception {
            BatchRegisterDeviceRequestDevices self = new BatchRegisterDeviceRequestDevices();
            return TeaModel.build(map, self);
        }

        public BatchRegisterDeviceRequestDevices setDeviceId(String deviceId) {
            this.deviceId = deviceId;
            return this;
        }
        public String getDeviceId() {
            return this.deviceId;
        }

        public BatchRegisterDeviceRequestDevices setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public BatchRegisterDeviceRequestDevices setDeviceStatus(Integer deviceStatus) {
            this.deviceStatus = deviceStatus;
            return this;
        }
        public Integer getDeviceStatus() {
            return this.deviceStatus;
        }

        public BatchRegisterDeviceRequestDevices setDeviceType(String deviceType) {
            this.deviceType = deviceType;
            return this;
        }
        public String getDeviceType() {
            return this.deviceType;
        }

        public BatchRegisterDeviceRequestDevices setDeviceTypeName(String deviceTypeName) {
            this.deviceTypeName = deviceTypeName;
            return this;
        }
        public String getDeviceTypeName() {
            return this.deviceTypeName;
        }

        public BatchRegisterDeviceRequestDevices setExtraData(java.util.Map<String, ?> extraData) {
            this.extraData = extraData;
            return this;
        }
        public java.util.Map<String, ?> getExtraData() {
            return this.extraData;
        }

        public BatchRegisterDeviceRequestDevices setLiveUrls(BatchRegisterDeviceRequestDevicesLiveUrls liveUrls) {
            this.liveUrls = liveUrls;
            return this;
        }
        public BatchRegisterDeviceRequestDevicesLiveUrls getLiveUrls() {
            return this.liveUrls;
        }

        public BatchRegisterDeviceRequestDevices setLocation(String location) {
            this.location = location;
            return this;
        }
        public String getLocation() {
            return this.location;
        }

        public BatchRegisterDeviceRequestDevices setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

        public BatchRegisterDeviceRequestDevices setProductType(String productType) {
            this.productType = productType;
            return this;
        }
        public String getProductType() {
            return this.productType;
        }

    }

}
