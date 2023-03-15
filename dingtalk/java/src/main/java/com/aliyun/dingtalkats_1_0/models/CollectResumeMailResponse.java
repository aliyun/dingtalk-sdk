// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class CollectResumeMailResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CollectResumeMailResponseBody body;

    public static CollectResumeMailResponse build(java.util.Map<String, ?> map) throws Exception {
        CollectResumeMailResponse self = new CollectResumeMailResponse();
        return TeaModel.build(map, self);
    }

    public CollectResumeMailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollectResumeMailResponse setBody(CollectResumeMailResponseBody body) {
        this.body = body;
        return this;
    }
    public CollectResumeMailResponseBody getBody() {
        return this.body;
    }

}
