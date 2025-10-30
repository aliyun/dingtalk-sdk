// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SearchOrgInnerGroupInfoByCursorPageResponseBody extends TeaModel {
    @NameInMap("hasNext")
    public Boolean hasNext;

    @NameInMap("items")
    public java.util.List<SearchOrgInnerGroupInfoByCursorPageResponseBodyItems> items;

    @NameInMap("nextCursor")
    public Long nextCursor;

    public static SearchOrgInnerGroupInfoByCursorPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchOrgInnerGroupInfoByCursorPageResponseBody self = new SearchOrgInnerGroupInfoByCursorPageResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchOrgInnerGroupInfoByCursorPageResponseBody setHasNext(Boolean hasNext) {
        this.hasNext = hasNext;
        return this;
    }
    public Boolean getHasNext() {
        return this.hasNext;
    }

    public SearchOrgInnerGroupInfoByCursorPageResponseBody setItems(java.util.List<SearchOrgInnerGroupInfoByCursorPageResponseBodyItems> items) {
        this.items = items;
        return this;
    }
    public java.util.List<SearchOrgInnerGroupInfoByCursorPageResponseBodyItems> getItems() {
        return this.items;
    }

    public SearchOrgInnerGroupInfoByCursorPageResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public static class SearchOrgInnerGroupInfoByCursorPageResponseBodyItems extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1756656000000</p>
         */
        @NameInMap("groupCreateTime")
        public Long groupCreateTime;

        @NameInMap("groupLastActiveTime")
        public Long groupLastActiveTime;

        /**
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("groupMembersCnt")
        public Integer groupMembersCnt;

        /**
         * <strong>example:</strong>
         * <p>内部群</p>
         */
        @NameInMap("groupName")
        public String groupName;

        @NameInMap("groupOwner")
        public String groupOwner;

        /**
         * <strong>example:</strong>
         * <p>user123</p>
         */
        @NameInMap("groupOwnerUserId")
        public String groupOwnerUserId;

        /**
         * <strong>example:</strong>
         * <p>cid123</p>
         */
        @NameInMap("openConversationId")
        public String openConversationId;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("status")
        public Integer status;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("syncToDingpan")
        public Integer syncToDingpan;

        /**
         * <strong>example:</strong>
         * <p>1000</p>
         */
        @NameInMap("usedQuota")
        public Long usedQuota;

        public static SearchOrgInnerGroupInfoByCursorPageResponseBodyItems build(java.util.Map<String, ?> map) throws Exception {
            SearchOrgInnerGroupInfoByCursorPageResponseBodyItems self = new SearchOrgInnerGroupInfoByCursorPageResponseBodyItems();
            return TeaModel.build(map, self);
        }

        public SearchOrgInnerGroupInfoByCursorPageResponseBodyItems setGroupCreateTime(Long groupCreateTime) {
            this.groupCreateTime = groupCreateTime;
            return this;
        }
        public Long getGroupCreateTime() {
            return this.groupCreateTime;
        }

        public SearchOrgInnerGroupInfoByCursorPageResponseBodyItems setGroupLastActiveTime(Long groupLastActiveTime) {
            this.groupLastActiveTime = groupLastActiveTime;
            return this;
        }
        public Long getGroupLastActiveTime() {
            return this.groupLastActiveTime;
        }

        public SearchOrgInnerGroupInfoByCursorPageResponseBodyItems setGroupMembersCnt(Integer groupMembersCnt) {
            this.groupMembersCnt = groupMembersCnt;
            return this;
        }
        public Integer getGroupMembersCnt() {
            return this.groupMembersCnt;
        }

        public SearchOrgInnerGroupInfoByCursorPageResponseBodyItems setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public SearchOrgInnerGroupInfoByCursorPageResponseBodyItems setGroupOwner(String groupOwner) {
            this.groupOwner = groupOwner;
            return this;
        }
        public String getGroupOwner() {
            return this.groupOwner;
        }

        public SearchOrgInnerGroupInfoByCursorPageResponseBodyItems setGroupOwnerUserId(String groupOwnerUserId) {
            this.groupOwnerUserId = groupOwnerUserId;
            return this;
        }
        public String getGroupOwnerUserId() {
            return this.groupOwnerUserId;
        }

        public SearchOrgInnerGroupInfoByCursorPageResponseBodyItems setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public SearchOrgInnerGroupInfoByCursorPageResponseBodyItems setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public SearchOrgInnerGroupInfoByCursorPageResponseBodyItems setSyncToDingpan(Integer syncToDingpan) {
            this.syncToDingpan = syncToDingpan;
            return this;
        }
        public Integer getSyncToDingpan() {
            return this.syncToDingpan;
        }

        public SearchOrgInnerGroupInfoByCursorPageResponseBodyItems setUsedQuota(Long usedQuota) {
            this.usedQuota = usedQuota;
            return this;
        }
        public Long getUsedQuota() {
            return this.usedQuota;
        }

    }

}
