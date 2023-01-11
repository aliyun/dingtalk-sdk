// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class CopyFileResponseBody extends TeaModel {
    /**
     * <p>文件信息</p>
     */
    @NameInMap("file")
    public CopyFileResponseBodyFile file;

    /**
     * <p>异步任务id</p>
     */
    @NameInMap("taskId")
    public String taskId;

    public static CopyFileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CopyFileResponseBody self = new CopyFileResponseBody();
        return TeaModel.build(map, self);
    }

    public CopyFileResponseBody setFile(CopyFileResponseBodyFile file) {
        this.file = file;
        return this;
    }
    public CopyFileResponseBodyFile getFile() {
        return this.file;
    }

    public CopyFileResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public static class CopyFileResponseBodyFile extends TeaModel {
        /**
         * <p>文件内容类型</p>
         */
        @NameInMap("contentType")
        public String contentType;

        /**
         * <p>创建时间</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <p>创建者</p>
         */
        @NameInMap("creator")
        public String creator;

        /**
         * <p>文件后缀</p>
         */
        @NameInMap("fileExtension")
        public String fileExtension;

        /**
         * <p>文件id</p>
         */
        @NameInMap("fileId")
        public String fileId;

        /**
         * <p>文件名称</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <p>文件路径</p>
         */
        @NameInMap("filePath")
        public String filePath;

        /**
         * <p>文件大小</p>
         */
        @NameInMap("fileSize")
        public Long fileSize;

        /**
         * <p>文件类型</p>
         */
        @NameInMap("fileType")
        public String fileType;

        /**
         * <p>修改者</p>
         */
        @NameInMap("modifier")
        public String modifier;

        /**
         * <p>修改时间</p>
         */
        @NameInMap("modifyTime")
        public String modifyTime;

        /**
         * <p>父目录id</p>
         */
        @NameInMap("parentId")
        public String parentId;

        /**
         * <p>空间id</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        public static CopyFileResponseBodyFile build(java.util.Map<String, ?> map) throws Exception {
            CopyFileResponseBodyFile self = new CopyFileResponseBodyFile();
            return TeaModel.build(map, self);
        }

        public CopyFileResponseBodyFile setContentType(String contentType) {
            this.contentType = contentType;
            return this;
        }
        public String getContentType() {
            return this.contentType;
        }

        public CopyFileResponseBodyFile setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public CopyFileResponseBodyFile setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public CopyFileResponseBodyFile setFileExtension(String fileExtension) {
            this.fileExtension = fileExtension;
            return this;
        }
        public String getFileExtension() {
            return this.fileExtension;
        }

        public CopyFileResponseBodyFile setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public CopyFileResponseBodyFile setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public CopyFileResponseBodyFile setFilePath(String filePath) {
            this.filePath = filePath;
            return this;
        }
        public String getFilePath() {
            return this.filePath;
        }

        public CopyFileResponseBodyFile setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public CopyFileResponseBodyFile setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public CopyFileResponseBodyFile setModifier(String modifier) {
            this.modifier = modifier;
            return this;
        }
        public String getModifier() {
            return this.modifier;
        }

        public CopyFileResponseBodyFile setModifyTime(String modifyTime) {
            this.modifyTime = modifyTime;
            return this;
        }
        public String getModifyTime() {
            return this.modifyTime;
        }

        public CopyFileResponseBodyFile setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

        public CopyFileResponseBodyFile setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

}
