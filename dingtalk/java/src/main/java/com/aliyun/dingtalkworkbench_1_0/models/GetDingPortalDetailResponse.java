// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class GetDingPortalDetailResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetDingPortalDetailResponseBody body;

    public static GetDingPortalDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDingPortalDetailResponse self = new GetDingPortalDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetDingPortalDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDingPortalDetailResponse setBody(GetDingPortalDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDingPortalDetailResponseBody getBody() {
        return this.body;
    }

}
