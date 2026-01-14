// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ListCustomerResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListCustomerResponseBody body;

    public static ListCustomerResponse build(java.util.Map<String, ?> map) throws Exception {
        ListCustomerResponse self = new ListCustomerResponse();
        return TeaModel.build(map, self);
    }

    public ListCustomerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListCustomerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListCustomerResponse setBody(ListCustomerResponseBody body) {
        this.body = body;
        return this;
    }
    public ListCustomerResponseBody getBody() {
        return this.body;
    }

}
