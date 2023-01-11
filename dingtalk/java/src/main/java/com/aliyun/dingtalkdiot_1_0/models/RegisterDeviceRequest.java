// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class RegisterDeviceRequest extends TeaModel {
    /**
     * <p>钉钉物联组织ID, 第三方平台必填，企业内部系统忽略</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>设备名称</p>
     */
    @NameInMap("deviceName")
    public String deviceName;

    /**
     * <p>设备状态 0:在线 1:离线</p>
     */
    @NameInMap("deviceStatus")
    public Integer deviceStatus;

    /**
     * <p>设备类型</p>
     */
    @NameInMap("deviceType")
    public String deviceType;

    /**
     * <p>设备类型名称</p>
     */
    @NameInMap("deviceTypeName")
    public String deviceTypeName;

    /**
     * <p>设备id</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <p>视频流地址直播流地址，支持rtmp、flv、hls等格式，需要https协议。</p>
     */
    @NameInMap("liveUrls")
    public RegisterDeviceRequestLiveUrls liveUrls;

    /**
     * <p>设备地址</p>
     */
    @NameInMap("location")
    public String location;

    /**
     * <p>设备昵称</p>
     */
    @NameInMap("nickName")
    public String nickName;

    /**
     * <p>设备父节点id</p>
     */
    @NameInMap("parentId")
    public String parentId;

    /**
     * <p>设备类型 摄像头:CAMERA 其它:OTHERS</p>
     */
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

    public static class RegisterDeviceRequestLiveUrls extends TeaModel {
        /**
         * <p>flv格式视频流</p>
         */
        @NameInMap("flv")
        public String flv;

        /**
         * <p>hls格式视频流地址</p>
         */
        @NameInMap("hls")
        public String hls;

        /**
         * <p>rtmp格式视频流</p>
         */
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
