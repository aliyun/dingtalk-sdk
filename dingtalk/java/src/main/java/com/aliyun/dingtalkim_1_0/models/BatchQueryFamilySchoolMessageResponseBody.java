// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryFamilySchoolMessageResponseBody extends TeaModel {
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
         * <strong>example:</strong>
         * <p>aa.png</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <strong>example:</strong>
         * <p>png</p>
         */
        @NameInMap("fileType")
        public String fileType;

        /**
         * <strong>example:</strong>
         * <p>@12xxx34</p>
         */
        @NameInMap("mediaId")
        public String mediaId;

        /**
         * <strong>example:</strong>
         * <p>1234</p>
         */
        @NameInMap("size")
        public String size;

        /**
         * <strong>example:</strong>
         * <p><a href="https://wukong-xxxx">https://wukong-xxxx</a></p>
         */
        @NameInMap("url")
        public String url;

        /**
         * <strong>example:</strong>
         * <p>@12xx34</p>
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
        @NameInMap("contentType")
        public Integer contentType;

        @NameInMap("createAt")
        public Long createAt;

        @NameInMap("mediaModels")
        public java.util.List<BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels> mediaModels;

        /**
         * <strong>example:</strong>
         * <p>msgxxx</p>
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
