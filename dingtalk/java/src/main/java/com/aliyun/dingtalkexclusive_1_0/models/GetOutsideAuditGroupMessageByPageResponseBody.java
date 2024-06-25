// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetOutsideAuditGroupMessageByPageResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
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
         * <strong>example:</strong>
         * <p>user1234</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>userId</p>
         */
        @NameInMap("idType")
        public String idType;

        /**
         * <strong>example:</strong>
         * <p>user</p>
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
         * <strong>example:</strong>
         * <p>{   &quot;text&quot;: {     &quot;content&quot;: &quot;这是一段文本&quot;   } }</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <strong>example:</strong>
         * <p>text/audio/video</p>
         */
        @NameInMap("contentType")
        public String contentType;

        /**
         * <strong>example:</strong>
         * <p>2022-07-05 15:43:03</p>
         */
        @NameInMap("createAt")
        public String createAt;

        /**
         * <strong>example:</strong>
         * <p>cid123456</p>
         */
        @NameInMap("openConversationId")
        public String openConversationId;

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
        @NameInMap("messageList")
        public java.util.List<GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList> messageList;

        /**
         * <strong>example:</strong>
         * <p>1680493837428</p>
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
