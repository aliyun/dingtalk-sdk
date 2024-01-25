// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidenceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateResidenceResponseBody body;

    public static UpdateResidenceResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateResidenceResponse self = new UpdateResidenceResponse();
        return TeaModel.build(map, self);
    }

    public UpdateResidenceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateResidenceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateResidenceResponse setBody(UpdateResidenceResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateResidenceResponseBody getBody() {
        return this.body;
    }

}
