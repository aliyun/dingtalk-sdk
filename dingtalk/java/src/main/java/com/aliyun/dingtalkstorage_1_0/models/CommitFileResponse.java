// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class CommitFileResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CommitFileResponseBody body;

    public static CommitFileResponse build(java.util.Map<String, ?> map) throws Exception {
        CommitFileResponse self = new CommitFileResponse();
        return TeaModel.build(map, self);
    }

    public CommitFileResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CommitFileResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CommitFileResponse setBody(CommitFileResponseBody body) {
        this.body = body;
        return this;
    }
    public CommitFileResponseBody getBody() {
        return this.body;
    }

}
