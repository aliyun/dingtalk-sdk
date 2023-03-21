// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetInnerGroupMembersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetInnerGroupMembersResponseBody body;

    public static GetInnerGroupMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        GetInnerGroupMembersResponse self = new GetInnerGroupMembersResponse();
        return TeaModel.build(map, self);
    }

    public GetInnerGroupMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetInnerGroupMembersResponse setBody(GetInnerGroupMembersResponseBody body) {
        this.body = body;
        return this;
    }
    public GetInnerGroupMembersResponseBody getBody() {
        return this.body;
    }

}
