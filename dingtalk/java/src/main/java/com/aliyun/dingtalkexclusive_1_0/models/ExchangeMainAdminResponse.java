// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ExchangeMainAdminResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ExchangeMainAdminResponseBody body;

    public static ExchangeMainAdminResponse build(java.util.Map<String, ?> map) throws Exception {
        ExchangeMainAdminResponse self = new ExchangeMainAdminResponse();
        return TeaModel.build(map, self);
    }

    public ExchangeMainAdminResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ExchangeMainAdminResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ExchangeMainAdminResponse setBody(ExchangeMainAdminResponseBody body) {
        this.body = body;
        return this;
    }
    public ExchangeMainAdminResponseBody getBody() {
        return this.body;
    }

}
