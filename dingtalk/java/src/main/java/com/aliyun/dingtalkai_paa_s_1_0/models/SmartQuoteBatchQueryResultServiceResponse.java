// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SmartQuoteBatchQueryResultServiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SmartQuoteBatchQueryResultServiceResponseBody body;

    public static SmartQuoteBatchQueryResultServiceResponse build(java.util.Map<String, ?> map) throws Exception {
        SmartQuoteBatchQueryResultServiceResponse self = new SmartQuoteBatchQueryResultServiceResponse();
        return TeaModel.build(map, self);
    }

    public SmartQuoteBatchQueryResultServiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SmartQuoteBatchQueryResultServiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SmartQuoteBatchQueryResultServiceResponse setBody(SmartQuoteBatchQueryResultServiceResponseBody body) {
        this.body = body;
        return this;
    }
    public SmartQuoteBatchQueryResultServiceResponseBody getBody() {
        return this.body;
    }

}
