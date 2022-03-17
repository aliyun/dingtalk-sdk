// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdatePrivacyResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdatePrivacyResponseBody body;

    public static UpdatePrivacyResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdatePrivacyResponse self = new UpdatePrivacyResponse();
        return TeaModel.build(map, self);
    }

    public UpdatePrivacyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdatePrivacyResponse setBody(UpdatePrivacyResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdatePrivacyResponseBody getBody() {
        return this.body;
    }

}
