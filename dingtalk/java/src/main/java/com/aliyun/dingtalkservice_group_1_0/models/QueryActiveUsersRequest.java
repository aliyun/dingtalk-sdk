// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryActiveUsersRequest extends TeaModel {
    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    // 开放群ID
    @NameInMap("openConversationId")
    public String openConversationId;

    // 查询topN的数据
    @NameInMap("topN")
    public Long topN;

    public static QueryActiveUsersRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryActiveUsersRequest self = new QueryActiveUsersRequest();
        return TeaModel.build(map, self);
    }

    public QueryActiveUsersRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public QueryActiveUsersRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public QueryActiveUsersRequest setTopN(Long topN) {
        this.topN = topN;
        return this;
    }
    public Long getTopN() {
        return this.topN;
    }

}
