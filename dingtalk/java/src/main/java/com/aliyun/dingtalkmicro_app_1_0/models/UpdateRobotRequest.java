// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class UpdateRobotRequest extends TeaModel {
    @NameInMap("brief")
    public String brief;

    @NameInMap("chatBotEventUrl")
    public String chatBotEventUrl;

    @NameInMap("description")
    public String description;

    @NameInMap("iconMediaId")
    public String iconMediaId;

    @NameInMap("mode")
    public Integer mode;

    @NameInMap("name")
    public String name;

    @NameInMap("outgoingUrl")
    public String outgoingUrl;

    @NameInMap("unifiedAppId")
    public String unifiedAppId;

    @NameInMap("userId")
    public String userId;

    public static UpdateRobotRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateRobotRequest self = new UpdateRobotRequest();
        return TeaModel.build(map, self);
    }

    public UpdateRobotRequest setBrief(String brief) {
        this.brief = brief;
        return this;
    }
    public String getBrief() {
        return this.brief;
    }

    public UpdateRobotRequest setChatBotEventUrl(String chatBotEventUrl) {
        this.chatBotEventUrl = chatBotEventUrl;
        return this;
    }
    public String getChatBotEventUrl() {
        return this.chatBotEventUrl;
    }

    public UpdateRobotRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdateRobotRequest setIconMediaId(String iconMediaId) {
        this.iconMediaId = iconMediaId;
        return this;
    }
    public String getIconMediaId() {
        return this.iconMediaId;
    }

    public UpdateRobotRequest setMode(Integer mode) {
        this.mode = mode;
        return this;
    }
    public Integer getMode() {
        return this.mode;
    }

    public UpdateRobotRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateRobotRequest setOutgoingUrl(String outgoingUrl) {
        this.outgoingUrl = outgoingUrl;
        return this;
    }
    public String getOutgoingUrl() {
        return this.outgoingUrl;
    }

    public UpdateRobotRequest setUnifiedAppId(String unifiedAppId) {
        this.unifiedAppId = unifiedAppId;
        return this;
    }
    public String getUnifiedAppId() {
        return this.unifiedAppId;
    }

    public UpdateRobotRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
