// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class SetExtendSettingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetExtendSettingResponseBody body;

    public static SetExtendSettingResponse build(java.util.Map<String, ?> map) throws Exception {
        SetExtendSettingResponse self = new SetExtendSettingResponse();
        return TeaModel.build(map, self);
    }

    public SetExtendSettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetExtendSettingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetExtendSettingResponse setBody(SetExtendSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public SetExtendSettingResponseBody getBody() {
        return this.body;
    }

}
