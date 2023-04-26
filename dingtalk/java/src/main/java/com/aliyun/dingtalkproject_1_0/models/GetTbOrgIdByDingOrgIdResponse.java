// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetTbOrgIdByDingOrgIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetTbOrgIdByDingOrgIdResponseBody body;

    public static GetTbOrgIdByDingOrgIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTbOrgIdByDingOrgIdResponse self = new GetTbOrgIdByDingOrgIdResponse();
        return TeaModel.build(map, self);
    }

    public GetTbOrgIdByDingOrgIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTbOrgIdByDingOrgIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetTbOrgIdByDingOrgIdResponse setBody(GetTbOrgIdByDingOrgIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTbOrgIdByDingOrgIdResponseBody getBody() {
        return this.body;
    }

}
