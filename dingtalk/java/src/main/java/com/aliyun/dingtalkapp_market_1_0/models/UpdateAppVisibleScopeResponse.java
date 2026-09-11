// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class UpdateAppVisibleScopeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateAppVisibleScopeResponseBody body;

    public static UpdateAppVisibleScopeResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateAppVisibleScopeResponse self = new UpdateAppVisibleScopeResponse();
        return TeaModel.build(map, self);
    }

    public UpdateAppVisibleScopeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateAppVisibleScopeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateAppVisibleScopeResponse setBody(UpdateAppVisibleScopeResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateAppVisibleScopeResponseBody getBody() {
        return this.body;
    }

}
