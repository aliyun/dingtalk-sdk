// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateDeviceCutCustomerSwitchResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchUpdateDeviceCutCustomerSwitchResponseBody body;

    public static BatchUpdateDeviceCutCustomerSwitchResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateDeviceCutCustomerSwitchResponse self = new BatchUpdateDeviceCutCustomerSwitchResponse();
        return TeaModel.build(map, self);
    }

    public BatchUpdateDeviceCutCustomerSwitchResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchUpdateDeviceCutCustomerSwitchResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchUpdateDeviceCutCustomerSwitchResponse setBody(BatchUpdateDeviceCutCustomerSwitchResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchUpdateDeviceCutCustomerSwitchResponseBody getBody() {
        return this.body;
    }

}
