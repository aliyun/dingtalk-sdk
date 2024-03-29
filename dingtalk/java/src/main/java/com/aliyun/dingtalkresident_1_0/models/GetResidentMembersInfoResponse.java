// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetResidentMembersInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetResidentMembersInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetResidentMembersInfoResponse setBody(GetResidentMembersInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetResidentMembersInfoResponseBody getBody() {
        return this.body;
    }

}
