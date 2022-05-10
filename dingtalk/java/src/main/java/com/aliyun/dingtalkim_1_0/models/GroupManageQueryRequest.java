// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupManageQueryRequest extends TeaModel {
    // 群号
    @NameInMap("groupId")
    public String groupId;

    // 群成员样例工号列表
    @NameInMap("groupMemberSamples")
    public java.util.List<String> groupMemberSamples;

    // 群主工号
    @NameInMap("groupOwner")
    public String groupOwner;

    // 群标题关键词列表
    @NameInMap("groupTitleKeywords")
    public java.util.List<String> groupTitleKeywords;

    // 群链接
    @NameInMap("groupUrl")
    public String groupUrl;

    // 开放群id
    @NameInMap("openConversationId")
    public String openConversationId;

    public static GroupManageQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        GroupManageQueryRequest self = new GroupManageQueryRequest();
        return TeaModel.build(map, self);
    }

    public GroupManageQueryRequest setGroupId(String groupId) {
        this.groupId = groupId;
        return this;
    }
    public String getGroupId() {
        return this.groupId;
    }

    public GroupManageQueryRequest setGroupMemberSamples(java.util.List<String> groupMemberSamples) {
        this.groupMemberSamples = groupMemberSamples;
        return this;
    }
    public java.util.List<String> getGroupMemberSamples() {
        return this.groupMemberSamples;
    }

    public GroupManageQueryRequest setGroupOwner(String groupOwner) {
        this.groupOwner = groupOwner;
        return this;
    }
    public String getGroupOwner() {
        return this.groupOwner;
    }

    public GroupManageQueryRequest setGroupTitleKeywords(java.util.List<String> groupTitleKeywords) {
        this.groupTitleKeywords = groupTitleKeywords;
        return this;
    }
    public java.util.List<String> getGroupTitleKeywords() {
        return this.groupTitleKeywords;
    }

    public GroupManageQueryRequest setGroupUrl(String groupUrl) {
        this.groupUrl = groupUrl;
        return this;
    }
    public String getGroupUrl() {
        return this.groupUrl;
    }

    public GroupManageQueryRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
