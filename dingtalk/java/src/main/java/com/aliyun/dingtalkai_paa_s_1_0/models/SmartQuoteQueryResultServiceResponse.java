// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SmartQuoteQueryResultServiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SmartQuoteQueryResultServiceResponseBody body;

    public static SmartQuoteQueryResultServiceResponse build(java.util.Map<String, ?> map) throws Exception {
        SmartQuoteQueryResultServiceResponse self = new SmartQuoteQueryResultServiceResponse();
        return TeaModel.build(map, self);
    }

    public SmartQuoteQueryResultServiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SmartQuoteQueryResultServiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SmartQuoteQueryResultServiceResponse setBody(SmartQuoteQueryResultServiceResponseBody body) {
        this.body = body;
        return this;
    }
    public SmartQuoteQueryResultServiceResponseBody getBody() {
        return this.body;
    }

}
