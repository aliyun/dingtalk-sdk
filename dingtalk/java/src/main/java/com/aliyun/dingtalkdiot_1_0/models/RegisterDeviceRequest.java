// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class RegisterDeviceRequest extends TeaModel {
    // 钉钉组织id
    @NameInMap("corpId")
    public String corpId;

    // 设备名称
    @NameInMap("deviceName")
    public String deviceName;

    // 设备状态 0:在线 1:离线
    @NameInMap("deviceStatus")
    public Integer deviceStatus;

    // 设备类型
    @NameInMap("deviceType")
    public String deviceType;

    // 设备类型名称
    @NameInMap("deviceTypeName")
    public String deviceTypeName;

    // 设备id
    @NameInMap("id")
    public String id;

    // 视频流地址直播流地址，支持rtmp、flv、hls等格式，需要https协议。
    @NameInMap("liveUrls")
    public RegisterDeviceRequestLiveUrls liveUrls;

    // 设备地址
    @NameInMap("location")
    public String location;

    // 设备昵称
    @NameInMap("nickName")
    public String nickName;

    // 设备父节点id
    @NameInMap("parentId")
    public String parentId;

    // 设备类型 摄像头:CAMERA 其它:OTHERS
    @NameInMap("productType")
    public String productType;

    public static RegisterDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        RegisterDeviceRequest self = new RegisterDeviceRequest();
        return TeaModel.build(map, self);
    }

    public RegisterDeviceRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public RegisterDeviceRequest setDeviceName(String deviceName) {
        this.deviceName = deviceName;
        return this;
    }
    public String getDeviceName() {
        return this.deviceName;
    }

    public RegisterDeviceRequest setDeviceStatus(Integer deviceStatus) {
        this.deviceStatus = deviceStatus;
        return this;
    }
    public Integer getDeviceStatus() {
        return this.deviceStatus;
    }

    public RegisterDeviceRequest setDeviceType(String deviceType) {
        this.deviceType = deviceType;
        return this;
    }
    public String getDeviceType() {
        return this.deviceType;
    }

    public RegisterDeviceRequest setDeviceTypeName(String deviceTypeName) {
        this.deviceTypeName = deviceTypeName;
        return this;
    }
    public String getDeviceTypeName() {
        return this.deviceTypeName;
    }

    public RegisterDeviceRequest setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public RegisterDeviceRequest setLiveUrls(RegisterDeviceRequestLiveUrls liveUrls) {
        this.liveUrls = liveUrls;
        return this;
    }
    public RegisterDeviceRequestLiveUrls getLiveUrls() {
        return this.liveUrls;
    }

    public RegisterDeviceRequest setLocation(String location) {
        this.location = location;
        return this;
    }
    public String getLocation() {
        return this.location;
    }

    public RegisterDeviceRequest setNickName(String nickName) {
        this.nickName = nickName;
        return this;
    }
    public String getNickName() {
        return this.nickName;
    }

    public RegisterDeviceRequest setParentId(String parentId) {
        this.parentId = parentId;
        return this;
    }
    public String getParentId() {
        return this.parentId;
    }

    public RegisterDeviceRequest setProductType(String productType) {
        this.productType = productType;
        return this;
    }
    public String getProductType() {
        return this.productType;
    }

    public static class BatchRegisterDeviceRequestDevicesLiveUrls extends TeaModel {
        // flv格式视频流地址
        @NameInMap("flv")
        public String flv;

        // hls格式视频流地址
        @NameInMap("hls")
        public String hls;

        // rtmp格式视频流地址
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
        // 设备ID。
        @NameInMap("deviceId")
        public String deviceId;

        // 设备名称。
        @NameInMap("deviceName")
        public String deviceName;

        // 设备状态  0:在线  1:离线
        @NameInMap("deviceStatus")
        public Integer deviceStatus;

        // 设备类型，自定义传入，最多128个字节。
        @NameInMap("deviceType")
        public String deviceType;

        // 设备类型名称，自定义传入，最多128个字节，与deviceType一一对应。
        @NameInMap("deviceTypeName")
        public String deviceTypeName;

        // 第三方平台定制参数，企业内部系统忽略。
        @NameInMap("extraData")
        public java.util.Map<String, ?> extraData;

        // 视频流地址直播流地址，支持rtmp、flv、hls等格式，需要https协议。
        @NameInMap("liveUrls")
        public BatchRegisterDeviceRequestDevicesLiveUrls liveUrls;

        // 设备地址。
        @NameInMap("location")
        public String location;

        // 父设备ID。
        @NameInMap("parentId")
        public String parentId;

        // 产品类型 CAMERA：摄像头，可看直播 OTHERS：非摄像头
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

    public static class RegisterDeviceRequestLiveUrls extends TeaModel {
        // flv格式视频流
        @NameInMap("flv")
        public String flv;

        // hls格式视频流地址
        @NameInMap("hls")
        public String hls;

        // rtmp格式视频流
        @NameInMap("rtmp")
        public String rtmp;

        public static RegisterDeviceRequestLiveUrls build(java.util.Map<String, ?> map) throws Exception {
            RegisterDeviceRequestLiveUrls self = new RegisterDeviceRequestLiveUrls();
            return TeaModel.build(map, self);
        }

        public RegisterDeviceRequestLiveUrls setFlv(String flv) {
            this.flv = flv;
            return this;
        }
        public String getFlv() {
            return this.flv;
        }

        public RegisterDeviceRequestLiveUrls setHls(String hls) {
            this.hls = hls;
            return this;
        }
        public String getHls() {
            return this.hls;
        }

        public RegisterDeviceRequestLiveUrls setRtmp(String rtmp) {
            this.rtmp = rtmp;
            return this;
        }
        public String getRtmp() {
            return this.rtmp;
        }

    }

}
