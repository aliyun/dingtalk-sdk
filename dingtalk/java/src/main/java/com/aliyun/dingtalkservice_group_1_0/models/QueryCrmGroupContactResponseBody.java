// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryCrmGroupContactResponseBody extends TeaModel {
    /**
     * <p>游标</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>开放会话ID</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>群成员数据列表</p>
     */
    @NameInMap("records")
    public java.util.List<QueryCrmGroupContactResponseBodyRecords> records;

    public static QueryCrmGroupContactResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCrmGroupContactResponseBody self = new QueryCrmGroupContactResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCrmGroupContactResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryCrmGroupContactResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public QueryCrmGroupContactResponseBody setRecords(java.util.List<QueryCrmGroupContactResponseBodyRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<QueryCrmGroupContactResponseBodyRecords> getRecords() {
        return this.records;
    }

    public static class QueryCrmGroupContactResponseBodyRecords extends TeaModel {
        /**
         * <p>联系人画像数据</p>
         */
        @NameInMap("contactData")
        public String contactData;

        /**
         * <p>成员unionId</p>
         */
        @NameInMap("memberUnionId")
        public String memberUnionId;

        /**
         * <p>成员昵称</p>
         */
        @NameInMap("nickName")
        public String nickName;

        /**
         * <p>成员ID</p>
         */
        @NameInMap("userId")
        public String userId;

        public static QueryCrmGroupContactResponseBodyRecords build(java.util.Map<String, ?> map) throws Exception {
            QueryCrmGroupContactResponseBodyRecords self = new QueryCrmGroupContactResponseBodyRecords();
            return TeaModel.build(map, self);
        }

        public QueryCrmGroupContactResponseBodyRecords setContactData(String contactData) {
            this.contactData = contactData;
            return this;
        }
        public String getContactData() {
            return this.contactData;
        }

        public QueryCrmGroupContactResponseBodyRecords setMemberUnionId(String memberUnionId) {
            this.memberUnionId = memberUnionId;
            return this;
        }
        public String getMemberUnionId() {
            return this.memberUnionId;
        }

        public QueryCrmGroupContactResponseBodyRecords setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

        public QueryCrmGroupContactResponseBodyRecords setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
