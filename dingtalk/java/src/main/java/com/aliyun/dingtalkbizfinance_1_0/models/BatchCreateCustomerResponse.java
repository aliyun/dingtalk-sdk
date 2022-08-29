// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class BatchCreateCustomerResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public BatchCreateCustomerResponseBody body;

    public static BatchCreateCustomerResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchCreateCustomerResponse self = new BatchCreateCustomerResponse();
        return TeaModel.build(map, self);
    }

    public BatchCreateCustomerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchCreateCustomerResponse setBody(BatchCreateCustomerResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchCreateCustomerResponseBody getBody() {
        return this.body;
    }

}
