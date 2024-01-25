// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetJobPostResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetJobPostResponseBody body;

    public static GetJobPostResponse build(java.util.Map<String, ?> map) throws Exception {
        GetJobPostResponse self = new GetJobPostResponse();
        return TeaModel.build(map, self);
    }

    public GetJobPostResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetJobPostResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetJobPostResponse setBody(GetJobPostResponseBody body) {
        this.body = body;
        return this;
    }
    public GetJobPostResponseBody getBody() {
        return this.body;
    }

}
