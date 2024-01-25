// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateMemberGroupNickResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateMemberGroupNickResponseBody body;

    public static UpdateMemberGroupNickResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateMemberGroupNickResponse self = new UpdateMemberGroupNickResponse();
        return TeaModel.build(map, self);
    }

    public UpdateMemberGroupNickResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateMemberGroupNickResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateMemberGroupNickResponse setBody(UpdateMemberGroupNickResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateMemberGroupNickResponseBody getBody() {
        return this.body;
    }

}
