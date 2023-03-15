// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class CommitFileResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

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

    public CommitFileResponse setBody(CommitFileResponseBody body) {
        this.body = body;
        return this;
    }
    public CommitFileResponseBody getBody() {
        return this.body;
    }

}
