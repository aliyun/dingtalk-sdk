// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgTypeResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1, &quot;省级教育厅&quot;;2, &quot;市级教育局&quot;;3, &quot;区县教育局&quot;;4, &quot;中心校&quot;;5, &quot;普通学校&quot;</p>
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
