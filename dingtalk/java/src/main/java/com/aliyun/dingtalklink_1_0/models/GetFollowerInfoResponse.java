// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class GetFollowerInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetFollowerInfoResponseBody body;

    public static GetFollowerInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFollowerInfoResponse self = new GetFollowerInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetFollowerInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFollowerInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFollowerInfoResponse setBody(GetFollowerInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFollowerInfoResponseBody getBody() {
        return this.body;
    }

}
