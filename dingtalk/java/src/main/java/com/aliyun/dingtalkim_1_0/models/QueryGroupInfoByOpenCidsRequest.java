// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupInfoByOpenCidsRequest extends TeaModel {
    @NameInMap("openConversationIds")
    public java.util.List<String> openConversationIds;

    public static QueryGroupInfoByOpenCidsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupInfoByOpenCidsRequest self = new QueryGroupInfoByOpenCidsRequest();
        return TeaModel.build(map, self);
    }

    public QueryGroupInfoByOpenCidsRequest setOpenConversationIds(java.util.List<String> openConversationIds) {
        this.openConversationIds = openConversationIds;
        return this;
    }
    public java.util.List<String> getOpenConversationIds() {
        return this.openConversationIds;
    }

}
