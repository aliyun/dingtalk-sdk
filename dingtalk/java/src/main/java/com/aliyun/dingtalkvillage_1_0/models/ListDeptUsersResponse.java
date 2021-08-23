// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListDeptUsersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListDeptUsersResponseBody body;

    public static ListDeptUsersResponse build(java.util.Map<String, ?> map) throws Exception {
        ListDeptUsersResponse self = new ListDeptUsersResponse();
        return TeaModel.build(map, self);
    }

    public ListDeptUsersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListDeptUsersResponse setBody(ListDeptUsersResponseBody body) {
        this.body = body;
        return this;
    }
    public ListDeptUsersResponseBody getBody() {
        return this.body;
    }

}
