// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvip_member_1_0.models;

import com.aliyun.tea.*;

public class QueryVipMemberInfoResponseBody extends TeaModel {
    @NameInMap("expireTime")
    public String expireTime;

    @NameInMap("isVip")
    public Boolean isVip;

    public static QueryVipMemberInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryVipMemberInfoResponseBody self = new QueryVipMemberInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryVipMemberInfoResponseBody setExpireTime(String expireTime) {
        this.expireTime = expireTime;
        return this;
    }
    public String getExpireTime() {
        return this.expireTime;
    }

    public QueryVipMemberInfoResponseBody setIsVip(Boolean isVip) {
        this.isVip = isVip;
        return this;
    }
    public Boolean getIsVip() {
        return this.isVip;
    }

}
