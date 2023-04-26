// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class DeleteContactHideBySceneSettingResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteContactHideBySceneSettingResponseBody body;

    public static DeleteContactHideBySceneSettingResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteContactHideBySceneSettingResponse self = new DeleteContactHideBySceneSettingResponse();
        return TeaModel.build(map, self);
    }

    public DeleteContactHideBySceneSettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteContactHideBySceneSettingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteContactHideBySceneSettingResponse setBody(DeleteContactHideBySceneSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteContactHideBySceneSettingResponseBody getBody() {
        return this.body;
    }

}
