// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AdjustKitResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AdjustKitResponseBody body;

    public static AdjustKitResponse build(java.util.Map<String, ?> map) throws Exception {
        AdjustKitResponse self = new AdjustKitResponse();
        return TeaModel.build(map, self);
    }

    public AdjustKitResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AdjustKitResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AdjustKitResponse setBody(AdjustKitResponseBody body) {
        this.body = body;
        return this;
    }
    public AdjustKitResponseBody getBody() {
        return this.body;
    }

}
