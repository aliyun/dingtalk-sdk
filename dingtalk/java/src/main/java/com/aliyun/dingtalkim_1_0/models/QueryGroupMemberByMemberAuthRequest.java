// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMemberByMemberAuthRequest extends TeaModel {
    /**
     * <p>酷应用编码</p>
     */
    @NameInMap("coolAppCode")
    public String coolAppCode;

    /**
     * <p>群的openConversationId</p>
     */
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
