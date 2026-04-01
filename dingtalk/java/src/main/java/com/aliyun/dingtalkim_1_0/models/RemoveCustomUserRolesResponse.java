// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class RemoveCustomUserRolesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RemoveCustomUserRolesResponseBody body;

    public static RemoveCustomUserRolesResponse build(java.util.Map<String, ?> map) throws Exception {
        RemoveCustomUserRolesResponse self = new RemoveCustomUserRolesResponse();
        return TeaModel.build(map, self);
    }

    public RemoveCustomUserRolesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RemoveCustomUserRolesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RemoveCustomUserRolesResponse setBody(RemoveCustomUserRolesResponseBody body) {
        this.body = body;
        return this;
    }
    public RemoveCustomUserRolesResponseBody getBody() {
        return this.body;
    }

}
