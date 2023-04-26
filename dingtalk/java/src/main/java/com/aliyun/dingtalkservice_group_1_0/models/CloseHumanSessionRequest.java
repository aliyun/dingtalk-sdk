// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CloseHumanSessionRequest extends TeaModel {
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("openTeamId")
    public String openTeamId;

    public static CloseHumanSessionRequest build(java.util.Map<String, ?> map) throws Exception {
        CloseHumanSessionRequest self = new CloseHumanSessionRequest();
        return TeaModel.build(map, self);
    }

    public CloseHumanSessionRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public CloseHumanSessionRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
