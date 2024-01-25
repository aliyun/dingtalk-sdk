// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class ListAccountResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListAccountResponseBody body;

    public static ListAccountResponse build(java.util.Map<String, ?> map) throws Exception {
        ListAccountResponse self = new ListAccountResponse();
        return TeaModel.build(map, self);
    }

    public ListAccountResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListAccountResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListAccountResponse setBody(ListAccountResponseBody body) {
        this.body = body;
        return this;
    }
    public ListAccountResponseBody getBody() {
        return this.body;
    }

}
