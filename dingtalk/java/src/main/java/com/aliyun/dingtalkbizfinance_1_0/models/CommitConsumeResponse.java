// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CommitConsumeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CommitConsumeResponseBody body;

    public static CommitConsumeResponse build(java.util.Map<String, ?> map) throws Exception {
        CommitConsumeResponse self = new CommitConsumeResponse();
        return TeaModel.build(map, self);
    }

    public CommitConsumeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CommitConsumeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CommitConsumeResponse setBody(CommitConsumeResponseBody body) {
        this.body = body;
        return this;
    }
    public CommitConsumeResponseBody getBody() {
        return this.body;
    }

}
