// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenGroupRoleRemoveResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OpenGroupRoleRemoveResponseBody body;

    public static OpenGroupRoleRemoveResponse build(java.util.Map<String, ?> map) throws Exception {
        OpenGroupRoleRemoveResponse self = new OpenGroupRoleRemoveResponse();
        return TeaModel.build(map, self);
    }

    public OpenGroupRoleRemoveResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OpenGroupRoleRemoveResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OpenGroupRoleRemoveResponse setBody(OpenGroupRoleRemoveResponseBody body) {
        this.body = body;
        return this;
    }
    public OpenGroupRoleRemoveResponseBody getBody() {
        return this.body;
    }

}
