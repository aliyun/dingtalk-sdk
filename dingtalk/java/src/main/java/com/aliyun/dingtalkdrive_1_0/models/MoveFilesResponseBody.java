// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class MoveFilesResponseBody extends TeaModel {
    @NameInMap("files")
    public java.util.List<MoveFilesResponseBodyFiles> files;

    @NameInMap("taskId")
    public String taskId;

    public static MoveFilesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        MoveFilesResponseBody self = new MoveFilesResponseBody();
        return TeaModel.build(map, self);
    }

    public MoveFilesResponseBody setFiles(java.util.List<MoveFilesResponseBodyFiles> files) {
        this.files = files;
        return this;
    }
    public java.util.List<MoveFilesResponseBodyFiles> getFiles() {
        return this.files;
    }

    public MoveFilesResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public static class MoveFilesResponseBodyFiles extends TeaModel {
        @NameInMap("contentType")
        public String contentType;

        @NameInMap("createTime")
        public String createTime;

        @NameInMap("creator")
        public String creator;

        @NameInMap("fileExtension")
        public String fileExtension;

        @NameInMap("fileId")
        public String fileId;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("filePath")
        public String filePath;

        @NameInMap("fileSize")
        public Long fileSize;

        @NameInMap("fileType")
        public String fileType;

        @NameInMap("modifier")
        public String modifier;

        @NameInMap("modifyTime")
        public String modifyTime;

        @NameInMap("parentId")
        public String parentId;

        @NameInMap("spaceId")
        public String spaceId;

        public static MoveFilesResponseBodyFiles build(java.util.Map<String, ?> map) throws Exception {
            MoveFilesResponseBodyFiles self = new MoveFilesResponseBodyFiles();
            return TeaModel.build(map, self);
        }

        public MoveFilesResponseBodyFiles setContentType(String contentType) {
            this.contentType = contentType;
            return this;
        }
        public String getContentType() {
            return this.contentType;
        }

        public MoveFilesResponseBodyFiles setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public MoveFilesResponseBodyFiles setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public MoveFilesResponseBodyFiles setFileExtension(String fileExtension) {
            this.fileExtension = fileExtension;
            return this;
        }
        public String getFileExtension() {
            return this.fileExtension;
        }

        public MoveFilesResponseBodyFiles setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public MoveFilesResponseBodyFiles setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public MoveFilesResponseBodyFiles setFilePath(String filePath) {
            this.filePath = filePath;
            return this;
        }
        public String getFilePath() {
            return this.filePath;
        }

        public MoveFilesResponseBodyFiles setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public MoveFilesResponseBodyFiles setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public MoveFilesResponseBodyFiles setModifier(String modifier) {
            this.modifier = modifier;
            return this;
        }
        public String getModifier() {
            return this.modifier;
        }

        public MoveFilesResponseBodyFiles setModifyTime(String modifyTime) {
            this.modifyTime = modifyTime;
            return this;
        }
        public String getModifyTime() {
            return this.modifyTime;
        }

        public MoveFilesResponseBodyFiles setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

        public MoveFilesResponseBodyFiles setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

}
