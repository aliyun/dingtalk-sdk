// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupManageQueryResponseBody extends TeaModel {
    /**
     * <p>群信息列表</p>
     */
    @NameInMap("groupInfoList")
    public java.util.List<GroupManageQueryResponseBodyGroupInfoList> groupInfoList;

    /**
     * <p>分页拉取时, 是否还有更多</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>分页拉取游标, 请求下一页时回传</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    public static GroupManageQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GroupManageQueryResponseBody self = new GroupManageQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public GroupManageQueryResponseBody setGroupInfoList(java.util.List<GroupManageQueryResponseBodyGroupInfoList> groupInfoList) {
        this.groupInfoList = groupInfoList;
        return this;
    }
    public java.util.List<GroupManageQueryResponseBodyGroupInfoList> getGroupInfoList() {
        return this.groupInfoList;
    }

    public GroupManageQueryResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public GroupManageQueryResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class GroupManageQueryResponseBodyGroupInfoList extends TeaModel {
        /**
         * <p>禁言模式</p>
         */
        @NameInMap("banWordsMode")
        public Integer banWordsMode;

        /**
         * <p>群容量</p>
         */
        @NameInMap("capacity")
        public Integer capacity;

        /**
         * <p>群创建时间</p>
         */
        @NameInMap("createdAt")
        public Long createdAt;

        /**
         * <p>扩展信息</p>
         */
        @NameInMap("extInfo")
        public java.util.Map<String, ?> extInfo;

        @NameInMap("groupAdminList")
        public java.util.List<String> groupAdminList;

        /**
         * <p>群主userid</p>
         */
        @NameInMap("groupOwner")
        public String groupOwner;

        /**
         * <p>群标题</p>
         */
        @NameInMap("groupTitle")
        public String groupTitle;

        /**
         * <p>当前群人数</p>
         */
        @NameInMap("memberCount")
        public Integer memberCount;

        /**
         * <p>开放的群id</p>
         */
        @NameInMap("openConversationId")
        public String openConversationId;

        /**
         * <p>群类型</p>
         */
        @NameInMap("type")
        public String type;

        public static GroupManageQueryResponseBodyGroupInfoList build(java.util.Map<String, ?> map) throws Exception {
            GroupManageQueryResponseBodyGroupInfoList self = new GroupManageQueryResponseBodyGroupInfoList();
            return TeaModel.build(map, self);
        }

        public GroupManageQueryResponseBodyGroupInfoList setBanWordsMode(Integer banWordsMode) {
            this.banWordsMode = banWordsMode;
            return this;
        }
        public Integer getBanWordsMode() {
            return this.banWordsMode;
        }

        public GroupManageQueryResponseBodyGroupInfoList setCapacity(Integer capacity) {
            this.capacity = capacity;
            return this;
        }
        public Integer getCapacity() {
            return this.capacity;
        }

        public GroupManageQueryResponseBodyGroupInfoList setCreatedAt(Long createdAt) {
            this.createdAt = createdAt;
            return this;
        }
        public Long getCreatedAt() {
            return this.createdAt;
        }

        public GroupManageQueryResponseBodyGroupInfoList setExtInfo(java.util.Map<String, ?> extInfo) {
            this.extInfo = extInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtInfo() {
            return this.extInfo;
        }

        public GroupManageQueryResponseBodyGroupInfoList setGroupAdminList(java.util.List<String> groupAdminList) {
            this.groupAdminList = groupAdminList;
            return this;
        }
        public java.util.List<String> getGroupAdminList() {
            return this.groupAdminList;
        }

        public GroupManageQueryResponseBodyGroupInfoList setGroupOwner(String groupOwner) {
            this.groupOwner = groupOwner;
            return this;
        }
        public String getGroupOwner() {
            return this.groupOwner;
        }

        public GroupManageQueryResponseBodyGroupInfoList setGroupTitle(String groupTitle) {
            this.groupTitle = groupTitle;
            return this;
        }
        public String getGroupTitle() {
            return this.groupTitle;
        }

        public GroupManageQueryResponseBodyGroupInfoList setMemberCount(Integer memberCount) {
            this.memberCount = memberCount;
            return this;
        }
        public Integer getMemberCount() {
            return this.memberCount;
        }

        public GroupManageQueryResponseBodyGroupInfoList setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public GroupManageQueryResponseBodyGroupInfoList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
