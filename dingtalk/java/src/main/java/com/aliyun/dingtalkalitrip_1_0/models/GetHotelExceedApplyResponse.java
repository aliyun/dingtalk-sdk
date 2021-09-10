// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class GetHotelExceedApplyResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetHotelExceedApplyResponseBody body;

    public static GetHotelExceedApplyResponse build(java.util.Map<String, ?> map) throws Exception {
        GetHotelExceedApplyResponse self = new GetHotelExceedApplyResponse();
        return TeaModel.build(map, self);
    }

    public GetHotelExceedApplyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetHotelExceedApplyResponse setBody(GetHotelExceedApplyResponseBody body) {
        this.body = body;
        return this;
    }
    public GetHotelExceedApplyResponseBody getBody() {
        return this.body;
    }

}
