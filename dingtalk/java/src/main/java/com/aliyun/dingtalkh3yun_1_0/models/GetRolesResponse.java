// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetRolesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetRolesResponseBody body;

    public static GetRolesResponse build(java.util.Map<String, ?> map) throws Exception {
        GetRolesResponse self = new GetRolesResponse();
        return TeaModel.build(map, self);
    }

    public GetRolesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetRolesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetRolesResponse setBody(GetRolesResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRolesResponseBody getBody() {
        return this.body;
    }

}
