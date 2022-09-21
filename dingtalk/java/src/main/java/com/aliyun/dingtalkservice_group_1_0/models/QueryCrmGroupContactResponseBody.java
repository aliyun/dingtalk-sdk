// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryCrmGroupContactResponseBody extends TeaModel {
    // 游标
    @NameInMap("nextToken")
    public String nextToken;

    // 开放会话ID
    @NameInMap("openConversationId")
    public String openConversationId;

    // 群成员数据列表
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
        // 联系人画像数据
        @NameInMap("contactData")
        public String contactData;

        // 成员unionId
        @NameInMap("memberUnionId")
        public String memberUnionId;

        // 成员昵称
        @NameInMap("nickName")
        public String nickName;

        // 成员ID
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
