// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class BatchExecuteProcessInstancesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public BatchExecuteProcessInstancesResponseBody body;

    public static BatchExecuteProcessInstancesResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchExecuteProcessInstancesResponse self = new BatchExecuteProcessInstancesResponse();
        return TeaModel.build(map, self);
    }

    public BatchExecuteProcessInstancesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchExecuteProcessInstancesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchExecuteProcessInstancesResponse setBody(BatchExecuteProcessInstancesResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchExecuteProcessInstancesResponseBody getBody() {
        return this.body;
    }

}
