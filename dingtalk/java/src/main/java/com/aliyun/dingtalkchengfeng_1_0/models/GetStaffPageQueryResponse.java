// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetStaffPageQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetStaffPageQueryResponseBody body;

    public static GetStaffPageQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        GetStaffPageQueryResponse self = new GetStaffPageQueryResponse();
        return TeaModel.build(map, self);
    }

    public GetStaffPageQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetStaffPageQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetStaffPageQueryResponse setBody(GetStaffPageQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetStaffPageQueryResponseBody getBody() {
        return this.body;
    }

}
