// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateProcessInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchUpdateProcessInstanceResponseBody body;

    public static BatchUpdateProcessInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateProcessInstanceResponse self = new BatchUpdateProcessInstanceResponse();
        return TeaModel.build(map, self);
    }

    public BatchUpdateProcessInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchUpdateProcessInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchUpdateProcessInstanceResponse setBody(BatchUpdateProcessInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchUpdateProcessInstanceResponseBody getBody() {
        return this.body;
    }

}
