// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetFamilySchoolConversationMsgResponseBody extends TeaModel {
    /**
     * <p>企业名称，corp123</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>是否有更多数据</p>
     */
    @NameInMap("hasMore")
    public String hasMore;

    /**
     * <p>消息数据</p>
     */
    @NameInMap("messages")
    public java.util.List<GetFamilySchoolConversationMsgResponseBodyMessages> messages;

    /**
     * <p>查询下次消息的游标,时间毫秒值</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>开放群Id</p>
     */
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
        /**
         * <p>消息mediaId文件名称</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <p>消息mediaId文件类型</p>
         */
        @NameInMap("fileType")
        public String fileType;

        /**
         * <p>消息mediaId</p>
         */
        @NameInMap("mediaId")
        public String mediaId;

        /**
         * <p>消息mediaId文件大小</p>
         */
        @NameInMap("size")
        public String size;

        /**
         * <p>消息mediaId对应的下载地址</p>
         */
        @NameInMap("url")
        public String url;

        /**
         * <p>视频文件缩略图mediaId</p>
         */
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
        /**
         * <p>消息类型，2-图片、202视频、3100富文本消息</p>
         */
        @NameInMap("contentType")
        public Integer contentType;

        /**
         * <p>消息的创建时间</p>
         */
        @NameInMap("createAt")
        public Long createAt;

        /**
         * <p>media文件对象列表</p>
         */
        @NameInMap("mediaModels")
        public java.util.List<GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels> mediaModels;

        /**
         * <p>消息的唯一标识</p>
         */
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
