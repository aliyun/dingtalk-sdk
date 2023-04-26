// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSubDeptResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListSubDeptResponseBody body;

    public static ListSubDeptResponse build(java.util.Map<String, ?> map) throws Exception {
        ListSubDeptResponse self = new ListSubDeptResponse();
        return TeaModel.build(map, self);
    }

    public ListSubDeptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListSubDeptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListSubDeptResponse setBody(ListSubDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public ListSubDeptResponseBody getBody() {
        return this.body;
    }

}
