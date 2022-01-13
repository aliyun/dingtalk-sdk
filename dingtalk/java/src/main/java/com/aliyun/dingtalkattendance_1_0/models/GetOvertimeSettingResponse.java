// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetOvertimeSettingResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetOvertimeSettingResponse setBody(GetOvertimeSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOvertimeSettingResponseBody getBody() {
        return this.body;
    }

}
