// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupResponseBody extends TeaModel {
    @NameInMap("bizId")
    public String bizId;

    @NameInMap("groupName")
    public String groupName;

    @NameInMap("groupUrl")
    public String groupUrl;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    @NameInMap("openTeamId")
    public String openTeamId;

    @NameInMap("robotCode")
    public String robotCode;

    @NameInMap("robotName")
    public String robotName;

    public static QueryGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupResponseBody self = new QueryGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryGroupResponseBody setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public QueryGroupResponseBody setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public QueryGroupResponseBody setGroupUrl(String groupUrl) {
        this.groupUrl = groupUrl;
        return this;
    }
    public String getGroupUrl() {
        return this.groupUrl;
    }

    public QueryGroupResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public QueryGroupResponseBody setOpenGroupSetId(String openGroupSetId) {
        this.openGroupSetId = openGroupSetId;
        return this;
    }
    public String getOpenGroupSetId() {
        return this.openGroupSetId;
    }

    public QueryGroupResponseBody setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public QueryGroupResponseBody setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public QueryGroupResponseBody setRobotName(String robotName) {
        this.robotName = robotName;
        return this;
    }
    public String getRobotName() {
        return this.robotName;
    }

}
