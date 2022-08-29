// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetATManageScopeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetATManageScopeResponse setBody(GetATManageScopeResponseBody body) {
        this.body = body;
        return this;
    }
    public GetATManageScopeResponseBody getBody() {
        return this.body;
    }

}
