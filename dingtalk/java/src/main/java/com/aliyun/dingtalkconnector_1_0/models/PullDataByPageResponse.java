// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class PullDataByPageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public PullDataByPageResponseBody body;

    public static PullDataByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        PullDataByPageResponse self = new PullDataByPageResponse();
        return TeaModel.build(map, self);
    }

    public PullDataByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PullDataByPageResponse setBody(PullDataByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public PullDataByPageResponseBody getBody() {
        return this.body;
    }

}
