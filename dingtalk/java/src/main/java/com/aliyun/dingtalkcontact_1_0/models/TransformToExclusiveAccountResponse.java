// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TransformToExclusiveAccountResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static TransformToExclusiveAccountResponse build(java.util.Map<String, ?> map) throws Exception {
        TransformToExclusiveAccountResponse self = new TransformToExclusiveAccountResponse();
        return TeaModel.build(map, self);
    }

    public TransformToExclusiveAccountResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
