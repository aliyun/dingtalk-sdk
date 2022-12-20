// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DeleteLeadsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteLeadsResponseBody body;

    public static DeleteLeadsResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteLeadsResponse self = new DeleteLeadsResponse();
        return TeaModel.build(map, self);
    }

    public DeleteLeadsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteLeadsResponse setBody(DeleteLeadsResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteLeadsResponseBody getBody() {
        return this.body;
    }

}
