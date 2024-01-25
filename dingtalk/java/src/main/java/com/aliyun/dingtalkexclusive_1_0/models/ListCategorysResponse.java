// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListCategorysResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListCategorysResponseBody body;

    public static ListCategorysResponse build(java.util.Map<String, ?> map) throws Exception {
        ListCategorysResponse self = new ListCategorysResponse();
        return TeaModel.build(map, self);
    }

    public ListCategorysResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListCategorysResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListCategorysResponse setBody(ListCategorysResponseBody body) {
        this.body = body;
        return this;
    }
    public ListCategorysResponseBody getBody() {
        return this.body;
    }

}
