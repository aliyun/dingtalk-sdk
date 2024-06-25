// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupManageQueryResponseBody extends TeaModel {
    @NameInMap("groupInfoList")
    public java.util.List<GroupManageQueryResponseBodyGroupInfoList> groupInfoList;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <strong>example:</strong>
     * <p>500</p>
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
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("banWordsMode")
        public Integer banWordsMode;

        /**
         * <strong>example:</strong>
         * <p>1000</p>
         */
        @NameInMap("capacity")
        public Integer capacity;

        /**
         * <strong>example:</strong>
         * <p>1652183395772</p>
         */
        @NameInMap("createdAt")
        public Long createdAt;

        @NameInMap("extInfo")
        public java.util.Map<String, ?> extInfo;

        @NameInMap("groupAdminList")
        public java.util.List<String> groupAdminList;

        /**
         * <strong>example:</strong>
         * <p>574892167781263748</p>
         */
        @NameInMap("groupOwner")
        public String groupOwner;

        /**
         * <strong>example:</strong>
         * <p>今天吃肘子群</p>
         */
        @NameInMap("groupTitle")
        public String groupTitle;

        /**
         * <strong>example:</strong>
         * <p>500</p>
         */
        @NameInMap("memberCount")
        public Integer memberCount;

        /**
         * <strong>example:</strong>
         * <p>cidnvcxzklxv23jhkg412hj==</p>
         */
        @NameInMap("openConversationId")
        public String openConversationId;

        /**
         * <strong>example:</strong>
         * <p>INNER</p>
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
