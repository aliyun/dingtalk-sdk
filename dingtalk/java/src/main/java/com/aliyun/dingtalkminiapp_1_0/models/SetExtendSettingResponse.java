// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class SetExtendSettingResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public SetExtendSettingResponse setBody(SetExtendSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public SetExtendSettingResponseBody getBody() {
        return this.body;
    }

}
