// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetTbUserIdByStaffIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetTbUserIdByStaffIdResponse setBody(GetTbUserIdByStaffIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTbUserIdByStaffIdResponseBody getBody() {
        return this.body;
    }

}
