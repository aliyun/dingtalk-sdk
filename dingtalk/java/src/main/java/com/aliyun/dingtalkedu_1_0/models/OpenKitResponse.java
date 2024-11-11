// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class OpenKitResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OpenKitResponseBody body;

    public static OpenKitResponse build(java.util.Map<String, ?> map) throws Exception {
        OpenKitResponse self = new OpenKitResponse();
        return TeaModel.build(map, self);
    }

    public OpenKitResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OpenKitResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OpenKitResponse setBody(OpenKitResponseBody body) {
        this.body = body;
        return this;
    }
    public OpenKitResponseBody getBody() {
        return this.body;
    }

}
