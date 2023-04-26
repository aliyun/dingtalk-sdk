// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetMicroAppScopeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetMicroAppScopeResponseBody body;

    public static GetMicroAppScopeResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMicroAppScopeResponse self = new GetMicroAppScopeResponse();
        return TeaModel.build(map, self);
    }

    public GetMicroAppScopeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMicroAppScopeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetMicroAppScopeResponse setBody(GetMicroAppScopeResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMicroAppScopeResponseBody getBody() {
        return this.body;
    }

}
