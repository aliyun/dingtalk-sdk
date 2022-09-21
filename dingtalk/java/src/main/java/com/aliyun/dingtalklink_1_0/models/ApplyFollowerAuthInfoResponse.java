// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class ApplyFollowerAuthInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ApplyFollowerAuthInfoResponseBody body;

    public static ApplyFollowerAuthInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        ApplyFollowerAuthInfoResponse self = new ApplyFollowerAuthInfoResponse();
        return TeaModel.build(map, self);
    }

    public ApplyFollowerAuthInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ApplyFollowerAuthInfoResponse setBody(ApplyFollowerAuthInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public ApplyFollowerAuthInfoResponseBody getBody() {
        return this.body;
    }

}
