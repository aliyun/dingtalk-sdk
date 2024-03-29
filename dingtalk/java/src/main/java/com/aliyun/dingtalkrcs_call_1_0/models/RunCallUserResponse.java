// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrcs_call_1_0.models;

import com.aliyun.tea.*;

public class RunCallUserResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RunCallUserResponseBody body;

    public static RunCallUserResponse build(java.util.Map<String, ?> map) throws Exception {
        RunCallUserResponse self = new RunCallUserResponse();
        return TeaModel.build(map, self);
    }

    public RunCallUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RunCallUserResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RunCallUserResponse setBody(RunCallUserResponseBody body) {
        this.body = body;
        return this;
    }
    public RunCallUserResponseBody getBody() {
        return this.body;
    }

}
