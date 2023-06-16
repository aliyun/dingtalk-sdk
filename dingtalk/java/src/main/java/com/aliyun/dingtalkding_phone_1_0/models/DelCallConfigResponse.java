// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_phone_1_0.models;

import com.aliyun.tea.*;

public class DelCallConfigResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DelCallConfigResponseBody body;

    public static DelCallConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        DelCallConfigResponse self = new DelCallConfigResponse();
        return TeaModel.build(map, self);
    }

    public DelCallConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DelCallConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DelCallConfigResponse setBody(DelCallConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public DelCallConfigResponseBody getBody() {
        return this.body;
    }

}
