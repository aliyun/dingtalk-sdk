// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ListGroupSetResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <strong>example:</strong>
     * <p>fasfasd</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("resultList")
    public java.util.List<ListGroupSetResponseBodyResultList> resultList;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("totalCount")
    public Integer totalCount;

    public static ListGroupSetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListGroupSetResponseBody self = new ListGroupSetResponseBody();
        return TeaModel.build(map, self);
    }

    public ListGroupSetResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListGroupSetResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListGroupSetResponseBody setResultList(java.util.List<ListGroupSetResponseBodyResultList> resultList) {
        this.resultList = resultList;
        return this;
    }
    public java.util.List<ListGroupSetResponseBodyResultList> getResultList() {
        return this.resultList;
    }

    public ListGroupSetResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class ListGroupSetResponseBodyResultListManager extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>XX</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>afs1</p>
         */
        @NameInMap("userId")
        public String userId;

        public static ListGroupSetResponseBodyResultListManager build(java.util.Map<String, ?> map) throws Exception {
            ListGroupSetResponseBodyResultListManager self = new ListGroupSetResponseBodyResultListManager();
            return TeaModel.build(map, self);
        }

        public ListGroupSetResponseBodyResultListManager setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListGroupSetResponseBodyResultListManager setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class ListGroupSetResponseBodyResultListOwner extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>XX</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>afsd12</p>
         */
        @NameInMap("userId")
        public String userId;

        public static ListGroupSetResponseBodyResultListOwner build(java.util.Map<String, ?> map) throws Exception {
            ListGroupSetResponseBodyResultListOwner self = new ListGroupSetResponseBodyResultListOwner();
            return TeaModel.build(map, self);
        }

        public ListGroupSetResponseBodyResultListOwner setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListGroupSetResponseBodyResultListOwner setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class ListGroupSetResponseBodyResultList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2021-12-23T13:00Z</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <strong>example:</strong>
         * <p>2021-12-23T13:00Z</p>
         */
        @NameInMap("gmtModified")
        public String gmtModified;

        /**
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("groupChatCount")
        public Integer groupChatCount;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>123agsg</p>
         */
        @NameInMap("lastOpenConversationId")
        public String lastOpenConversationId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("manager")
        public java.util.List<ListGroupSetResponseBodyResultListManager> manager;

        /**
         * <strong>example:</strong>
         * <p>afsd12,afsd13</p>
         */
        @NameInMap("managerUserIds")
        public String managerUserIds;

        /**
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("memberCount")
        public Integer memberCount;

        /**
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("memberQuota")
        public Integer memberQuota;

        /**
         * <strong>example:</strong>
         * <p>营销群</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>群公告</p>
         */
        @NameInMap("notice")
        public String notice;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("noticeToped")
        public Integer noticeToped;

        /**
         * <strong>example:</strong>
         * <p>adfads</p>
         */
        @NameInMap("openGroupSetId")
        public String openGroupSetId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("owner")
        public ListGroupSetResponseBodyResultListOwner owner;

        /**
         * <strong>example:</strong>
         * <p>afsd12</p>
         */
        @NameInMap("ownerUserId")
        public String ownerUserId;

        /**
         * <strong>example:</strong>
         * <p>crm_customer_personal</p>
         */
        @NameInMap("relationType")
        public String relationType;

        /**
         * <strong>example:</strong>
         * <p>sfasgsab</p>
         */
        @NameInMap("templateId")
        public String templateId;

        public static ListGroupSetResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            ListGroupSetResponseBodyResultList self = new ListGroupSetResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public ListGroupSetResponseBodyResultList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public ListGroupSetResponseBodyResultList setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public ListGroupSetResponseBodyResultList setGroupChatCount(Integer groupChatCount) {
            this.groupChatCount = groupChatCount;
            return this;
        }
        public Integer getGroupChatCount() {
            return this.groupChatCount;
        }

        public ListGroupSetResponseBodyResultList setLastOpenConversationId(String lastOpenConversationId) {
            this.lastOpenConversationId = lastOpenConversationId;
            return this;
        }
        public String getLastOpenConversationId() {
            return this.lastOpenConversationId;
        }

        public ListGroupSetResponseBodyResultList setManager(java.util.List<ListGroupSetResponseBodyResultListManager> manager) {
            this.manager = manager;
            return this;
        }
        public java.util.List<ListGroupSetResponseBodyResultListManager> getManager() {
            return this.manager;
        }

        public ListGroupSetResponseBodyResultList setManagerUserIds(String managerUserIds) {
            this.managerUserIds = managerUserIds;
            return this;
        }
        public String getManagerUserIds() {
            return this.managerUserIds;
        }

        public ListGroupSetResponseBodyResultList setMemberCount(Integer memberCount) {
            this.memberCount = memberCount;
            return this;
        }
        public Integer getMemberCount() {
            return this.memberCount;
        }

        public ListGroupSetResponseBodyResultList setMemberQuota(Integer memberQuota) {
            this.memberQuota = memberQuota;
            return this;
        }
        public Integer getMemberQuota() {
            return this.memberQuota;
        }

        public ListGroupSetResponseBodyResultList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListGroupSetResponseBodyResultList setNotice(String notice) {
            this.notice = notice;
            return this;
        }
        public String getNotice() {
            return this.notice;
        }

        public ListGroupSetResponseBodyResultList setNoticeToped(Integer noticeToped) {
            this.noticeToped = noticeToped;
            return this;
        }
        public Integer getNoticeToped() {
            return this.noticeToped;
        }

        public ListGroupSetResponseBodyResultList setOpenGroupSetId(String openGroupSetId) {
            this.openGroupSetId = openGroupSetId;
            return this;
        }
        public String getOpenGroupSetId() {
            return this.openGroupSetId;
        }

        public ListGroupSetResponseBodyResultList setOwner(ListGroupSetResponseBodyResultListOwner owner) {
            this.owner = owner;
            return this;
        }
        public ListGroupSetResponseBodyResultListOwner getOwner() {
            return this.owner;
        }

        public ListGroupSetResponseBodyResultList setOwnerUserId(String ownerUserId) {
            this.ownerUserId = ownerUserId;
            return this;
        }
        public String getOwnerUserId() {
            return this.ownerUserId;
        }

        public ListGroupSetResponseBodyResultList setRelationType(String relationType) {
            this.relationType = relationType;
            return this;
        }
        public String getRelationType() {
            return this.relationType;
        }

        public ListGroupSetResponseBodyResultList setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

    }

}
