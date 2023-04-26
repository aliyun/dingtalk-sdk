// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class CollectResumeDetailResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CollectResumeDetailResponseBody body;

    public static CollectResumeDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        CollectResumeDetailResponse self = new CollectResumeDetailResponse();
        return TeaModel.build(map, self);
    }

    public CollectResumeDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollectResumeDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CollectResumeDetailResponse setBody(CollectResumeDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public CollectResumeDetailResponseBody getBody() {
        return this.body;
    }

}
