// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class DeleteEmpAttributeHideBySceneSettingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteEmpAttributeHideBySceneSettingResponseBody body;

    public static DeleteEmpAttributeHideBySceneSettingResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteEmpAttributeHideBySceneSettingResponse self = new DeleteEmpAttributeHideBySceneSettingResponse();
        return TeaModel.build(map, self);
    }

    public DeleteEmpAttributeHideBySceneSettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteEmpAttributeHideBySceneSettingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteEmpAttributeHideBySceneSettingResponse setBody(DeleteEmpAttributeHideBySceneSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteEmpAttributeHideBySceneSettingResponseBody getBody() {
        return this.body;
    }

}
