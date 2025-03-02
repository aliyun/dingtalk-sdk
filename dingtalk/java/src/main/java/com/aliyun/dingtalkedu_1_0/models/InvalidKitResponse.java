// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InvalidKitResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InvalidKitResponseBody body;

    public static InvalidKitResponse build(java.util.Map<String, ?> map) throws Exception {
        InvalidKitResponse self = new InvalidKitResponse();
        return TeaModel.build(map, self);
    }

    public InvalidKitResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InvalidKitResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InvalidKitResponse setBody(InvalidKitResponseBody body) {
        this.body = body;
        return this;
    }
    public InvalidKitResponseBody getBody() {
        return this.body;
    }

}
