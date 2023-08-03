// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetYongYouOrgRelationResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetYongYouOrgRelationResponseBody body;

    public static GetYongYouOrgRelationResponse build(java.util.Map<String, ?> map) throws Exception {
        GetYongYouOrgRelationResponse self = new GetYongYouOrgRelationResponse();
        return TeaModel.build(map, self);
    }

    public GetYongYouOrgRelationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetYongYouOrgRelationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetYongYouOrgRelationResponse setBody(GetYongYouOrgRelationResponseBody body) {
        this.body = body;
        return this;
    }
    public GetYongYouOrgRelationResponseBody getBody() {
        return this.body;
    }

}
