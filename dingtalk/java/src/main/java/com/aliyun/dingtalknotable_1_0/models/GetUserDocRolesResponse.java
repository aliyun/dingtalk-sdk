// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class GetUserDocRolesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetUserDocRolesResponseBody body;

    public static GetUserDocRolesResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserDocRolesResponse self = new GetUserDocRolesResponse();
        return TeaModel.build(map, self);
    }

    public GetUserDocRolesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserDocRolesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserDocRolesResponse setBody(GetUserDocRolesResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserDocRolesResponseBody getBody() {
        return this.body;
    }

}
