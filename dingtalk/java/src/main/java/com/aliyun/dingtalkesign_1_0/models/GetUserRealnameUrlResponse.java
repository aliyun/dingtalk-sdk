// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetUserRealnameUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetUserRealnameUrlResponseBody body;

    public static GetUserRealnameUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserRealnameUrlResponse self = new GetUserRealnameUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetUserRealnameUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserRealnameUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserRealnameUrlResponse setBody(GetUserRealnameUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserRealnameUrlResponseBody getBody() {
        return this.body;
    }

}
