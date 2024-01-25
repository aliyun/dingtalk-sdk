// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryCustomerSendTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchQueryCustomerSendTaskResponseBody body;

    public static BatchQueryCustomerSendTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryCustomerSendTaskResponse self = new BatchQueryCustomerSendTaskResponse();
        return TeaModel.build(map, self);
    }

    public BatchQueryCustomerSendTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchQueryCustomerSendTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchQueryCustomerSendTaskResponse setBody(BatchQueryCustomerSendTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchQueryCustomerSendTaskResponseBody getBody() {
        return this.body;
    }

}
