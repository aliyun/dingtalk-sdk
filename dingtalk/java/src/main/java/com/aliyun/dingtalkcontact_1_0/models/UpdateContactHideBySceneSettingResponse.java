// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateContactHideBySceneSettingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateContactHideBySceneSettingResponseBody body;

    public static UpdateContactHideBySceneSettingResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateContactHideBySceneSettingResponse self = new UpdateContactHideBySceneSettingResponse();
        return TeaModel.build(map, self);
    }

    public UpdateContactHideBySceneSettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateContactHideBySceneSettingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateContactHideBySceneSettingResponse setBody(UpdateContactHideBySceneSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateContactHideBySceneSettingResponseBody getBody() {
        return this.body;
    }

}
