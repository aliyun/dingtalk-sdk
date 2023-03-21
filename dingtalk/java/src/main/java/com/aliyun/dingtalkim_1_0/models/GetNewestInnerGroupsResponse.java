// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetNewestInnerGroupsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetNewestInnerGroupsResponseBody body;

    public static GetNewestInnerGroupsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetNewestInnerGroupsResponse self = new GetNewestInnerGroupsResponse();
        return TeaModel.build(map, self);
    }

    public GetNewestInnerGroupsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetNewestInnerGroupsResponse setBody(GetNewestInnerGroupsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetNewestInnerGroupsResponseBody getBody() {
        return this.body;
    }

}
