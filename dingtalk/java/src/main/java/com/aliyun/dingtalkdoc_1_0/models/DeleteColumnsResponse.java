// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteColumnsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteColumnsResponseBody body;

    public static DeleteColumnsResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteColumnsResponse self = new DeleteColumnsResponse();
        return TeaModel.build(map, self);
    }

    public DeleteColumnsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteColumnsResponse setBody(DeleteColumnsResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteColumnsResponseBody getBody() {
        return this.body;
    }

}
