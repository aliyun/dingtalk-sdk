// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetUserInfoByOpenTokenResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetUserInfoByOpenTokenResponseBody body;

    public static GetUserInfoByOpenTokenResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserInfoByOpenTokenResponse self = new GetUserInfoByOpenTokenResponse();
        return TeaModel.build(map, self);
    }

    public GetUserInfoByOpenTokenResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserInfoByOpenTokenResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserInfoByOpenTokenResponse setBody(GetUserInfoByOpenTokenResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserInfoByOpenTokenResponseBody getBody() {
        return this.body;
    }

}
