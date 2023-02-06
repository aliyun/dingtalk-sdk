// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetEmpAttributeHideBySceneSettingResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetEmpAttributeHideBySceneSettingResponseBody body;

    public static GetEmpAttributeHideBySceneSettingResponse build(java.util.Map<String, ?> map) throws Exception {
        GetEmpAttributeHideBySceneSettingResponse self = new GetEmpAttributeHideBySceneSettingResponse();
        return TeaModel.build(map, self);
    }

    public GetEmpAttributeHideBySceneSettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetEmpAttributeHideBySceneSettingResponse setBody(GetEmpAttributeHideBySceneSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public GetEmpAttributeHideBySceneSettingResponseBody getBody() {
        return this.body;
    }

}
