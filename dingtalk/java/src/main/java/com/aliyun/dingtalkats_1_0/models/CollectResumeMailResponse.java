// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class CollectResumeMailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CollectResumeMailResponseBody body;

    public static CollectResumeMailResponse build(java.util.Map<String, ?> map) throws Exception {
        CollectResumeMailResponse self = new CollectResumeMailResponse();
        return TeaModel.build(map, self);
    }

    public CollectResumeMailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollectResumeMailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CollectResumeMailResponse setBody(CollectResumeMailResponseBody body) {
        this.body = body;
        return this;
    }
    public CollectResumeMailResponseBody getBody() {
        return this.body;
    }

}
