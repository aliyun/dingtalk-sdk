// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoAddGeneralFileRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>aaaaa</p>
     */
    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>111111</p>
     */
    @NameInMap("datasetId")
    public Long datasetId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="https://xxxxxxx.com/xxxxxx">https://xxxxxxx.com/xxxxxx</a></p>
     */
    @NameInMap("downloadUrl")
    public String downloadUrl;

    /**
     * <strong>example:</strong>
     * <p>这是一个财务制度相关的文件</p>
     */
    @NameInMap("fileDesc")
    public String fileDesc;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>aaa.doc</p>
     */
    @NameInMap("fileName")
    public String fileName;

    @NameInMap("tagList")
    public java.util.List<ChatMemoAddGeneralFileRequestTagList> tagList;

    public static ChatMemoAddGeneralFileRequest build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoAddGeneralFileRequest self = new ChatMemoAddGeneralFileRequest();
        return TeaModel.build(map, self);
    }

    public ChatMemoAddGeneralFileRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public ChatMemoAddGeneralFileRequest setDatasetId(Long datasetId) {
        this.datasetId = datasetId;
        return this;
    }
    public Long getDatasetId() {
        return this.datasetId;
    }

    public ChatMemoAddGeneralFileRequest setDownloadUrl(String downloadUrl) {
        this.downloadUrl = downloadUrl;
        return this;
    }
    public String getDownloadUrl() {
        return this.downloadUrl;
    }

    public ChatMemoAddGeneralFileRequest setFileDesc(String fileDesc) {
        this.fileDesc = fileDesc;
        return this;
    }
    public String getFileDesc() {
        return this.fileDesc;
    }

    public ChatMemoAddGeneralFileRequest setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public ChatMemoAddGeneralFileRequest setTagList(java.util.List<ChatMemoAddGeneralFileRequestTagList> tagList) {
        this.tagList = tagList;
        return this;
    }
    public java.util.List<ChatMemoAddGeneralFileRequestTagList> getTagList() {
        return this.tagList;
    }

    public static class ChatMemoAddGeneralFileRequestTagList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>产品名</p>
         */
        @NameInMap("tagName")
        public String tagName;

        @NameInMap("tagValueList")
        public java.util.List<String> tagValueList;

        public static ChatMemoAddGeneralFileRequestTagList build(java.util.Map<String, ?> map) throws Exception {
            ChatMemoAddGeneralFileRequestTagList self = new ChatMemoAddGeneralFileRequestTagList();
            return TeaModel.build(map, self);
        }

        public ChatMemoAddGeneralFileRequestTagList setTagName(String tagName) {
            this.tagName = tagName;
            return this;
        }
        public String getTagName() {
            return this.tagName;
        }

        public ChatMemoAddGeneralFileRequestTagList setTagValueList(java.util.List<String> tagValueList) {
            this.tagValueList = tagValueList;
            return this;
        }
        public java.util.List<String> getTagValueList() {
            return this.tagValueList;
        }

    }

}
