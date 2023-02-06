// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class AddEmpAttributeHideBySceneSettingResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AddEmpAttributeHideBySceneSettingResponseBody body;

    public static AddEmpAttributeHideBySceneSettingResponse build(java.util.Map<String, ?> map) throws Exception {
        AddEmpAttributeHideBySceneSettingResponse self = new AddEmpAttributeHideBySceneSettingResponse();
        return TeaModel.build(map, self);
    }

    public AddEmpAttributeHideBySceneSettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddEmpAttributeHideBySceneSettingResponse setBody(AddEmpAttributeHideBySceneSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public AddEmpAttributeHideBySceneSettingResponseBody getBody() {
        return this.body;
    }

}
