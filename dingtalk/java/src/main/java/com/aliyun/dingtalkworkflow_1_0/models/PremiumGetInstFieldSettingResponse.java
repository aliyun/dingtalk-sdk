// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetInstFieldSettingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumGetInstFieldSettingResponseBody body;

    public static PremiumGetInstFieldSettingResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetInstFieldSettingResponse self = new PremiumGetInstFieldSettingResponse();
        return TeaModel.build(map, self);
    }

    public PremiumGetInstFieldSettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumGetInstFieldSettingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumGetInstFieldSettingResponse setBody(PremiumGetInstFieldSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumGetInstFieldSettingResponseBody getBody() {
        return this.body;
    }

}
