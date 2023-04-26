// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupAvatarResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateGroupAvatarResponseBody body;

    public static UpdateGroupAvatarResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupAvatarResponse self = new UpdateGroupAvatarResponse();
        return TeaModel.build(map, self);
    }

    public UpdateGroupAvatarResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateGroupAvatarResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateGroupAvatarResponse setBody(UpdateGroupAvatarResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateGroupAvatarResponseBody getBody() {
        return this.body;
    }

}
