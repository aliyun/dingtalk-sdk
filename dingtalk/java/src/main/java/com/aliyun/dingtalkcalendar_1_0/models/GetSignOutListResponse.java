// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetSignOutListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetSignOutListResponseBody body;

    public static GetSignOutListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSignOutListResponse self = new GetSignOutListResponse();
        return TeaModel.build(map, self);
    }

    public GetSignOutListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSignOutListResponse setBody(GetSignOutListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSignOutListResponseBody getBody() {
        return this.body;
    }

}
