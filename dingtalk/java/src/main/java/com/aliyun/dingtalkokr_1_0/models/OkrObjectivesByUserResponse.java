// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class OkrObjectivesByUserResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OkrObjectivesByUserResponseBody body;

    public static OkrObjectivesByUserResponse build(java.util.Map<String, ?> map) throws Exception {
        OkrObjectivesByUserResponse self = new OkrObjectivesByUserResponse();
        return TeaModel.build(map, self);
    }

    public OkrObjectivesByUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OkrObjectivesByUserResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OkrObjectivesByUserResponse setBody(OkrObjectivesByUserResponseBody body) {
        this.body = body;
        return this;
    }
    public OkrObjectivesByUserResponseBody getBody() {
        return this.body;
    }

}
