// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgSecretKeyRequest extends TeaModel {
    @NameInMap("isvCode")
    public String isvCode;

    @NameInMap("opUserId")
    public String opUserId;

    public static QueryOrgSecretKeyRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgSecretKeyRequest self = new QueryOrgSecretKeyRequest();
        return TeaModel.build(map, self);
    }

    public QueryOrgSecretKeyRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public QueryOrgSecretKeyRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
