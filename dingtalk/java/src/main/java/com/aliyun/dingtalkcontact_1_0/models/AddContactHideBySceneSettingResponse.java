// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class AddContactHideBySceneSettingResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public AddContactHideBySceneSettingResponse setBody(AddContactHideBySceneSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public AddContactHideBySceneSettingResponseBody getBody() {
        return this.body;
    }

}
