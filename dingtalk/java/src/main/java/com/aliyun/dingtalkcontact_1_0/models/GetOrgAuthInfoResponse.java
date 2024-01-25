// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetOrgAuthInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetOrgAuthInfoResponseBody body;

    public static GetOrgAuthInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOrgAuthInfoResponse self = new GetOrgAuthInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetOrgAuthInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOrgAuthInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetOrgAuthInfoResponse setBody(GetOrgAuthInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOrgAuthInfoResponseBody getBody() {
        return this.body;
    }

}
