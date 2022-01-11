// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupRequest extends TeaModel {
    // 业务关联ID，和开放群ID二选一传
    @NameInMap("bizId")
    public String bizId;

    // 开放群ID
    @NameInMap("openConversationId")
    public String openConversationId;

    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    public static QueryGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupRequest self = new QueryGroupRequest();
        return TeaModel.build(map, self);
    }

    public QueryGroupRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public QueryGroupRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public QueryGroupRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
