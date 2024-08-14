// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjobs_1_0.models;

import com.aliyun.tea.*;

public class PostResumeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PostResumeResponseBody body;

    public static PostResumeResponse build(java.util.Map<String, ?> map) throws Exception {
        PostResumeResponse self = new PostResumeResponse();
        return TeaModel.build(map, self);
    }

    public PostResumeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PostResumeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PostResumeResponse setBody(PostResumeResponseBody body) {
        this.body = body;
        return this;
    }
    public PostResumeResponseBody getBody() {
        return this.body;
    }

}
