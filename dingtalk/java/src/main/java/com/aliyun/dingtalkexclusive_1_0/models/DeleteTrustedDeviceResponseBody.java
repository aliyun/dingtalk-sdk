// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class DeleteTrustedDeviceResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static DeleteTrustedDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteTrustedDeviceResponseBody self = new DeleteTrustedDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteTrustedDeviceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
