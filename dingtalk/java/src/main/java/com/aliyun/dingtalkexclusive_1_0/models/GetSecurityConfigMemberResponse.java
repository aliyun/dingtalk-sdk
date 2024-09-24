// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetSecurityConfigMemberResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSecurityConfigMemberResponseBody body;

    public static GetSecurityConfigMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSecurityConfigMemberResponse self = new GetSecurityConfigMemberResponse();
        return TeaModel.build(map, self);
    }

    public GetSecurityConfigMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSecurityConfigMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSecurityConfigMemberResponse setBody(GetSecurityConfigMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSecurityConfigMemberResponseBody getBody() {
        return this.body;
    }

}
