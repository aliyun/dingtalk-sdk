// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetRelationUkSettingResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetRelationUkSettingResponseBody body;

    public static GetRelationUkSettingResponse build(java.util.Map<String, ?> map) throws Exception {
        GetRelationUkSettingResponse self = new GetRelationUkSettingResponse();
        return TeaModel.build(map, self);
    }

    public GetRelationUkSettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetRelationUkSettingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetRelationUkSettingResponse setBody(GetRelationUkSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRelationUkSettingResponseBody getBody() {
        return this.body;
    }

}
