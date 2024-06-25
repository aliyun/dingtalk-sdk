// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class UpdateApplicationRegFormRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ddats</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;key&quot;:&quot;value&quot;}</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dingPanFile")
    public UpdateApplicationRegFormRequestDingPanFile dingPanFile;

    public static UpdateApplicationRegFormRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateApplicationRegFormRequest self = new UpdateApplicationRegFormRequest();
        return TeaModel.build(map, self);
    }

    public UpdateApplicationRegFormRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public UpdateApplicationRegFormRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public UpdateApplicationRegFormRequest setDingPanFile(UpdateApplicationRegFormRequestDingPanFile dingPanFile) {
        this.dingPanFile = dingPanFile;
        return this;
    }
    public UpdateApplicationRegFormRequestDingPanFile getDingPanFile() {
        return this.dingPanFile;
    }

    public static class UpdateApplicationRegFormRequestDingPanFile extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>&quot;123456&quot;</p>
         */
        @NameInMap("fileId")
        public String fileId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>&quot;张三的应聘登记表（开发工程师）&quot;</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <strong>example:</strong>
         * <p>1024</p>
         */
        @NameInMap("fileSize")
        public Long fileSize;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>pdf</p>
         */
        @NameInMap("fileType")
        public String fileType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>223344</p>
         */
        @NameInMap("spaceId")
        public Long spaceId;

        public static UpdateApplicationRegFormRequestDingPanFile build(java.util.Map<String, ?> map) throws Exception {
            UpdateApplicationRegFormRequestDingPanFile self = new UpdateApplicationRegFormRequestDingPanFile();
            return TeaModel.build(map, self);
        }

        public UpdateApplicationRegFormRequestDingPanFile setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public UpdateApplicationRegFormRequestDingPanFile setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public UpdateApplicationRegFormRequestDingPanFile setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public UpdateApplicationRegFormRequestDingPanFile setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public UpdateApplicationRegFormRequestDingPanFile setSpaceId(Long spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public Long getSpaceId() {
            return this.spaceId;
        }

    }

}
