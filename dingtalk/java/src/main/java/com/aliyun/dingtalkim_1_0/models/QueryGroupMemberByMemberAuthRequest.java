// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMemberByMemberAuthRequest extends TeaModel {
    // 酷应用编码
    @NameInMap("coolAppCode")
    public String coolAppCode;

    // 群的openConversationId
    @NameInMap("openConversationId")
    public String openConversationId;

    public static QueryGroupMemberByMemberAuthRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupMemberByMemberAuthRequest self = new QueryGroupMemberByMemberAuthRequest();
        return TeaModel.build(map, self);
    }

    public QueryGroupMemberByMemberAuthRequest setCoolAppCode(String coolAppCode) {
        this.coolAppCode = coolAppCode;
        return this;
    }
    public String getCoolAppCode() {
        return this.coolAppCode;
    }

    public QueryGroupMemberByMemberAuthRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
