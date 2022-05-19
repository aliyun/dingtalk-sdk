// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupManageQueryResponseBody extends TeaModel {
    // 群信息列表
    @NameInMap("groupInfoList")
    public java.util.List<GroupManageQueryResponseBodyGroupInfoList> groupInfoList;

    // 分页拉取时, 是否还有更多
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 分页拉取游标, 请求下一页时回传
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
        // 禁言模式
        @NameInMap("banWordsMode")
        public Integer banWordsMode;

        // 群容量
        @NameInMap("capacity")
        public Integer capacity;

        // 群创建时间
        @NameInMap("createdAt")
        public Long createdAt;

        // 扩展信息
        @NameInMap("extInfo")
        public java.util.Map<String, ?> extInfo;

        @NameInMap("groupAdminList")
        public java.util.List<String> groupAdminList;

        // 群主userid
        @NameInMap("groupOwner")
        public String groupOwner;

        // 群标题
        @NameInMap("groupTitle")
        public String groupTitle;

        // 当前群人数
        @NameInMap("memberCount")
        public Integer memberCount;

        // 开放的群id
        @NameInMap("openConversationId")
        public String openConversationId;

        // 群类型
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
