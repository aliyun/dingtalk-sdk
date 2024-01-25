// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListDeptSimpleUsersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListDeptSimpleUsersResponseBody body;

    public static ListDeptSimpleUsersResponse build(java.util.Map<String, ?> map) throws Exception {
        ListDeptSimpleUsersResponse self = new ListDeptSimpleUsersResponse();
        return TeaModel.build(map, self);
    }

    public ListDeptSimpleUsersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListDeptSimpleUsersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListDeptSimpleUsersResponse setBody(ListDeptSimpleUsersResponseBody body) {
        this.body = body;
        return this;
    }
    public ListDeptSimpleUsersResponseBody getBody() {
        return this.body;
    }

}
