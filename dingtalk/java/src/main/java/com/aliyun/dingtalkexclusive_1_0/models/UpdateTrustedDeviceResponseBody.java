// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateTrustedDeviceResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateTrustedDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateTrustedDeviceResponseBody self = new UpdateTrustedDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateTrustedDeviceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
