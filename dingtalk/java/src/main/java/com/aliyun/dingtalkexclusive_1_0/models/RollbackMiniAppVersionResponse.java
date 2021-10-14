// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class RollbackMiniAppVersionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public RollbackMiniAppVersionResponseBody body;

    public static RollbackMiniAppVersionResponse build(java.util.Map<String, ?> map) throws Exception {
        RollbackMiniAppVersionResponse self = new RollbackMiniAppVersionResponse();
        return TeaModel.build(map, self);
    }

    public RollbackMiniAppVersionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RollbackMiniAppVersionResponse setBody(RollbackMiniAppVersionResponseBody body) {
        this.body = body;
        return this;
    }
    public RollbackMiniAppVersionResponseBody getBody() {
        return this.body;
    }

}
