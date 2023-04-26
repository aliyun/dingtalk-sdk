// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetGroupSetResponseBody extends TeaModel {
    @NameInMap("gmtCreate")
    public String gmtCreate;

    @NameInMap("gmtModified")
    public String gmtModified;

    @NameInMap("groupChatCount")
    public Integer groupChatCount;

    @NameInMap("inviteLink")
    public String inviteLink;

    @NameInMap("lastOpenConversationId")
    public String lastOpenConversationId;

    @NameInMap("manager")
    public java.util.List<GetGroupSetResponseBodyManager> manager;

    @NameInMap("managerUserIds")
    public String managerUserIds;

    @NameInMap("memberCount")
    public Integer memberCount;

    @NameInMap("memberQuota")
    public Integer memberQuota;

    @NameInMap("name")
    public String name;

    @NameInMap("notice")
    public String notice;

    @NameInMap("noticeToped")
    public Integer noticeToped;

    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    @NameInMap("owner")
    public GetGroupSetResponseBodyOwner owner;

    @NameInMap("ownerUserId")
    public String ownerUserId;

    @NameInMap("relationType")
    public String relationType;

    @NameInMap("templateId")
    public String templateId;

    public static GetGroupSetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetGroupSetResponseBody self = new GetGroupSetResponseBody();
        return TeaModel.build(map, self);
    }

    public GetGroupSetResponseBody setGmtCreate(String gmtCreate) {
        this.gmtCreate = gmtCreate;
        return this;
    }
    public String getGmtCreate() {
        return this.gmtCreate;
    }

    public GetGroupSetResponseBody setGmtModified(String gmtModified) {
        this.gmtModified = gmtModified;
        return this;
    }
    public String getGmtModified() {
        return this.gmtModified;
    }

    public GetGroupSetResponseBody setGroupChatCount(Integer groupChatCount) {
        this.groupChatCount = groupChatCount;
        return this;
    }
    public Integer getGroupChatCount() {
        return this.groupChatCount;
    }

    public GetGroupSetResponseBody setInviteLink(String inviteLink) {
        this.inviteLink = inviteLink;
        return this;
    }
    public String getInviteLink() {
        return this.inviteLink;
    }

    public GetGroupSetResponseBody setLastOpenConversationId(String lastOpenConversationId) {
        this.lastOpenConversationId = lastOpenConversationId;
        return this;
    }
    public String getLastOpenConversationId() {
        return this.lastOpenConversationId;
    }

    public GetGroupSetResponseBody setManager(java.util.List<GetGroupSetResponseBodyManager> manager) {
        this.manager = manager;
        return this;
    }
    public java.util.List<GetGroupSetResponseBodyManager> getManager() {
        return this.manager;
    }

    public GetGroupSetResponseBody setManagerUserIds(String managerUserIds) {
        this.managerUserIds = managerUserIds;
        return this;
    }
    public String getManagerUserIds() {
        return this.managerUserIds;
    }

    public GetGroupSetResponseBody setMemberCount(Integer memberCount) {
        this.memberCount = memberCount;
        return this;
    }
    public Integer getMemberCount() {
        return this.memberCount;
    }

    public GetGroupSetResponseBody setMemberQuota(Integer memberQuota) {
        this.memberQuota = memberQuota;
        return this;
    }
    public Integer getMemberQuota() {
        return this.memberQuota;
    }

    public GetGroupSetResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetGroupSetResponseBody setNotice(String notice) {
        this.notice = notice;
        return this;
    }
    public String getNotice() {
        return this.notice;
    }

    public GetGroupSetResponseBody setNoticeToped(Integer noticeToped) {
        this.noticeToped = noticeToped;
        return this;
    }
    public Integer getNoticeToped() {
        return this.noticeToped;
    }

    public GetGroupSetResponseBody setOpenGroupSetId(String openGroupSetId) {
        this.openGroupSetId = openGroupSetId;
        return this;
    }
    public String getOpenGroupSetId() {
        return this.openGroupSetId;
    }

    public GetGroupSetResponseBody setOwner(GetGroupSetResponseBodyOwner owner) {
        this.owner = owner;
        return this;
    }
    public GetGroupSetResponseBodyOwner getOwner() {
        return this.owner;
    }

    public GetGroupSetResponseBody setOwnerUserId(String ownerUserId) {
        this.ownerUserId = ownerUserId;
        return this;
    }
    public String getOwnerUserId() {
        return this.ownerUserId;
    }

    public GetGroupSetResponseBody setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

    public GetGroupSetResponseBody setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public static class GetGroupSetResponseBodyManager extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static GetGroupSetResponseBodyManager build(java.util.Map<String, ?> map) throws Exception {
            GetGroupSetResponseBodyManager self = new GetGroupSetResponseBodyManager();
            return TeaModel.build(map, self);
        }

        public GetGroupSetResponseBodyManager setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetGroupSetResponseBodyManager setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GetGroupSetResponseBodyOwner extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static GetGroupSetResponseBodyOwner build(java.util.Map<String, ?> map) throws Exception {
            GetGroupSetResponseBodyOwner self = new GetGroupSetResponseBodyOwner();
            return TeaModel.build(map, self);
        }

        public GetGroupSetResponseBodyOwner setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetGroupSetResponseBodyOwner setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
