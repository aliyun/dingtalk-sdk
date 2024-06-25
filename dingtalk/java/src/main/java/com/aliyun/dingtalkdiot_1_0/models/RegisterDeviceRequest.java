// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class RegisterDeviceRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ding123</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>摄像头1</p>
     */
    @NameInMap("deviceName")
    public String deviceName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("deviceStatus")
    public Integer deviceStatus;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>Camera</p>
     */
    @NameInMap("deviceType")
    public String deviceType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>摄像头</p>
     */
    @NameInMap("deviceTypeName")
    public String deviceTypeName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>002</p>
     */
    @NameInMap("id")
    public String id;

    @NameInMap("liveUrls")
    public RegisterDeviceRequestLiveUrls liveUrls;

    /**
     * <strong>example:</strong>
     * <p>东南门</p>
     */
    @NameInMap("location")
    public String location;

    /**
     * <strong>example:</strong>
     * <p>摄像头1</p>
     */
    @NameInMap("nickName")
    public String nickName;

    /**
     * <strong>example:</strong>
     * <p>001</p>
     */
    @NameInMap("parentId")
    public String parentId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>CAMERA</p>
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
         * <strong>example:</strong>
         * <p><a href="https://abc.stream.flv">https://abc.stream.flv</a></p>
         */
        @NameInMap("flv")
        public String flv;

        /**
         * <strong>example:</strong>
         * <p><a href="https://abc.stream.m3u8">https://abc.stream.m3u8</a></p>
         */
        @NameInMap("hls")
        public String hls;

        /**
         * <strong>example:</strong>
         * <p>rtmp://abc.stream</p>
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
