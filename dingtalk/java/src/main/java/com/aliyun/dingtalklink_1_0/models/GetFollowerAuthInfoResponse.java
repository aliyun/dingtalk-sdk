// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class GetFollowerAuthInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetFollowerAuthInfoResponseBody body;

    public static GetFollowerAuthInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFollowerAuthInfoResponse self = new GetFollowerAuthInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetFollowerAuthInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFollowerAuthInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFollowerAuthInfoResponse setBody(GetFollowerAuthInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFollowerAuthInfoResponseBody getBody() {
        return this.body;
    }

}
