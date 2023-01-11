// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgSecretKeyRequest extends TeaModel {
    /**
     * <p>合作方编码</p>
     */
    @NameInMap("isvCode")
    public String isvCode;

    /**
     * <p>操作人</p>
     */
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
