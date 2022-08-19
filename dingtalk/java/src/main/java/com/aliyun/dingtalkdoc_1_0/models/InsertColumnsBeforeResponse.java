// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class InsertColumnsBeforeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public InsertColumnsBeforeResponseBody body;

    public static InsertColumnsBeforeResponse build(java.util.Map<String, ?> map) throws Exception {
        InsertColumnsBeforeResponse self = new InsertColumnsBeforeResponse();
        return TeaModel.build(map, self);
    }

    public InsertColumnsBeforeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InsertColumnsBeforeResponse setBody(InsertColumnsBeforeResponseBody body) {
        this.body = body;
        return this;
    }
    public InsertColumnsBeforeResponseBody getBody() {
        return this.body;
    }

}
