// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class FinishBeginnerTaskResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public FinishBeginnerTaskResponseBody body;

    public static FinishBeginnerTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        FinishBeginnerTaskResponse self = new FinishBeginnerTaskResponse();
        return TeaModel.build(map, self);
    }

    public FinishBeginnerTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public FinishBeginnerTaskResponse setBody(FinishBeginnerTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public FinishBeginnerTaskResponseBody getBody() {
        return this.body;
    }

}
