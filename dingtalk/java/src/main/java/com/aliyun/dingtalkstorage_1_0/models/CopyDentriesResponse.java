// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class CopyDentriesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CopyDentriesResponseBody body;

    public static CopyDentriesResponse build(java.util.Map<String, ?> map) throws Exception {
        CopyDentriesResponse self = new CopyDentriesResponse();
        return TeaModel.build(map, self);
    }

    public CopyDentriesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CopyDentriesResponse setBody(CopyDentriesResponseBody body) {
        this.body = body;
        return this;
    }
    public CopyDentriesResponseBody getBody() {
        return this.body;
    }

}
