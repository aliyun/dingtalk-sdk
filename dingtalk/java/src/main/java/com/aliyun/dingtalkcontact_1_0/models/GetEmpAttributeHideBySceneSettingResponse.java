// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetEmpAttributeHideBySceneSettingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetEmpAttributeHideBySceneSettingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetEmpAttributeHideBySceneSettingResponse setBody(GetEmpAttributeHideBySceneSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public GetEmpAttributeHideBySceneSettingResponseBody getBody() {
        return this.body;
    }

}
