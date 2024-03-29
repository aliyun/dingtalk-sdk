// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetContactHideBySceneSettingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetContactHideBySceneSettingResponseBody body;

    public static GetContactHideBySceneSettingResponse build(java.util.Map<String, ?> map) throws Exception {
        GetContactHideBySceneSettingResponse self = new GetContactHideBySceneSettingResponse();
        return TeaModel.build(map, self);
    }

    public GetContactHideBySceneSettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetContactHideBySceneSettingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetContactHideBySceneSettingResponse setBody(GetContactHideBySceneSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public GetContactHideBySceneSettingResponseBody getBody() {
        return this.body;
    }

}
