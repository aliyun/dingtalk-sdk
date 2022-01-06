// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateDeviceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public BatchUpdateDeviceResponseBody body;

    public static BatchUpdateDeviceResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateDeviceResponse self = new BatchUpdateDeviceResponse();
        return TeaModel.build(map, self);
    }

    public BatchUpdateDeviceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchUpdateDeviceResponse setBody(BatchUpdateDeviceResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchUpdateDeviceResponseBody getBody() {
        return this.body;
    }

}