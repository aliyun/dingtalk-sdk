// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateStorageModeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public UpdateStorageModeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateStorageModeResponse setBody(UpdateStorageModeResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateStorageModeResponseBody getBody() {
        return this.body;
    }

}
