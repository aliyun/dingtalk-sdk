// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class BatchDeleteDeviceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchDeleteDeviceResponseBody body;

    public static BatchDeleteDeviceResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchDeleteDeviceResponse self = new BatchDeleteDeviceResponse();
        return TeaModel.build(map, self);
    }

    public BatchDeleteDeviceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchDeleteDeviceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchDeleteDeviceResponse setBody(BatchDeleteDeviceResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchDeleteDeviceResponseBody getBody() {
        return this.body;
    }

}
