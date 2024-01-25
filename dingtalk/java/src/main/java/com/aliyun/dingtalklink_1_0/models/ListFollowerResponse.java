// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class ListFollowerResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListFollowerResponseBody body;

    public static ListFollowerResponse build(java.util.Map<String, ?> map) throws Exception {
        ListFollowerResponse self = new ListFollowerResponse();
        return TeaModel.build(map, self);
    }

    public ListFollowerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListFollowerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListFollowerResponse setBody(ListFollowerResponseBody body) {
        this.body = body;
        return this;
    }
    public ListFollowerResponseBody getBody() {
        return this.body;
    }

}
