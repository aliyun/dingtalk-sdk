// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetATManageScopeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetATManageScopeResponseBody body;

    public static GetATManageScopeResponse build(java.util.Map<String, ?> map) throws Exception {
        GetATManageScopeResponse self = new GetATManageScopeResponse();
        return TeaModel.build(map, self);
    }

    public GetATManageScopeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetATManageScopeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetATManageScopeResponse setBody(GetATManageScopeResponseBody body) {
        this.body = body;
        return this;
    }
    public GetATManageScopeResponseBody getBody() {
        return this.body;
    }

}
