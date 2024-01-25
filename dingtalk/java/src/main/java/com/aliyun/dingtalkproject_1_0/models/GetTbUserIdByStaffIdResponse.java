// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetTbUserIdByStaffIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetTbUserIdByStaffIdResponseBody body;

    public static GetTbUserIdByStaffIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTbUserIdByStaffIdResponse self = new GetTbUserIdByStaffIdResponse();
        return TeaModel.build(map, self);
    }

    public GetTbUserIdByStaffIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTbUserIdByStaffIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetTbUserIdByStaffIdResponse setBody(GetTbUserIdByStaffIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTbUserIdByStaffIdResponseBody getBody() {
        return this.body;
    }

}
