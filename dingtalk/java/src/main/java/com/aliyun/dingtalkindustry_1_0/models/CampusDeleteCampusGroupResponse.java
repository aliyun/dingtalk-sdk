// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusDeleteCampusGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CampusDeleteCampusGroupResponseBody body;

    public static CampusDeleteCampusGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        CampusDeleteCampusGroupResponse self = new CampusDeleteCampusGroupResponse();
        return TeaModel.build(map, self);
    }

    public CampusDeleteCampusGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CampusDeleteCampusGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CampusDeleteCampusGroupResponse setBody(CampusDeleteCampusGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusDeleteCampusGroupResponseBody getBody() {
        return this.body;
    }

}
