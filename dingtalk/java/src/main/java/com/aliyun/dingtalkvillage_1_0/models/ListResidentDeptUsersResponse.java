// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListResidentDeptUsersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListResidentDeptUsersResponseBody body;

    public static ListResidentDeptUsersResponse build(java.util.Map<String, ?> map) throws Exception {
        ListResidentDeptUsersResponse self = new ListResidentDeptUsersResponse();
        return TeaModel.build(map, self);
    }

    public ListResidentDeptUsersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListResidentDeptUsersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListResidentDeptUsersResponse setBody(ListResidentDeptUsersResponseBody body) {
        this.body = body;
        return this;
    }
    public ListResidentDeptUsersResponseBody getBody() {
        return this.body;
    }

}
