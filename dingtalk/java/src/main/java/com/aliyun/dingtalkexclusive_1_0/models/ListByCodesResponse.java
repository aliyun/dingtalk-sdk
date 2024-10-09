// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListByCodesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListByCodesResponseBody body;

    public static ListByCodesResponse build(java.util.Map<String, ?> map) throws Exception {
        ListByCodesResponse self = new ListByCodesResponse();
        return TeaModel.build(map, self);
    }

    public ListByCodesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListByCodesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListByCodesResponse setBody(ListByCodesResponseBody body) {
        this.body = body;
        return this;
    }
    public ListByCodesResponseBody getBody() {
        return this.body;
    }

}
