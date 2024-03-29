// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetOvertimeSettingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetOvertimeSettingResponseBody body;

    public static GetOvertimeSettingResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOvertimeSettingResponse self = new GetOvertimeSettingResponse();
        return TeaModel.build(map, self);
    }

    public GetOvertimeSettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOvertimeSettingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetOvertimeSettingResponse setBody(GetOvertimeSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOvertimeSettingResponseBody getBody() {
        return this.body;
    }

}
