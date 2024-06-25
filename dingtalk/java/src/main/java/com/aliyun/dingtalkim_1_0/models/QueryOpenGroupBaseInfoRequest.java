// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryOpenGroupBaseInfoRequest extends TeaModel {
    @NameInMap("openConversationId")
    public String openConversationId;

    public static QueryOpenGroupBaseInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryOpenGroupBaseInfoRequest self = new QueryOpenGroupBaseInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryOpenGroupBaseInfoRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
