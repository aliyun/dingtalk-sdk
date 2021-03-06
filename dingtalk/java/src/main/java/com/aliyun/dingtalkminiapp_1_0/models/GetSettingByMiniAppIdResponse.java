// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class GetSettingByMiniAppIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetSettingByMiniAppIdResponse setBody(GetSettingByMiniAppIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSettingByMiniAppIdResponseBody getBody() {
        return this.body;
    }

}
