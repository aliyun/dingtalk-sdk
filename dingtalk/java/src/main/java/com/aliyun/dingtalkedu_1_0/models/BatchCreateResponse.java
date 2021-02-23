// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class BatchCreateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public BatchCreateResponseBody body;

    public static BatchCreateResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchCreateResponse self = new BatchCreateResponse();
        return TeaModel.build(map, self);
    }

    public BatchCreateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchCreateResponse setBody(BatchCreateResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchCreateResponseBody getBody() {
        return this.body;
    }

}
