// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class UpdateAuxiliaryStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateAuxiliaryStatusResponseBody body;

    public static UpdateAuxiliaryStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateAuxiliaryStatusResponse self = new UpdateAuxiliaryStatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdateAuxiliaryStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateAuxiliaryStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateAuxiliaryStatusResponse setBody(UpdateAuxiliaryStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateAuxiliaryStatusResponseBody getBody() {
        return this.body;
    }

}
