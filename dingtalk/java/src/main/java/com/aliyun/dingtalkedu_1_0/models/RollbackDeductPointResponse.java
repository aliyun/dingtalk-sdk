// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class RollbackDeductPointResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RollbackDeductPointResponseBody body;

    public static RollbackDeductPointResponse build(java.util.Map<String, ?> map) throws Exception {
        RollbackDeductPointResponse self = new RollbackDeductPointResponse();
        return TeaModel.build(map, self);
    }

    public RollbackDeductPointResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RollbackDeductPointResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RollbackDeductPointResponse setBody(RollbackDeductPointResponseBody body) {
        this.body = body;
        return this;
    }
    public RollbackDeductPointResponseBody getBody() {
        return this.body;
    }

}
