// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSimpleUsersByRoleResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListSimpleUsersByRoleResponseBody body;

    public static ListSimpleUsersByRoleResponse build(java.util.Map<String, ?> map) throws Exception {
        ListSimpleUsersByRoleResponse self = new ListSimpleUsersByRoleResponse();
        return TeaModel.build(map, self);
    }

    public ListSimpleUsersByRoleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListSimpleUsersByRoleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListSimpleUsersByRoleResponse setBody(ListSimpleUsersByRoleResponseBody body) {
        this.body = body;
        return this;
    }
    public ListSimpleUsersByRoleResponseBody getBody() {
        return this.body;
    }

}
