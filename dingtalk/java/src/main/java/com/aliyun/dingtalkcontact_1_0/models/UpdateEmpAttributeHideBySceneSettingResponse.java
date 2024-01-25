// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateEmpAttributeHideBySceneSettingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateEmpAttributeHideBySceneSettingResponseBody body;

    public static UpdateEmpAttributeHideBySceneSettingResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateEmpAttributeHideBySceneSettingResponse self = new UpdateEmpAttributeHideBySceneSettingResponse();
        return TeaModel.build(map, self);
    }

    public UpdateEmpAttributeHideBySceneSettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateEmpAttributeHideBySceneSettingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateEmpAttributeHideBySceneSettingResponse setBody(UpdateEmpAttributeHideBySceneSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateEmpAttributeHideBySceneSettingResponseBody getBody() {
        return this.body;
    }

}
