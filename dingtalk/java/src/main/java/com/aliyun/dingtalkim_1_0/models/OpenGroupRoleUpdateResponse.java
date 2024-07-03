// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenGroupRoleUpdateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OpenGroupRoleUpdateResponseBody body;

    public static OpenGroupRoleUpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        OpenGroupRoleUpdateResponse self = new OpenGroupRoleUpdateResponse();
        return TeaModel.build(map, self);
    }

    public OpenGroupRoleUpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OpenGroupRoleUpdateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OpenGroupRoleUpdateResponse setBody(OpenGroupRoleUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public OpenGroupRoleUpdateResponseBody getBody() {
        return this.body;
    }

}
