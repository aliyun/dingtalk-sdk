// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupInfoByMemberAuthRequest extends TeaModel {
    @NameInMap("coolAppCode")
    public String coolAppCode;

    @NameInMap("openConversationId")
    public String openConversationId;

    public static QueryGroupInfoByMemberAuthRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupInfoByMemberAuthRequest self = new QueryGroupInfoByMemberAuthRequest();
        return TeaModel.build(map, self);
    }

    public QueryGroupInfoByMemberAuthRequest setCoolAppCode(String coolAppCode) {
        this.coolAppCode = coolAppCode;
        return this;
    }
    public String getCoolAppCode() {
        return this.coolAppCode;
    }

    public QueryGroupInfoByMemberAuthRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
