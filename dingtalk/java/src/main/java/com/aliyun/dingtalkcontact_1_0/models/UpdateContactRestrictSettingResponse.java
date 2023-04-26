// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateContactRestrictSettingResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateContactRestrictSettingResponseBody body;

    public static UpdateContactRestrictSettingResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateContactRestrictSettingResponse self = new UpdateContactRestrictSettingResponse();
        return TeaModel.build(map, self);
    }

    public UpdateContactRestrictSettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateContactRestrictSettingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateContactRestrictSettingResponse setBody(UpdateContactRestrictSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateContactRestrictSettingResponseBody getBody() {
        return this.body;
    }

}
