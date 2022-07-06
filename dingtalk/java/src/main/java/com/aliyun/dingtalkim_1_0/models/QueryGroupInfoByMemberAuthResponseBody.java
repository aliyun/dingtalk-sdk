// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupInfoByMemberAuthResponseBody extends TeaModel {
    // 群内总人数
    @NameInMap("memberCount")
    public Integer memberCount;

    public static QueryGroupInfoByMemberAuthResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupInfoByMemberAuthResponseBody self = new QueryGroupInfoByMemberAuthResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryGroupInfoByMemberAuthResponseBody setMemberCount(Integer memberCount) {
        this.memberCount = memberCount;
        return this;
    }
    public Integer getMemberCount() {
        return this.memberCount;
    }

}
