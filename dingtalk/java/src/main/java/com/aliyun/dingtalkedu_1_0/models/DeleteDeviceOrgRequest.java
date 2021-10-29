// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteDeviceOrgRequest extends TeaModel {
    @NameInMap("deviceCode")
    public String deviceCode;

    @NameInMap("authCode")
    public String authCode;

    public static DeleteDeviceOrgRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteDeviceOrgRequest self = new DeleteDeviceOrgRequest();
        return TeaModel.build(map, self);
    }

    public DeleteDeviceOrgRequest setDeviceCode(String deviceCode) {
        this.deviceCode = deviceCode;
        return this;
    }
    public String getDeviceCode() {
        return this.deviceCode;
    }

    public DeleteDeviceOrgRequest setAuthCode(String authCode) {
        this.authCode = authCode;
        return this;
    }
    public String getAuthCode() {
        return this.authCode;
    }

}
