// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumBatchExecuteProcessInstancesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumBatchExecuteProcessInstancesResponseBody body;

    public static PremiumBatchExecuteProcessInstancesResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumBatchExecuteProcessInstancesResponse self = new PremiumBatchExecuteProcessInstancesResponse();
        return TeaModel.build(map, self);
    }

    public PremiumBatchExecuteProcessInstancesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumBatchExecuteProcessInstancesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumBatchExecuteProcessInstancesResponse setBody(PremiumBatchExecuteProcessInstancesResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumBatchExecuteProcessInstancesResponseBody getBody() {
        return this.body;
    }

}
