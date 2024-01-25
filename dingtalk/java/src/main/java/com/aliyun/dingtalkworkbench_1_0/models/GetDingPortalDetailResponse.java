// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class GetDingPortalDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetDingPortalDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDingPortalDetailResponse setBody(GetDingPortalDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDingPortalDetailResponseBody getBody() {
        return this.body;
    }

}
