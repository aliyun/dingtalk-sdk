// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgTypeResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("orgType")
    public Long orgType;

    public static QueryOrgTypeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgTypeResponseBody self = new QueryOrgTypeResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryOrgTypeResponseBody setOrgType(Long orgType) {
        this.orgType = orgType;
        return this;
    }
    public Long getOrgType() {
        return this.orgType;
    }

}
