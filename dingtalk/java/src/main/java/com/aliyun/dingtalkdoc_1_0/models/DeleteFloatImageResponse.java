// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteFloatImageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteFloatImageResponseBody body;

    public static DeleteFloatImageResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteFloatImageResponse self = new DeleteFloatImageResponse();
        return TeaModel.build(map, self);
    }

    public DeleteFloatImageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteFloatImageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteFloatImageResponse setBody(DeleteFloatImageResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteFloatImageResponseBody getBody() {
        return this.body;
    }

}
