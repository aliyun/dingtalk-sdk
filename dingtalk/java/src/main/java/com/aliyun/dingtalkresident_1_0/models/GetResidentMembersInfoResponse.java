// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetResidentMembersInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetResidentMembersInfoResponseBody body;

    public static GetResidentMembersInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetResidentMembersInfoResponse self = new GetResidentMembersInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetResidentMembersInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetResidentMembersInfoResponse setBody(GetResidentMembersInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetResidentMembersInfoResponseBody getBody() {
        return this.body;
    }

}
