// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CreateTrustedDeviceRequest extends TeaModel {
    @NameInMap("did")
    public String did;

    @NameInMap("macAddress")
    public String macAddress;

    @NameInMap("platform")
    public String platform;

    @NameInMap("status")
    public Integer status;

    @NameInMap("userId")
    public String userId;

    public static CreateTrustedDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTrustedDeviceRequest self = new CreateTrustedDeviceRequest();
        return TeaModel.build(map, self);
    }

    public CreateTrustedDeviceRequest setDid(String did) {
        this.did = did;
        return this;
    }
    public String getDid() {
        return this.did;
    }

    public CreateTrustedDeviceRequest setMacAddress(String macAddress) {
        this.macAddress = macAddress;
        return this;
    }
    public String getMacAddress() {
        return this.macAddress;
    }

    public CreateTrustedDeviceRequest setPlatform(String platform) {
        this.platform = platform;
        return this;
    }
    public String getPlatform() {
        return this.platform;
    }

    public CreateTrustedDeviceRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public CreateTrustedDeviceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
