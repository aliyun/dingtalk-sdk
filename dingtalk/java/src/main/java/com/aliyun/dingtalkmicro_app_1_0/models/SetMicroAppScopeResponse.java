// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class SetMicroAppScopeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetMicroAppScopeResponseBody body;

    public static SetMicroAppScopeResponse build(java.util.Map<String, ?> map) throws Exception {
        SetMicroAppScopeResponse self = new SetMicroAppScopeResponse();
        return TeaModel.build(map, self);
    }

    public SetMicroAppScopeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetMicroAppScopeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetMicroAppScopeResponse setBody(SetMicroAppScopeResponseBody body) {
        this.body = body;
        return this;
    }
    public SetMicroAppScopeResponseBody getBody() {
        return this.body;
    }

}
