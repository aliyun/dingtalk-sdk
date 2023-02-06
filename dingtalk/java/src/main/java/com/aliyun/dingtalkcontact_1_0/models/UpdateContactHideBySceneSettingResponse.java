// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateContactHideBySceneSettingResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public UpdateContactHideBySceneSettingResponse setBody(UpdateContactHideBySceneSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateContactHideBySceneSettingResponseBody getBody() {
        return this.body;
    }

}
