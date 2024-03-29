// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidentInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateResidentInfoResponseBody body;

    public static UpdateResidentInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateResidentInfoResponse self = new UpdateResidentInfoResponse();
        return TeaModel.build(map, self);
    }

    public UpdateResidentInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateResidentInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateResidentInfoResponse setBody(UpdateResidentInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateResidentInfoResponseBody getBody() {
        return this.body;
    }

}
