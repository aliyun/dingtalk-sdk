// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeleteDentriesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteDentriesResponseBody body;

    public static DeleteDentriesResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteDentriesResponse self = new DeleteDentriesResponse();
        return TeaModel.build(map, self);
    }

    public DeleteDentriesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteDentriesResponse setBody(DeleteDentriesResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteDentriesResponseBody getBody() {
        return this.body;
    }

}
