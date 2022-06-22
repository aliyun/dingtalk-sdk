// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusUpdateCampusGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CampusUpdateCampusGroupResponseBody body;

    public static CampusUpdateCampusGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        CampusUpdateCampusGroupResponse self = new CampusUpdateCampusGroupResponse();
        return TeaModel.build(map, self);
    }

    public CampusUpdateCampusGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CampusUpdateCampusGroupResponse setBody(CampusUpdateCampusGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusUpdateCampusGroupResponseBody getBody() {
        return this.body;
    }

}
