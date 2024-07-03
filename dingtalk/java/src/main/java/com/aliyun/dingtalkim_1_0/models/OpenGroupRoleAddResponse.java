// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenGroupRoleAddResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OpenGroupRoleAddResponseBody body;

    public static OpenGroupRoleAddResponse build(java.util.Map<String, ?> map) throws Exception {
        OpenGroupRoleAddResponse self = new OpenGroupRoleAddResponse();
        return TeaModel.build(map, self);
    }

    public OpenGroupRoleAddResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OpenGroupRoleAddResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OpenGroupRoleAddResponse setBody(OpenGroupRoleAddResponseBody body) {
        this.body = body;
        return this;
    }
    public OpenGroupRoleAddResponseBody getBody() {
        return this.body;
    }

}
