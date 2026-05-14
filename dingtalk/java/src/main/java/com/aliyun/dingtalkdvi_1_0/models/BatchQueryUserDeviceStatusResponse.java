// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryUserDeviceStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchQueryUserDeviceStatusResponseBody body;

    public static BatchQueryUserDeviceStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryUserDeviceStatusResponse self = new BatchQueryUserDeviceStatusResponse();
        return TeaModel.build(map, self);
    }

    public BatchQueryUserDeviceStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchQueryUserDeviceStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchQueryUserDeviceStatusResponse setBody(BatchQueryUserDeviceStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchQueryUserDeviceStatusResponseBody getBody() {
        return this.body;
    }

}
