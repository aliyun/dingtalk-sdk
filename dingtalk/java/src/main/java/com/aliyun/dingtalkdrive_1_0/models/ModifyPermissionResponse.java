// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ModifyPermissionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static ModifyPermissionResponse build(java.util.Map<String, ?> map) throws Exception {
        ModifyPermissionResponse self = new ModifyPermissionResponse();
        return TeaModel.build(map, self);
    }

    public ModifyPermissionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
