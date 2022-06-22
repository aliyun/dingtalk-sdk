// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusGetCampusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CampusGetCampusResponseBody body;

    public static CampusGetCampusResponse build(java.util.Map<String, ?> map) throws Exception {
        CampusGetCampusResponse self = new CampusGetCampusResponse();
        return TeaModel.build(map, self);
    }

    public CampusGetCampusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CampusGetCampusResponse setBody(CampusGetCampusResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusGetCampusResponseBody getBody() {
        return this.body;
    }

}
