// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteRowsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteRowsResponseBody body;

    public static DeleteRowsResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteRowsResponse self = new DeleteRowsResponse();
        return TeaModel.build(map, self);
    }

    public DeleteRowsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteRowsResponse setBody(DeleteRowsResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteRowsResponseBody getBody() {
        return this.body;
    }

}
