// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdatePrivacyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public UpdatePrivacyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdatePrivacyResponse setBody(UpdatePrivacyResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdatePrivacyResponseBody getBody() {
        return this.body;
    }

}
