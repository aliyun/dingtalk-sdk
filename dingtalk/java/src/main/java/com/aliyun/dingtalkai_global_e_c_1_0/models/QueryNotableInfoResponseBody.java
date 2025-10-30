// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class QueryNotableInfoResponseBody extends TeaModel {
    @NameInMap("adminUnionIds")
    public java.util.List<String> adminUnionIds;

    @NameInMap("baseId")
    public String baseId;

    public static QueryNotableInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryNotableInfoResponseBody self = new QueryNotableInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryNotableInfoResponseBody setAdminUnionIds(java.util.List<String> adminUnionIds) {
        this.adminUnionIds = adminUnionIds;
        return this;
    }
    public java.util.List<String> getAdminUnionIds() {
        return this.adminUnionIds;
    }

    public QueryNotableInfoResponseBody setBaseId(String baseId) {
        this.baseId = baseId;
        return this;
    }
    public String getBaseId() {
        return this.baseId;
    }

}
