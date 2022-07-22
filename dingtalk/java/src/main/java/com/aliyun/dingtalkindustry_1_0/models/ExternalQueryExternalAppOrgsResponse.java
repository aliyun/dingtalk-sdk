// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ExternalQueryExternalAppOrgsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ExternalQueryExternalAppOrgsResponseBody body;

    public static ExternalQueryExternalAppOrgsResponse build(java.util.Map<String, ?> map) throws Exception {
        ExternalQueryExternalAppOrgsResponse self = new ExternalQueryExternalAppOrgsResponse();
        return TeaModel.build(map, self);
    }

    public ExternalQueryExternalAppOrgsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ExternalQueryExternalAppOrgsResponse setBody(ExternalQueryExternalAppOrgsResponseBody body) {
        this.body = body;
        return this;
    }
    public ExternalQueryExternalAppOrgsResponseBody getBody() {
        return this.body;
    }

}
