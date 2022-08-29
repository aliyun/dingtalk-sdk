// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateProcessInstanceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public BatchUpdateProcessInstanceResponse setBody(BatchUpdateProcessInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchUpdateProcessInstanceResponseBody getBody() {
        return this.body;
    }

}
