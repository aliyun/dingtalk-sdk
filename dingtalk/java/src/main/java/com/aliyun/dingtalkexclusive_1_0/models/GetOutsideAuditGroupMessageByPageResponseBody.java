// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetOutsideAuditGroupMessageByPageResponseBody extends TeaModel {
    /**
     * <p>返回结构体</p>
     */
    @NameInMap("responseBody")
    public GetOutsideAuditGroupMessageByPageResponseBodyResponseBody responseBody;

    public static GetOutsideAuditGroupMessageByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOutsideAuditGroupMessageByPageResponseBody self = new GetOutsideAuditGroupMessageByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOutsideAuditGroupMessageByPageResponseBody setResponseBody(GetOutsideAuditGroupMessageByPageResponseBodyResponseBody responseBody) {
        this.responseBody = responseBody;
        return this;
    }
    public GetOutsideAuditGroupMessageByPageResponseBodyResponseBody getResponseBody() {
        return this.responseBody;
    }

    public static class GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender extends TeaModel {
        /**
         * <p>根据id的类型决定是哪一种id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>发送者的id类型，可以是userId或者unionId</p>
         */
        @NameInMap("idType")
        public String idType;

        /**
         * <p>用户-user 机器人-bot 系统账号-sys</p>
         */
        @NameInMap("type")
        public String type;

        public static GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender build(java.util.Map<String, ?> map) throws Exception {
            GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender self = new GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender();
            return TeaModel.build(map, self);
        }

        public GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender setIdType(String idType) {
            this.idType = idType;
            return this;
        }
        public String getIdType() {
            return this.idType;
        }

        public GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList extends TeaModel {
        /**
         * <p>内容</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <p>内容类型 文本/语音/视频</p>
         */
        @NameInMap("contentType")
        public String contentType;

        /**
         * <p>发送时间 格式:yyyy-MM-dd HH:mm:ss</p>
         */
        @NameInMap("createAt")
        public String createAt;

        /**
         * <p>会话id</p>
         */
        @NameInMap("openConversationId")
        public String openConversationId;

        /**
         * <p>发送人</p>
         */
        @NameInMap("sender")
        public GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender sender;

        public static GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList build(java.util.Map<String, ?> map) throws Exception {
            GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList self = new GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList();
            return TeaModel.build(map, self);
        }

        public GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList setContentType(String contentType) {
            this.contentType = contentType;
            return this;
        }
        public String getContentType() {
            return this.contentType;
        }

        public GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList setCreateAt(String createAt) {
            this.createAt = createAt;
            return this;
        }
        public String getCreateAt() {
            return this.createAt;
        }

        public GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList setSender(GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender sender) {
            this.sender = sender;
            return this;
        }
        public GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender getSender() {
            return this.sender;
        }

    }

    public static class GetOutsideAuditGroupMessageByPageResponseBodyResponseBody extends TeaModel {
        /**
         * <p>消息列表</p>
         */
        @NameInMap("messageList")
        public java.util.List<GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList> messageList;

        /**
         * <p>下一次请求的token,无返回值则下一条消息不存在</p>
         */
        @NameInMap("nextToken")
        public String nextToken;

        public static GetOutsideAuditGroupMessageByPageResponseBodyResponseBody build(java.util.Map<String, ?> map) throws Exception {
            GetOutsideAuditGroupMessageByPageResponseBodyResponseBody self = new GetOutsideAuditGroupMessageByPageResponseBodyResponseBody();
            return TeaModel.build(map, self);
        }

        public GetOutsideAuditGroupMessageByPageResponseBodyResponseBody setMessageList(java.util.List<GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList> messageList) {
            this.messageList = messageList;
            return this;
        }
        public java.util.List<GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList> getMessageList() {
            return this.messageList;
        }

        public GetOutsideAuditGroupMessageByPageResponseBodyResponseBody setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

    }

}
