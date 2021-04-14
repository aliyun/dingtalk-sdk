// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetApplyInviteInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetApplyInviteInfoResponseBody body;

    public static GetApplyInviteInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetApplyInviteInfoResponse self = new GetApplyInviteInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetApplyInviteInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetApplyInviteInfoResponse setBody(GetApplyInviteInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetApplyInviteInfoResponseBody getBody() {
        return this.body;
    }

}
