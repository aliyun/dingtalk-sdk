// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCustomerTracksByRelationIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetCustomerTracksByRelationIdResponseBody body;

    public static GetCustomerTracksByRelationIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCustomerTracksByRelationIdResponse self = new GetCustomerTracksByRelationIdResponse();
        return TeaModel.build(map, self);
    }

    public GetCustomerTracksByRelationIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCustomerTracksByRelationIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCustomerTracksByRelationIdResponse setBody(GetCustomerTracksByRelationIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCustomerTracksByRelationIdResponseBody getBody() {
        return this.body;
    }

}
