// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class QueryConversationMessageForAIResponseBody extends TeaModel {
    @NameInMap("messages")
    public java.util.List<QueryConversationMessageForAIResponseBodyMessages> messages;

    public static QueryConversationMessageForAIResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryConversationMessageForAIResponseBody self = new QueryConversationMessageForAIResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryConversationMessageForAIResponseBody setMessages(java.util.List<QueryConversationMessageForAIResponseBodyMessages> messages) {
        this.messages = messages;
        return this;
    }
    public java.util.List<QueryConversationMessageForAIResponseBodyMessages> getMessages() {
        return this.messages;
    }

    public static class QueryConversationMessageForAIResponseBodyMessagesAtUsers extends TeaModel {
        @NameInMap("agentCode")
        public String agentCode;

        @NameInMap("nick")
        public String nick;

        @NameInMap("type")
        public String type;

        @NameInMap("unionId")
        public String unionId;

        @NameInMap("userId")
        public String userId;

        public static QueryConversationMessageForAIResponseBodyMessagesAtUsers build(java.util.Map<String, ?> map) throws Exception {
            QueryConversationMessageForAIResponseBodyMessagesAtUsers self = new QueryConversationMessageForAIResponseBodyMessagesAtUsers();
            return TeaModel.build(map, self);
        }

        public QueryConversationMessageForAIResponseBodyMessagesAtUsers setAgentCode(String agentCode) {
            this.agentCode = agentCode;
            return this;
        }
        public String getAgentCode() {
            return this.agentCode;
        }

        public QueryConversationMessageForAIResponseBodyMessagesAtUsers setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public QueryConversationMessageForAIResponseBodyMessagesAtUsers setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public QueryConversationMessageForAIResponseBodyMessagesAtUsers setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public QueryConversationMessageForAIResponseBodyMessagesAtUsers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryConversationMessageForAIResponseBodyMessagesSender extends TeaModel {
        @NameInMap("agentCode")
        public String agentCode;

        @NameInMap("nick")
        public String nick;

        @NameInMap("type")
        public String type;

        @NameInMap("unionId")
        public String unionId;

        @NameInMap("userId")
        public String userId;

        public static QueryConversationMessageForAIResponseBodyMessagesSender build(java.util.Map<String, ?> map) throws Exception {
            QueryConversationMessageForAIResponseBodyMessagesSender self = new QueryConversationMessageForAIResponseBodyMessagesSender();
            return TeaModel.build(map, self);
        }

        public QueryConversationMessageForAIResponseBodyMessagesSender setAgentCode(String agentCode) {
            this.agentCode = agentCode;
            return this;
        }
        public String getAgentCode() {
            return this.agentCode;
        }

        public QueryConversationMessageForAIResponseBodyMessagesSender setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public QueryConversationMessageForAIResponseBodyMessagesSender setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public QueryConversationMessageForAIResponseBodyMessagesSender setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public QueryConversationMessageForAIResponseBodyMessagesSender setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryConversationMessageForAIResponseBodyMessages extends TeaModel {
        @NameInMap("atAll")
        public Boolean atAll;

        @NameInMap("atUsers")
        public java.util.List<QueryConversationMessageForAIResponseBodyMessagesAtUsers> atUsers;

        @NameInMap("msgContent")
        public String msgContent;

        @NameInMap("msgType")
        public String msgType;

        @NameInMap("sendTime")
        public String sendTime;

        @NameInMap("sender")
        public QueryConversationMessageForAIResponseBodyMessagesSender sender;

        @NameInMap("summary")
        public String summary;

        public static QueryConversationMessageForAIResponseBodyMessages build(java.util.Map<String, ?> map) throws Exception {
            QueryConversationMessageForAIResponseBodyMessages self = new QueryConversationMessageForAIResponseBodyMessages();
            return TeaModel.build(map, self);
        }

        public QueryConversationMessageForAIResponseBodyMessages setAtAll(Boolean atAll) {
            this.atAll = atAll;
            return this;
        }
        public Boolean getAtAll() {
            return this.atAll;
        }

        public QueryConversationMessageForAIResponseBodyMessages setAtUsers(java.util.List<QueryConversationMessageForAIResponseBodyMessagesAtUsers> atUsers) {
            this.atUsers = atUsers;
            return this;
        }
        public java.util.List<QueryConversationMessageForAIResponseBodyMessagesAtUsers> getAtUsers() {
            return this.atUsers;
        }

        public QueryConversationMessageForAIResponseBodyMessages setMsgContent(String msgContent) {
            this.msgContent = msgContent;
            return this;
        }
        public String getMsgContent() {
            return this.msgContent;
        }

        public QueryConversationMessageForAIResponseBodyMessages setMsgType(String msgType) {
            this.msgType = msgType;
            return this;
        }
        public String getMsgType() {
            return this.msgType;
        }

        public QueryConversationMessageForAIResponseBodyMessages setSendTime(String sendTime) {
            this.sendTime = sendTime;
            return this;
        }
        public String getSendTime() {
            return this.sendTime;
        }

        public QueryConversationMessageForAIResponseBodyMessages setSender(QueryConversationMessageForAIResponseBodyMessagesSender sender) {
            this.sender = sender;
            return this;
        }
        public QueryConversationMessageForAIResponseBodyMessagesSender getSender() {
            return this.sender;
        }

        public QueryConversationMessageForAIResponseBodyMessages setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

    }

}
