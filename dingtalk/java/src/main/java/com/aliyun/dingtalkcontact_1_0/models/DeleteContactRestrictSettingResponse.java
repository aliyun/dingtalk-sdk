// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class DeleteContactRestrictSettingResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteContactRestrictSettingResponseBody body;

    public static DeleteContactRestrictSettingResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteContactRestrictSettingResponse self = new DeleteContactRestrictSettingResponse();
        return TeaModel.build(map, self);
    }

    public DeleteContactRestrictSettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteContactRestrictSettingResponse setBody(DeleteContactRestrictSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteContactRestrictSettingResponseBody getBody() {
        return this.body;
    }

}
