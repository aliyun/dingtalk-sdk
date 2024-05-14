// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CreateTrustedDeviceResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static CreateTrustedDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateTrustedDeviceResponseBody self = new CreateTrustedDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateTrustedDeviceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
