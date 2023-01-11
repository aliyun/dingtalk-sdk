// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class RobotMessageRecallRequest extends TeaModel {
    /**
     * <p>开放群id</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>开放消息ID</p>
     */
    @NameInMap("openMsgId")
    public String openMsgId;

    /**
     * <p>开发团队ID</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    public static RobotMessageRecallRequest build(java.util.Map<String, ?> map) throws Exception {
        RobotMessageRecallRequest self = new RobotMessageRecallRequest();
        return TeaModel.build(map, self);
    }

    public RobotMessageRecallRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public RobotMessageRecallRequest setOpenMsgId(String openMsgId) {
        this.openMsgId = openMsgId;
        return this;
    }
    public String getOpenMsgId() {
        return this.openMsgId;
    }

    public RobotMessageRecallRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
