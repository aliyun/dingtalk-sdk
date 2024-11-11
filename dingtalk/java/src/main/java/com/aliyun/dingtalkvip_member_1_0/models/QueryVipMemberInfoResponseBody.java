// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvip_member_1_0.models;

import com.aliyun.tea.*;

public class QueryVipMemberInfoResponseBody extends TeaModel {
    @NameInMap("isVip")
    public Boolean isVip;

    public static QueryVipMemberInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryVipMemberInfoResponseBody self = new QueryVipMemberInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryVipMemberInfoResponseBody setIsVip(Boolean isVip) {
        this.isVip = isVip;
        return this;
    }
    public Boolean getIsVip() {
        return this.isVip;
    }

}
