// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupSetResponseBody extends TeaModel {
    @NameInMap("gmtCreate")
    public String gmtCreate;

    @NameInMap("gmtModified")
    public String gmtModified;

    @NameInMap("lastOpenConversationId")
    public String lastOpenConversationId;

    @NameInMap("manager")
    public java.util.List<CreateGroupSetResponseBodyManager> manager;

    @NameInMap("managerUserIds")
    public String managerUserIds;

    @NameInMap("memberCount")
    public Long memberCount;

    @NameInMap("memberQuota")
    public Long memberQuota;

    @NameInMap("name")
    public String name;

    @NameInMap("notice")
    public String notice;

    @NameInMap("noticeToped")
    public Integer noticeToped;

    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    @NameInMap("owner")
    public CreateGroupSetResponseBodyOwner owner;

    @NameInMap("ownerUserId")
    public String ownerUserId;

    @NameInMap("relationType")
    public String relationType;

    @NameInMap("templateId")
    public String templateId;

    public static CreateGroupSetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupSetResponseBody self = new CreateGroupSetResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateGroupSetResponseBody setGmtCreate(String gmtCreate) {
        this.gmtCreate = gmtCreate;
        return this;
    }
    public String getGmtCreate() {
        return this.gmtCreate;
    }

    public CreateGroupSetResponseBody setGmtModified(String gmtModified) {
        this.gmtModified = gmtModified;
        return this;
    }
    public String getGmtModified() {
        return this.gmtModified;
    }

    public CreateGroupSetResponseBody setLastOpenConversationId(String lastOpenConversationId) {
        this.lastOpenConversationId = lastOpenConversationId;
        return this;
    }
    public String getLastOpenConversationId() {
        return this.lastOpenConversationId;
    }

    public CreateGroupSetResponseBody setManager(java.util.List<CreateGroupSetResponseBodyManager> manager) {
        this.manager = manager;
        return this;
    }
    public java.util.List<CreateGroupSetResponseBodyManager> getManager() {
        return this.manager;
    }

    public CreateGroupSetResponseBody setManagerUserIds(String managerUserIds) {
        this.managerUserIds = managerUserIds;
        return this;
    }
    public String getManagerUserIds() {
        return this.managerUserIds;
    }

    public CreateGroupSetResponseBody setMemberCount(Long memberCount) {
        this.memberCount = memberCount;
        return this;
    }
    public Long getMemberCount() {
        return this.memberCount;
    }

    public CreateGroupSetResponseBody setMemberQuota(Long memberQuota) {
        this.memberQuota = memberQuota;
        return this;
    }
    public Long getMemberQuota() {
        return this.memberQuota;
    }

    public CreateGroupSetResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateGroupSetResponseBody setNotice(String notice) {
        this.notice = notice;
        return this;
    }
    public String getNotice() {
        return this.notice;
    }

    public CreateGroupSetResponseBody setNoticeToped(Integer noticeToped) {
        this.noticeToped = noticeToped;
        return this;
    }
    public Integer getNoticeToped() {
        return this.noticeToped;
    }

    public CreateGroupSetResponseBody setOpenGroupSetId(String openGroupSetId) {
        this.openGroupSetId = openGroupSetId;
        return this;
    }
    public String getOpenGroupSetId() {
        return this.openGroupSetId;
    }

    public CreateGroupSetResponseBody setOwner(CreateGroupSetResponseBodyOwner owner) {
        this.owner = owner;
        return this;
    }
    public CreateGroupSetResponseBodyOwner getOwner() {
        return this.owner;
    }

    public CreateGroupSetResponseBody setOwnerUserId(String ownerUserId) {
        this.ownerUserId = ownerUserId;
        return this;
    }
    public String getOwnerUserId() {
        return this.ownerUserId;
    }

    public CreateGroupSetResponseBody setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

    public CreateGroupSetResponseBody setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public static class CreateGroupSetResponseBodyManager extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static CreateGroupSetResponseBodyManager build(java.util.Map<String, ?> map) throws Exception {
            CreateGroupSetResponseBodyManager self = new CreateGroupSetResponseBodyManager();
            return TeaModel.build(map, self);
        }

        public CreateGroupSetResponseBodyManager setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateGroupSetResponseBodyManager setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class CreateGroupSetResponseBodyOwner extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static CreateGroupSetResponseBodyOwner build(java.util.Map<String, ?> map) throws Exception {
            CreateGroupSetResponseBodyOwner self = new CreateGroupSetResponseBodyOwner();
            return TeaModel.build(map, self);
        }

        public CreateGroupSetResponseBodyOwner setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateGroupSetResponseBodyOwner setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
