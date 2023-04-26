// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class RemoveApaasAppResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RemoveApaasAppResponseBody body;

    public static RemoveApaasAppResponse build(java.util.Map<String, ?> map) throws Exception {
        RemoveApaasAppResponse self = new RemoveApaasAppResponse();
        return TeaModel.build(map, self);
    }

    public RemoveApaasAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RemoveApaasAppResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RemoveApaasAppResponse setBody(RemoveApaasAppResponseBody body) {
        this.body = body;
        return this;
    }
    public RemoveApaasAppResponseBody getBody() {
        return this.body;
    }

}
