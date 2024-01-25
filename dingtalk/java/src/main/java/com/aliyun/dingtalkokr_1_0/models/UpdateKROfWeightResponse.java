// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdateKROfWeightResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateKROfWeightResponseBody body;

    public static UpdateKROfWeightResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateKROfWeightResponse self = new UpdateKROfWeightResponse();
        return TeaModel.build(map, self);
    }

    public UpdateKROfWeightResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateKROfWeightResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateKROfWeightResponse setBody(UpdateKROfWeightResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateKROfWeightResponseBody getBody() {
        return this.body;
    }

}
