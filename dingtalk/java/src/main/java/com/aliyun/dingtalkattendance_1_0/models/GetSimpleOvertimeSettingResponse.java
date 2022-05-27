// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetSimpleOvertimeSettingResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetSimpleOvertimeSettingResponseBody body;

    public static GetSimpleOvertimeSettingResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSimpleOvertimeSettingResponse self = new GetSimpleOvertimeSettingResponse();
        return TeaModel.build(map, self);
    }

    public GetSimpleOvertimeSettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSimpleOvertimeSettingResponse setBody(GetSimpleOvertimeSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSimpleOvertimeSettingResponseBody getBody() {
        return this.body;
    }

}
