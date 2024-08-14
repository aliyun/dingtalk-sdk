// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjobs_1_0.models;

import com.aliyun.tea.*;

public class CreateResumeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateResumeResponseBody body;

    public static CreateResumeResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateResumeResponse self = new CreateResumeResponse();
        return TeaModel.build(map, self);
    }

    public CreateResumeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateResumeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateResumeResponse setBody(CreateResumeResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateResumeResponseBody getBody() {
        return this.body;
    }

}
