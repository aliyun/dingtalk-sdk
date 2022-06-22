// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusUpdateCampusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CampusUpdateCampusResponseBody body;

    public static CampusUpdateCampusResponse build(java.util.Map<String, ?> map) throws Exception {
        CampusUpdateCampusResponse self = new CampusUpdateCampusResponse();
        return TeaModel.build(map, self);
    }

    public CampusUpdateCampusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CampusUpdateCampusResponse setBody(CampusUpdateCampusResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusUpdateCampusResponseBody getBody() {
        return this.body;
    }

}
