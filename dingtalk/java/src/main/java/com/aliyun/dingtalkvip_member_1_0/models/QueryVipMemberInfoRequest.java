// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvip_member_1_0.models;

import com.aliyun.tea.*;

public class QueryVipMemberInfoRequest extends TeaModel {
    @NameInMap("channelCode")
    public String channelCode;

    public static QueryVipMemberInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryVipMemberInfoRequest self = new QueryVipMemberInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryVipMemberInfoRequest setChannelCode(String channelCode) {
        this.channelCode = channelCode;
        return this;
    }
    public String getChannelCode() {
        return this.channelCode;
    }

}
