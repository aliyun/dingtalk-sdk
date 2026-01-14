// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetCustomerInsightResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetCustomerInsightResponseBody body;

    public static GetCustomerInsightResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCustomerInsightResponse self = new GetCustomerInsightResponse();
        return TeaModel.build(map, self);
    }

    public GetCustomerInsightResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCustomerInsightResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCustomerInsightResponse setBody(GetCustomerInsightResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCustomerInsightResponseBody getBody() {
        return this.body;
    }

}
