// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class InitMultipartFileUploadResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public InitMultipartFileUploadResponseBody body;

    public static InitMultipartFileUploadResponse build(java.util.Map<String, ?> map) throws Exception {
        InitMultipartFileUploadResponse self = new InitMultipartFileUploadResponse();
        return TeaModel.build(map, self);
    }

    public InitMultipartFileUploadResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InitMultipartFileUploadResponse setBody(InitMultipartFileUploadResponseBody body) {
        this.body = body;
        return this;
    }
    public InitMultipartFileUploadResponseBody getBody() {
        return this.body;
    }

}
