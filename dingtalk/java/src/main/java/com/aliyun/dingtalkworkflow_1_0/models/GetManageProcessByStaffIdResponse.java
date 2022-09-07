// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetManageProcessByStaffIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetManageProcessByStaffIdResponse setBody(GetManageProcessByStaffIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetManageProcessByStaffIdResponseBody getBody() {
        return this.body;
    }

}
