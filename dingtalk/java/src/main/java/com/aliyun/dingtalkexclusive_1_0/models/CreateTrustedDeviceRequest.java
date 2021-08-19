// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CreateTrustedDeviceRequest extends TeaModel {
    // 员工userId
    @NameInMap("userId")
    public String userId;

    // 平台类型
    @NameInMap("platform")
    public String platform;

    // mac地址
    @NameInMap("macAddress")
    public String macAddress;

    // 设备状态
    @NameInMap("status")
    public Integer status;

    public static CreateTrustedDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTrustedDeviceRequest self = new CreateTrustedDeviceRequest();
        return TeaModel.build(map, self);
    }

    public CreateTrustedDeviceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public CreateTrustedDeviceRequest setPlatform(String platform) {
        this.platform = platform;
        return this;
    }
    public String getPlatform() {
        return this.platform;
    }

    public CreateTrustedDeviceRequest setMacAddress(String macAddress) {
        this.macAddress = macAddress;
        return this;
    }
    public String getMacAddress() {
        return this.macAddress;
    }

    public CreateTrustedDeviceRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
