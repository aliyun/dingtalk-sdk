// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class UpdateMemberNickResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateMemberNickResponseBody body;

    public static UpdateMemberNickResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateMemberNickResponse self = new UpdateMemberNickResponse();
        return TeaModel.build(map, self);
    }

    public UpdateMemberNickResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateMemberNickResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateMemberNickResponse setBody(UpdateMemberNickResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateMemberNickResponseBody getBody() {
        return this.body;
    }

}
