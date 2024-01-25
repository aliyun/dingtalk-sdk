// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetManageProcessByStaffIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetManageProcessByStaffIdResponseBody body;

    public static GetManageProcessByStaffIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetManageProcessByStaffIdResponse self = new GetManageProcessByStaffIdResponse();
        return TeaModel.build(map, self);
    }

    public GetManageProcessByStaffIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetManageProcessByStaffIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetManageProcessByStaffIdResponse setBody(GetManageProcessByStaffIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetManageProcessByStaffIdResponseBody getBody() {
        return this.body;
    }

}
