// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateSeniorSettingResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static UpdateSeniorSettingResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateSeniorSettingResponse self = new UpdateSeniorSettingResponse();
        return TeaModel.build(map, self);
    }

    public UpdateSeniorSettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
