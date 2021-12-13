// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class RegisterDeviceRequest extends TeaModel {
    // 钉钉组织id
    @NameInMap("corpId")
    public String corpId;

    // 设备id
    @NameInMap("id")
    public String id;

    // 设备名称
    @NameInMap("deviceName")
    public String deviceName;

    // 设备昵称
    @NameInMap("nickName")
    public String nickName;

    // 设备地址
    @NameInMap("location")
    public String location;

    // 设备状态 0:在线 1:离线
    @NameInMap("deviceStatus")
    public Integer deviceStatus;

    // 设备类型
    @NameInMap("deviceType")
    public String deviceType;

    // 设备类型名称
    @NameInMap("deviceTypeName")
    public String deviceTypeName;

    // 设备父节点id
    @NameInMap("parentId")
    public String parentId;

    // 设备类型 摄像头:CAMERA 其它:OTHERS
    @NameInMap("productType")
    public String productType;

    // 视频流地址
    @NameInMap("liveUrl")
    public String liveUrl;

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

    public RegisterDeviceRequest setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public RegisterDeviceRequest setDeviceName(String deviceName) {
        this.deviceName = deviceName;
        return this;
    }
    public String getDeviceName() {
        return this.deviceName;
    }

    public RegisterDeviceRequest setNickName(String nickName) {
        this.nickName = nickName;
        return this;
    }
    public String getNickName() {
        return this.nickName;
    }

    public RegisterDeviceRequest setLocation(String location) {
        this.location = location;
        return this;
    }
    public String getLocation() {
        return this.location;
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

    public RegisterDeviceRequest setLiveUrl(String liveUrl) {
        this.liveUrl = liveUrl;
        return this;
    }
    public String getLiveUrl() {
        return this.liveUrl;
    }

}
