// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusGetCampusGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CampusGetCampusGroupResponseBody body;

    public static CampusGetCampusGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        CampusGetCampusGroupResponse self = new CampusGetCampusGroupResponse();
        return TeaModel.build(map, self);
    }

    public CampusGetCampusGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CampusGetCampusGroupResponse setBody(CampusGetCampusGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusGetCampusGroupResponseBody getBody() {
        return this.body;
    }

}
