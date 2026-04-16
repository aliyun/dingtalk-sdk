// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UpdateFloatImageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateFloatImageResponseBody body;

    public static UpdateFloatImageResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateFloatImageResponse self = new UpdateFloatImageResponse();
        return TeaModel.build(map, self);
    }

    public UpdateFloatImageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateFloatImageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateFloatImageResponse setBody(UpdateFloatImageResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateFloatImageResponseBody getBody() {
        return this.body;
    }

}
