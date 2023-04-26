// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ServiceWindowMessageBatchPushResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ServiceWindowMessageBatchPushResponseBody body;

    public static ServiceWindowMessageBatchPushResponse build(java.util.Map<String, ?> map) throws Exception {
        ServiceWindowMessageBatchPushResponse self = new ServiceWindowMessageBatchPushResponse();
        return TeaModel.build(map, self);
    }

    public ServiceWindowMessageBatchPushResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ServiceWindowMessageBatchPushResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ServiceWindowMessageBatchPushResponse setBody(ServiceWindowMessageBatchPushResponseBody body) {
        this.body = body;
        return this;
    }
    public ServiceWindowMessageBatchPushResponseBody getBody() {
        return this.body;
    }

}
