// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetCooperateOrgInviteInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetCooperateOrgInviteInfoResponseBody body;

    public static GetCooperateOrgInviteInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCooperateOrgInviteInfoResponse self = new GetCooperateOrgInviteInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetCooperateOrgInviteInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCooperateOrgInviteInfoResponse setBody(GetCooperateOrgInviteInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCooperateOrgInviteInfoResponseBody getBody() {
        return this.body;
    }

}
