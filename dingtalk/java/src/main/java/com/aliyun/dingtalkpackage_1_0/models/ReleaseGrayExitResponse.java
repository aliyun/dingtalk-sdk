// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class ReleaseGrayExitResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ReleaseGrayExitResponseBody body;

    public static ReleaseGrayExitResponse build(java.util.Map<String, ?> map) throws Exception {
        ReleaseGrayExitResponse self = new ReleaseGrayExitResponse();
        return TeaModel.build(map, self);
    }

    public ReleaseGrayExitResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ReleaseGrayExitResponse setBody(ReleaseGrayExitResponseBody body) {
        this.body = body;
        return this;
    }
    public ReleaseGrayExitResponseBody getBody() {
        return this.body;
    }

}
