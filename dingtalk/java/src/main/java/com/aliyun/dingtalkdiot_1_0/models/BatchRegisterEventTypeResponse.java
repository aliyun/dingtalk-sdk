// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class BatchRegisterEventTypeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public BatchRegisterEventTypeResponseBody body;

    public static BatchRegisterEventTypeResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchRegisterEventTypeResponse self = new BatchRegisterEventTypeResponse();
        return TeaModel.build(map, self);
    }

    public BatchRegisterEventTypeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchRegisterEventTypeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchRegisterEventTypeResponse setBody(BatchRegisterEventTypeResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchRegisterEventTypeResponseBody getBody() {
        return this.body;
    }

}
