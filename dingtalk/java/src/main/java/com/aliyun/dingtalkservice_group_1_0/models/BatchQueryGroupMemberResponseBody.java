// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryGroupMemberResponseBody extends TeaModel {
    /**
     * <p>是否还存在数据</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>下一次游标</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>会话ID</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>成员数据列表</p>
     */
    @NameInMap("records")
    public java.util.List<BatchQueryGroupMemberResponseBodyRecords> records;

    public static BatchQueryGroupMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryGroupMemberResponseBody self = new BatchQueryGroupMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchQueryGroupMemberResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public BatchQueryGroupMemberResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public BatchQueryGroupMemberResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public BatchQueryGroupMemberResponseBody setRecords(java.util.List<BatchQueryGroupMemberResponseBodyRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<BatchQueryGroupMemberResponseBodyRecords> getRecords() {
        return this.records;
    }

    public static class BatchQueryGroupMemberResponseBodyRecords extends TeaModel {
        /**
         * <p>是否内部员工</p>
         */
        @NameInMap("innerStaff")
        public Boolean innerStaff;

        /**
         * <p>群成员昵称</p>
         */
        @NameInMap("nickName")
        public String nickName;

        /**
         * <p>是否群主</p>
         */
        @NameInMap("owner")
        public Boolean owner;

        /**
         * <p>群成员uinionId</p>
         */
        @NameInMap("unionId")
        public String unionId;

        /**
         * <p>员工ID</p>
         */
        @NameInMap("userId")
        public String userId;

        public static BatchQueryGroupMemberResponseBodyRecords build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryGroupMemberResponseBodyRecords self = new BatchQueryGroupMemberResponseBodyRecords();
            return TeaModel.build(map, self);
        }

        public BatchQueryGroupMemberResponseBodyRecords setInnerStaff(Boolean innerStaff) {
            this.innerStaff = innerStaff;
            return this;
        }
        public Boolean getInnerStaff() {
            return this.innerStaff;
        }

        public BatchQueryGroupMemberResponseBodyRecords setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

        public BatchQueryGroupMemberResponseBodyRecords setOwner(Boolean owner) {
            this.owner = owner;
            return this;
        }
        public Boolean getOwner() {
            return this.owner;
        }

        public BatchQueryGroupMemberResponseBodyRecords setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public BatchQueryGroupMemberResponseBodyRecords setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
