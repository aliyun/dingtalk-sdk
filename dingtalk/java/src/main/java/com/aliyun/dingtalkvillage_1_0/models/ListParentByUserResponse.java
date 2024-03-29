// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListParentByUserResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListParentByUserResponseBody body;

    public static ListParentByUserResponse build(java.util.Map<String, ?> map) throws Exception {
        ListParentByUserResponse self = new ListParentByUserResponse();
        return TeaModel.build(map, self);
    }

    public ListParentByUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListParentByUserResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListParentByUserResponse setBody(ListParentByUserResponseBody body) {
        this.body = body;
        return this;
    }
    public ListParentByUserResponseBody getBody() {
        return this.body;
    }

}
