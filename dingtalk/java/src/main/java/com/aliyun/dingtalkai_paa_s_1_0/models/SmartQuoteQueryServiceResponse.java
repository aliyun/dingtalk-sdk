// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SmartQuoteQueryServiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SmartQuoteQueryServiceResponseBody body;

    public static SmartQuoteQueryServiceResponse build(java.util.Map<String, ?> map) throws Exception {
        SmartQuoteQueryServiceResponse self = new SmartQuoteQueryServiceResponse();
        return TeaModel.build(map, self);
    }

    public SmartQuoteQueryServiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SmartQuoteQueryServiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SmartQuoteQueryServiceResponse setBody(SmartQuoteQueryServiceResponseBody body) {
        this.body = body;
        return this;
    }
    public SmartQuoteQueryServiceResponseBody getBody() {
        return this.body;
    }

}
