// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BatchQuerySendMessageTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchQuerySendMessageTaskResponseBody body;

    public static BatchQuerySendMessageTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchQuerySendMessageTaskResponse self = new BatchQuerySendMessageTaskResponse();
        return TeaModel.build(map, self);
    }

    public BatchQuerySendMessageTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchQuerySendMessageTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchQuerySendMessageTaskResponse setBody(BatchQuerySendMessageTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchQuerySendMessageTaskResponseBody getBody() {
        return this.body;
    }

}
