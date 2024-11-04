// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SmartQuoteDataServiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SmartQuoteDataServiceResponseBody body;

    public static SmartQuoteDataServiceResponse build(java.util.Map<String, ?> map) throws Exception {
        SmartQuoteDataServiceResponse self = new SmartQuoteDataServiceResponse();
        return TeaModel.build(map, self);
    }

    public SmartQuoteDataServiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SmartQuoteDataServiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SmartQuoteDataServiceResponse setBody(SmartQuoteDataServiceResponseBody body) {
        this.body = body;
        return this;
    }
    public SmartQuoteDataServiceResponseBody getBody() {
        return this.body;
    }

}
