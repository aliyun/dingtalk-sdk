// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SearchOrgInnerGroupInfoResponseBody extends TeaModel {
    @NameInMap("itemCount")
    public Integer itemCount;

    @NameInMap("items")
    public java.util.List<SearchOrgInnerGroupInfoResponseBodyItems> items;

    @NameInMap("totalCount")
    public Long totalCount;

    public static SearchOrgInnerGroupInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchOrgInnerGroupInfoResponseBody self = new SearchOrgInnerGroupInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchOrgInnerGroupInfoResponseBody setItemCount(Integer itemCount) {
        this.itemCount = itemCount;
        return this;
    }
    public Integer getItemCount() {
        return this.itemCount;
    }

    public SearchOrgInnerGroupInfoResponseBody setItems(java.util.List<SearchOrgInnerGroupInfoResponseBodyItems> items) {
        this.items = items;
        return this;
    }
    public java.util.List<SearchOrgInnerGroupInfoResponseBodyItems> getItems() {
        return this.items;
    }

    public SearchOrgInnerGroupInfoResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class SearchOrgInnerGroupInfoResponseBodyItems extends TeaModel {
        @NameInMap("groupAdminsCount")
        public Integer groupAdminsCount;

        @NameInMap("groupCreateTime")
        public Long groupCreateTime;

        @NameInMap("groupLastActiveTime")
        public Long groupLastActiveTime;

        @NameInMap("groupLastActiveTimeShow")
        public String groupLastActiveTimeShow;

        @NameInMap("groupMembersCount")
        public Integer groupMembersCount;

        @NameInMap("groupName")
        public String groupName;

        @NameInMap("groupOwner")
        public String groupOwner;

        @NameInMap("groupOwnerUserId")
        public String groupOwnerUserId;

        @NameInMap("openConversationId")
        public String openConversationId;

        @NameInMap("status")
        public Integer status;

        @NameInMap("syncToDingpan")
        public Integer syncToDingpan;

        @NameInMap("templateId")
        public String templateId;

        @NameInMap("templateName")
        public String templateName;

        @NameInMap("usedQuota")
        public Long usedQuota;

        public static SearchOrgInnerGroupInfoResponseBodyItems build(java.util.Map<String, ?> map) throws Exception {
            SearchOrgInnerGroupInfoResponseBodyItems self = new SearchOrgInnerGroupInfoResponseBodyItems();
            return TeaModel.build(map, self);
        }

        public SearchOrgInnerGroupInfoResponseBodyItems setGroupAdminsCount(Integer groupAdminsCount) {
            this.groupAdminsCount = groupAdminsCount;
            return this;
        }
        public Integer getGroupAdminsCount() {
            return this.groupAdminsCount;
        }

        public SearchOrgInnerGroupInfoResponseBodyItems setGroupCreateTime(Long groupCreateTime) {
            this.groupCreateTime = groupCreateTime;
            return this;
        }
        public Long getGroupCreateTime() {
            return this.groupCreateTime;
        }

        public SearchOrgInnerGroupInfoResponseBodyItems setGroupLastActiveTime(Long groupLastActiveTime) {
            this.groupLastActiveTime = groupLastActiveTime;
            return this;
        }
        public Long getGroupLastActiveTime() {
            return this.groupLastActiveTime;
        }

        public SearchOrgInnerGroupInfoResponseBodyItems setGroupLastActiveTimeShow(String groupLastActiveTimeShow) {
            this.groupLastActiveTimeShow = groupLastActiveTimeShow;
            return this;
        }
        public String getGroupLastActiveTimeShow() {
            return this.groupLastActiveTimeShow;
        }

        public SearchOrgInnerGroupInfoResponseBodyItems setGroupMembersCount(Integer groupMembersCount) {
            this.groupMembersCount = groupMembersCount;
            return this;
        }
        public Integer getGroupMembersCount() {
            return this.groupMembersCount;
        }

        public SearchOrgInnerGroupInfoResponseBodyItems setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public SearchOrgInnerGroupInfoResponseBodyItems setGroupOwner(String groupOwner) {
            this.groupOwner = groupOwner;
            return this;
        }
        public String getGroupOwner() {
            return this.groupOwner;
        }

        public SearchOrgInnerGroupInfoResponseBodyItems setGroupOwnerUserId(String groupOwnerUserId) {
            this.groupOwnerUserId = groupOwnerUserId;
            return this;
        }
        public String getGroupOwnerUserId() {
            return this.groupOwnerUserId;
        }

        public SearchOrgInnerGroupInfoResponseBodyItems setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public SearchOrgInnerGroupInfoResponseBodyItems setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public SearchOrgInnerGroupInfoResponseBodyItems setSyncToDingpan(Integer syncToDingpan) {
            this.syncToDingpan = syncToDingpan;
            return this;
        }
        public Integer getSyncToDingpan() {
            return this.syncToDingpan;
        }

        public SearchOrgInnerGroupInfoResponseBodyItems setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

        public SearchOrgInnerGroupInfoResponseBodyItems setTemplateName(String templateName) {
            this.templateName = templateName;
            return this;
        }
        public String getTemplateName() {
            return this.templateName;
        }

        public SearchOrgInnerGroupInfoResponseBodyItems setUsedQuota(Long usedQuota) {
            this.usedQuota = usedQuota;
            return this;
        }
        public Long getUsedQuota() {
            return this.usedQuota;
        }

    }

}
