// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListAppRoleScopesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListAppRoleScopesResponseBody body;

    public static ListAppRoleScopesResponse build(java.util.Map<String, ?> map) throws Exception {
        ListAppRoleScopesResponse self = new ListAppRoleScopesResponse();
        return TeaModel.build(map, self);
    }

    public ListAppRoleScopesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListAppRoleScopesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListAppRoleScopesResponse setBody(ListAppRoleScopesResponseBody body) {
        this.body = body;
        return this;
    }
    public ListAppRoleScopesResponseBody getBody() {
        return this.body;
    }

}
