// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupManageQueryRequest extends TeaModel {
    @NameInMap("createdAfter")
    public Long createdAfter;

    @NameInMap("groupId")
    public String groupId;

    @NameInMap("groupMemberSamples")
    public java.util.List<String> groupMemberSamples;

    @NameInMap("groupOwner")
    public String groupOwner;

    @NameInMap("groupTitleKeywords")
    public java.util.List<String> groupTitleKeywords;

    @NameInMap("groupUrl")
    public String groupUrl;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("membersOver")
    public Integer membersOver;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("openConversationId")
    public String openConversationId;

    public static GroupManageQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        GroupManageQueryRequest self = new GroupManageQueryRequest();
        return TeaModel.build(map, self);
    }

    public GroupManageQueryRequest setCreatedAfter(Long createdAfter) {
        this.createdAfter = createdAfter;
        return this;
    }
    public Long getCreatedAfter() {
        return this.createdAfter;
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

    public GroupManageQueryRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GroupManageQueryRequest setMembersOver(Integer membersOver) {
        this.membersOver = membersOver;
        return this;
    }
    public Integer getMembersOver() {
        return this.membersOver;
    }

    public GroupManageQueryRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GroupManageQueryRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
