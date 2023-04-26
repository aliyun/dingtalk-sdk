// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CreateTrustedDeviceBatchRequest extends TeaModel {
    @NameInMap("macAddressList")
    public java.util.List<String> macAddressList;

    @NameInMap("platform")
    public String platform;

    @NameInMap("userId")
    public String userId;

    public static CreateTrustedDeviceBatchRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTrustedDeviceBatchRequest self = new CreateTrustedDeviceBatchRequest();
        return TeaModel.build(map, self);
    }

    public CreateTrustedDeviceBatchRequest setMacAddressList(java.util.List<String> macAddressList) {
        this.macAddressList = macAddressList;
        return this;
    }
    public java.util.List<String> getMacAddressList() {
        return this.macAddressList;
    }

    public CreateTrustedDeviceBatchRequest setPlatform(String platform) {
        this.platform = platform;
        return this;
    }
    public String getPlatform() {
        return this.platform;
    }

    public CreateTrustedDeviceBatchRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
