// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateDeptSettngTailFirstResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static UpdateDeptSettngTailFirstResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateDeptSettngTailFirstResponse self = new UpdateDeptSettngTailFirstResponse();
        return TeaModel.build(map, self);
    }

    public UpdateDeptSettngTailFirstResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
