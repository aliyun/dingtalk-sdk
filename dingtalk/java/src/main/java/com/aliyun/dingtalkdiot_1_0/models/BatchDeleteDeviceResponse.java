// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class BatchDeleteDeviceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public BatchDeleteDeviceResponse setBody(BatchDeleteDeviceResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchDeleteDeviceResponseBody getBody() {
        return this.body;
    }

}
