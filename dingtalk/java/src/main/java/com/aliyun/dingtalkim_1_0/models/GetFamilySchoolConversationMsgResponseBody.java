// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetFamilySchoolConversationMsgResponseBody extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("hasMore")
    public String hasMore;

    @NameInMap("messages")
    public java.util.List<GetFamilySchoolConversationMsgResponseBodyMessages> messages;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("openConversationId")
    public String openConversationId;

    public static GetFamilySchoolConversationMsgResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFamilySchoolConversationMsgResponseBody self = new GetFamilySchoolConversationMsgResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFamilySchoolConversationMsgResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetFamilySchoolConversationMsgResponseBody setHasMore(String hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public String getHasMore() {
        return this.hasMore;
    }

    public GetFamilySchoolConversationMsgResponseBody setMessages(java.util.List<GetFamilySchoolConversationMsgResponseBodyMessages> messages) {
        this.messages = messages;
        return this;
    }
    public java.util.List<GetFamilySchoolConversationMsgResponseBodyMessages> getMessages() {
        return this.messages;
    }

    public GetFamilySchoolConversationMsgResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetFamilySchoolConversationMsgResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public static class GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels extends TeaModel {
        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileType")
        public String fileType;

        @NameInMap("mediaId")
        public String mediaId;

        @NameInMap("size")
        public String size;

        @NameInMap("url")
        public String url;

        @NameInMap("videoPicMediaId")
        public String videoPicMediaId;

        public static GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels build(java.util.Map<String, ?> map) throws Exception {
            GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels self = new GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels();
            return TeaModel.build(map, self);
        }

        public GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

        public GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels setSize(String size) {
            this.size = size;
            return this;
        }
        public String getSize() {
            return this.size;
        }

        public GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels setVideoPicMediaId(String videoPicMediaId) {
            this.videoPicMediaId = videoPicMediaId;
            return this;
        }
        public String getVideoPicMediaId() {
            return this.videoPicMediaId;
        }

    }

    public static class GetFamilySchoolConversationMsgResponseBodyMessages extends TeaModel {
        @NameInMap("contentType")
        public Integer contentType;

        @NameInMap("createAt")
        public Long createAt;

        @NameInMap("mediaModels")
        public java.util.List<GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels> mediaModels;

        @NameInMap("openMsgId")
        public String openMsgId;

        public static GetFamilySchoolConversationMsgResponseBodyMessages build(java.util.Map<String, ?> map) throws Exception {
            GetFamilySchoolConversationMsgResponseBodyMessages self = new GetFamilySchoolConversationMsgResponseBodyMessages();
            return TeaModel.build(map, self);
        }

        public GetFamilySchoolConversationMsgResponseBodyMessages setContentType(Integer contentType) {
            this.contentType = contentType;
            return this;
        }
        public Integer getContentType() {
            return this.contentType;
        }

        public GetFamilySchoolConversationMsgResponseBodyMessages setCreateAt(Long createAt) {
            this.createAt = createAt;
            return this;
        }
        public Long getCreateAt() {
            return this.createAt;
        }

        public GetFamilySchoolConversationMsgResponseBodyMessages setMediaModels(java.util.List<GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels> mediaModels) {
            this.mediaModels = mediaModels;
            return this;
        }
        public java.util.List<GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels> getMediaModels() {
            return this.mediaModels;
        }

        public GetFamilySchoolConversationMsgResponseBodyMessages setOpenMsgId(String openMsgId) {
            this.openMsgId = openMsgId;
            return this;
        }
        public String getOpenMsgId() {
            return this.openMsgId;
        }

    }

}
