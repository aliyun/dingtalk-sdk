// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class RollbackInnerAppVersionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RollbackInnerAppVersionResponseBody body;

    public static RollbackInnerAppVersionResponse build(java.util.Map<String, ?> map) throws Exception {
        RollbackInnerAppVersionResponse self = new RollbackInnerAppVersionResponse();
        return TeaModel.build(map, self);
    }

    public RollbackInnerAppVersionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RollbackInnerAppVersionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RollbackInnerAppVersionResponse setBody(RollbackInnerAppVersionResponseBody body) {
        this.body = body;
        return this;
    }
    public RollbackInnerAppVersionResponseBody getBody() {
        return this.body;
    }

}
