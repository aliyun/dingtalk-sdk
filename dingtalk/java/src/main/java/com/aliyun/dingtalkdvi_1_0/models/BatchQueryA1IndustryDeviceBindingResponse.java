// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryA1IndustryDeviceBindingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchQueryA1IndustryDeviceBindingResponseBody body;

    public static BatchQueryA1IndustryDeviceBindingResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryA1IndustryDeviceBindingResponse self = new BatchQueryA1IndustryDeviceBindingResponse();
        return TeaModel.build(map, self);
    }

    public BatchQueryA1IndustryDeviceBindingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchQueryA1IndustryDeviceBindingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchQueryA1IndustryDeviceBindingResponse setBody(BatchQueryA1IndustryDeviceBindingResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchQueryA1IndustryDeviceBindingResponseBody getBody() {
        return this.body;
    }

}
