// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SmartQuoteBatchQueryServiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SmartQuoteBatchQueryServiceResponseBody body;

    public static SmartQuoteBatchQueryServiceResponse build(java.util.Map<String, ?> map) throws Exception {
        SmartQuoteBatchQueryServiceResponse self = new SmartQuoteBatchQueryServiceResponse();
        return TeaModel.build(map, self);
    }

    public SmartQuoteBatchQueryServiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SmartQuoteBatchQueryServiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SmartQuoteBatchQueryServiceResponse setBody(SmartQuoteBatchQueryServiceResponseBody body) {
        this.body = body;
        return this;
    }
    public SmartQuoteBatchQueryServiceResponseBody getBody() {
        return this.body;
    }

}
