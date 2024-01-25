// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetSsoUserInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSsoUserInfoResponseBody body;

    public static GetSsoUserInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSsoUserInfoResponse self = new GetSsoUserInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetSsoUserInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSsoUserInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSsoUserInfoResponse setBody(GetSsoUserInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSsoUserInfoResponseBody getBody() {
        return this.body;
    }

}
