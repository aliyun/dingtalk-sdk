// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class AddContactHideBySceneSettingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddContactHideBySceneSettingResponseBody body;

    public static AddContactHideBySceneSettingResponse build(java.util.Map<String, ?> map) throws Exception {
        AddContactHideBySceneSettingResponse self = new AddContactHideBySceneSettingResponse();
        return TeaModel.build(map, self);
    }

    public AddContactHideBySceneSettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddContactHideBySceneSettingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddContactHideBySceneSettingResponse setBody(AddContactHideBySceneSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public AddContactHideBySceneSettingResponseBody getBody() {
        return this.body;
    }

}
