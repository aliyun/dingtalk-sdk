// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class ResumePostEventResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ResumePostEventResponseBody body;

    public static ResumePostEventResponse build(java.util.Map<String, ?> map) throws Exception {
        ResumePostEventResponse self = new ResumePostEventResponse();
        return TeaModel.build(map, self);
    }

    public ResumePostEventResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ResumePostEventResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ResumePostEventResponse setBody(ResumePostEventResponseBody body) {
        this.body = body;
        return this;
    }
    public ResumePostEventResponseBody getBody() {
        return this.body;
    }

}
