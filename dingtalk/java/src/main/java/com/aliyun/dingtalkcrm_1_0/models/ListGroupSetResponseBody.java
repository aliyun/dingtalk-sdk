// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ListGroupSetResponseBody extends TeaModel {
    /**
     * <p>是否有下一页</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>下一页的游标</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>群组列表</p>
     */
    @NameInMap("resultList")
    public java.util.List<ListGroupSetResponseBodyResultList> resultList;

    /**
     * <p>总条数，queryDsl入参为空时才会返回</p>
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
         * <p>群管理员姓名</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>群管理员userId</p>
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
         * <p>群主姓名</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>群主userId</p>
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
         * <p>创建时间</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>修改时间</p>
         */
        @NameInMap("gmtModified")
        public String gmtModified;

        /**
         * <p>群组内群数量（不包含已解散的群）。</p>
         */
        @NameInMap("groupChatCount")
        public Integer groupChatCount;

        /**
         * <p>最新裂变群的群openConversationId</p>
         */
        @NameInMap("lastOpenConversationId")
        public String lastOpenConversationId;

        /**
         * <p>群管理员列表</p>
         */
        @NameInMap("manager")
        public java.util.List<ListGroupSetResponseBodyResultListManager> manager;

        /**
         * <p>群管理员userId列表，多个用逗号隔开，裂变出的新群会自动设置这些userId为群管理员</p>
         */
        @NameInMap("managerUserIds")
        public String managerUserIds;

        /**
         * <p>群组内所有群的成员数量</p>
         */
        @NameInMap("memberCount")
        public Integer memberCount;

        /**
         * <p>单个群的人数上限</p>
         */
        @NameInMap("memberQuota")
        public Integer memberQuota;

        /**
         * <p>群组名</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>群公告文本，裂变出的新群会自动设置上该群公告</p>
         */
        @NameInMap("notice")
        public String notice;

        /**
         * <p>群公告是否置顶，0：不置顶，1：置顶。裂变出的新群会自动设置上该属性</p>
         */
        @NameInMap("noticeToped")
        public Integer noticeToped;

        /**
         * <p>群组openGroupSetId</p>
         */
        @NameInMap("openGroupSetId")
        public String openGroupSetId;

        /**
         * <p>群主</p>
         */
        @NameInMap("owner")
        public ListGroupSetResponseBodyResultListOwner owner;

        /**
         * <p>群主userId，裂变出的新群会自动设置该userId为群主</p>
         */
        @NameInMap("ownerUserId")
        public String ownerUserId;

        /**
         * <p>关系类型</p>
         */
        @NameInMap("relationType")
        public String relationType;

        /**
         * <p>群模板id</p>
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
