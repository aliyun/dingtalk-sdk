// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class GetSettingByMiniAppIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSettingByMiniAppIdResponseBody body;

    public static GetSettingByMiniAppIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSettingByMiniAppIdResponse self = new GetSettingByMiniAppIdResponse();
        return TeaModel.build(map, self);
    }

    public GetSettingByMiniAppIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSettingByMiniAppIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSettingByMiniAppIdResponse setBody(GetSettingByMiniAppIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSettingByMiniAppIdResponseBody getBody() {
        return this.body;
    }

}
