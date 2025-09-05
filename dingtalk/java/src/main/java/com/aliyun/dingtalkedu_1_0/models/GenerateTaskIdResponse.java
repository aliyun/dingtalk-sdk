// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GenerateTaskIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GenerateTaskIdResponseBody body;

    public static GenerateTaskIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GenerateTaskIdResponse self = new GenerateTaskIdResponse();
        return TeaModel.build(map, self);
    }

    public GenerateTaskIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GenerateTaskIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GenerateTaskIdResponse setBody(GenerateTaskIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GenerateTaskIdResponseBody getBody() {
        return this.body;
    }

}
