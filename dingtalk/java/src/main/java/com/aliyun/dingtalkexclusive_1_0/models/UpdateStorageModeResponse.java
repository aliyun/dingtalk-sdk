// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateStorageModeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateStorageModeResponseBody body;

    public static UpdateStorageModeResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateStorageModeResponse self = new UpdateStorageModeResponse();
        return TeaModel.build(map, self);
    }

    public UpdateStorageModeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateStorageModeResponse setBody(UpdateStorageModeResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateStorageModeResponseBody getBody() {
        return this.body;
    }

}
