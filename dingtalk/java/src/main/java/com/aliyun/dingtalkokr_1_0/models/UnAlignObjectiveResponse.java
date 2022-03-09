// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UnAlignObjectiveResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UnAlignObjectiveResponseBody body;

    public static UnAlignObjectiveResponse build(java.util.Map<String, ?> map) throws Exception {
        UnAlignObjectiveResponse self = new UnAlignObjectiveResponse();
        return TeaModel.build(map, self);
    }

    public UnAlignObjectiveResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UnAlignObjectiveResponse setBody(UnAlignObjectiveResponseBody body) {
        this.body = body;
        return this;
    }
    public UnAlignObjectiveResponseBody getBody() {
        return this.body;
    }

}
