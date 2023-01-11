// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMemberRequest extends TeaModel {
    /**
     * <p>群开放ID</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>开放团队ID</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static QueryGroupMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupMemberRequest self = new QueryGroupMemberRequest();
        return TeaModel.build(map, self);
    }

    public QueryGroupMemberRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public QueryGroupMemberRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public QueryGroupMemberRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
