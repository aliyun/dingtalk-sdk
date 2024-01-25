// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetAllJobPostResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAllJobPostResponseBody body;

    public static GetAllJobPostResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAllJobPostResponse self = new GetAllJobPostResponse();
        return TeaModel.build(map, self);
    }

    public GetAllJobPostResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAllJobPostResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAllJobPostResponse setBody(GetAllJobPostResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAllJobPostResponseBody getBody() {
        return this.body;
    }

}
