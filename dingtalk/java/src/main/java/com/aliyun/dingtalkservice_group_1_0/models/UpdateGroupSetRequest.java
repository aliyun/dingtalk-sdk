// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupSetRequest extends TeaModel {
    // 开放群ID
    @NameInMap("openConversationId")
    public String openConversationId;

    // 开放群组ID
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    public static UpdateGroupSetRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupSetRequest self = new UpdateGroupSetRequest();
        return TeaModel.build(map, self);
    }

    public UpdateGroupSetRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public UpdateGroupSetRequest setOpenGroupSetId(String openGroupSetId) {
        this.openGroupSetId = openGroupSetId;
        return this;
    }
    public String getOpenGroupSetId() {
        return this.openGroupSetId;
    }

    public UpdateGroupSetRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
