// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryFamilySchoolMessageResponseBody extends TeaModel {
    /**
     * <p>消息数据</p>
     */
    @NameInMap("messages")
    public java.util.List<BatchQueryFamilySchoolMessageResponseBodyMessages> messages;

    public static BatchQueryFamilySchoolMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryFamilySchoolMessageResponseBody self = new BatchQueryFamilySchoolMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchQueryFamilySchoolMessageResponseBody setMessages(java.util.List<BatchQueryFamilySchoolMessageResponseBodyMessages> messages) {
        this.messages = messages;
        return this;
    }
    public java.util.List<BatchQueryFamilySchoolMessageResponseBodyMessages> getMessages() {
        return this.messages;
    }

    public static class BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels extends TeaModel {
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

        public static BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels self = new BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels();
            return TeaModel.build(map, self);
        }

        public BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

        public BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels setSize(String size) {
            this.size = size;
            return this;
        }
        public String getSize() {
            return this.size;
        }

        public BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels setVideoPicMediaId(String videoPicMediaId) {
            this.videoPicMediaId = videoPicMediaId;
            return this;
        }
        public String getVideoPicMediaId() {
            return this.videoPicMediaId;
        }

    }

    public static class BatchQueryFamilySchoolMessageResponseBodyMessages extends TeaModel {
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
        public java.util.List<BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels> mediaModels;

        /**
         * <p>消息的唯一标识</p>
         */
        @NameInMap("openMsgId")
        public String openMsgId;

        public static BatchQueryFamilySchoolMessageResponseBodyMessages build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryFamilySchoolMessageResponseBodyMessages self = new BatchQueryFamilySchoolMessageResponseBodyMessages();
            return TeaModel.build(map, self);
        }

        public BatchQueryFamilySchoolMessageResponseBodyMessages setContentType(Integer contentType) {
            this.contentType = contentType;
            return this;
        }
        public Integer getContentType() {
            return this.contentType;
        }

        public BatchQueryFamilySchoolMessageResponseBodyMessages setCreateAt(Long createAt) {
            this.createAt = createAt;
            return this;
        }
        public Long getCreateAt() {
            return this.createAt;
        }

        public BatchQueryFamilySchoolMessageResponseBodyMessages setMediaModels(java.util.List<BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels> mediaModels) {
            this.mediaModels = mediaModels;
            return this;
        }
        public java.util.List<BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels> getMediaModels() {
            return this.mediaModels;
        }

        public BatchQueryFamilySchoolMessageResponseBodyMessages setOpenMsgId(String openMsgId) {
            this.openMsgId = openMsgId;
            return this;
        }
        public String getOpenMsgId() {
            return this.openMsgId;
        }

    }

}
