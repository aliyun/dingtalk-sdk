// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class ConfirmRightsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ConfirmRightsResponseBody body;

    public static ConfirmRightsResponse build(java.util.Map<String, ?> map) throws Exception {
        ConfirmRightsResponse self = new ConfirmRightsResponse();
        return TeaModel.build(map, self);
    }

    public ConfirmRightsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ConfirmRightsResponse setBody(ConfirmRightsResponseBody body) {
        this.body = body;
        return this;
    }
    public ConfirmRightsResponseBody getBody() {
        return this.body;
    }

}
