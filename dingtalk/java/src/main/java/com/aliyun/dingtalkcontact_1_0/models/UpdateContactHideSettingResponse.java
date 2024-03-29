// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateContactHideSettingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateContactHideSettingResponseBody body;

    public static UpdateContactHideSettingResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateContactHideSettingResponse self = new UpdateContactHideSettingResponse();
        return TeaModel.build(map, self);
    }

    public UpdateContactHideSettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateContactHideSettingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateContactHideSettingResponse setBody(UpdateContactHideSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateContactHideSettingResponseBody getBody() {
        return this.body;
    }

}
