// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetSuperAdminOpenSceneGroupInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSuperAdminOpenSceneGroupInfoResponseBody body;

    public static GetSuperAdminOpenSceneGroupInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSuperAdminOpenSceneGroupInfoResponse self = new GetSuperAdminOpenSceneGroupInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetSuperAdminOpenSceneGroupInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSuperAdminOpenSceneGroupInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSuperAdminOpenSceneGroupInfoResponse setBody(GetSuperAdminOpenSceneGroupInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSuperAdminOpenSceneGroupInfoResponseBody getBody() {
        return this.body;
    }

}
