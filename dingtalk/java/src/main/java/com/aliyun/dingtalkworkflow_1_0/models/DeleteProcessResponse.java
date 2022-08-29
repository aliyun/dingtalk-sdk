// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class DeleteProcessResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteProcessResponseBody body;

    public static DeleteProcessResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteProcessResponse self = new DeleteProcessResponse();
        return TeaModel.build(map, self);
    }

    public DeleteProcessResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteProcessResponse setBody(DeleteProcessResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteProcessResponseBody getBody() {
        return this.body;
    }

}
