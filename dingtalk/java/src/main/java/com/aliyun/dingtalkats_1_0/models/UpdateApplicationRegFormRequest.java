// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class UpdateApplicationRegFormRequest extends TeaModel {
    /**
     * <p>业务标识</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>应聘登记表的表单内容</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>钉盘文件信息</p>
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
         * <p>钉盘文件标识</p>
         */
        @NameInMap("fileId")
        public String fileId;

        /**
         * <p>文件名</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <p>文件大小（单位：字节）</p>
         */
        @NameInMap("fileSize")
        public Long fileSize;

        /**
         * <p>文件类型（支持：pdf，doc，docx，ppt，pptx，jpg等）</p>
         */
        @NameInMap("fileType")
        public String fileType;

        /**
         * <p>钉盘空间标识</p>
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
