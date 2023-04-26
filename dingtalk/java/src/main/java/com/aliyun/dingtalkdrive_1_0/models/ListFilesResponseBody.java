// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ListFilesResponseBody extends TeaModel {
    @NameInMap("files")
    public java.util.List<ListFilesResponseBodyFiles> files;

    @NameInMap("nextToken")
    public String nextToken;

    public static ListFilesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListFilesResponseBody self = new ListFilesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListFilesResponseBody setFiles(java.util.List<ListFilesResponseBodyFiles> files) {
        this.files = files;
        return this;
    }
    public java.util.List<ListFilesResponseBodyFiles> getFiles() {
        return this.files;
    }

    public ListFilesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class ListFilesResponseBodyFiles extends TeaModel {
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

        @NameInMap("icon")
        public String icon;

        @NameInMap("modifier")
        public String modifier;

        @NameInMap("modifyTime")
        public String modifyTime;

        @NameInMap("parentId")
        public String parentId;

        @NameInMap("spaceId")
        public String spaceId;

        @NameInMap("thumbnail")
        public String thumbnail;

        public static ListFilesResponseBodyFiles build(java.util.Map<String, ?> map) throws Exception {
            ListFilesResponseBodyFiles self = new ListFilesResponseBodyFiles();
            return TeaModel.build(map, self);
        }

        public ListFilesResponseBodyFiles setContentType(String contentType) {
            this.contentType = contentType;
            return this;
        }
        public String getContentType() {
            return this.contentType;
        }

        public ListFilesResponseBodyFiles setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListFilesResponseBodyFiles setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public ListFilesResponseBodyFiles setFileExtension(String fileExtension) {
            this.fileExtension = fileExtension;
            return this;
        }
        public String getFileExtension() {
            return this.fileExtension;
        }

        public ListFilesResponseBodyFiles setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public ListFilesResponseBodyFiles setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public ListFilesResponseBodyFiles setFilePath(String filePath) {
            this.filePath = filePath;
            return this;
        }
        public String getFilePath() {
            return this.filePath;
        }

        public ListFilesResponseBodyFiles setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public ListFilesResponseBodyFiles setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public ListFilesResponseBodyFiles setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public ListFilesResponseBodyFiles setModifier(String modifier) {
            this.modifier = modifier;
            return this;
        }
        public String getModifier() {
            return this.modifier;
        }

        public ListFilesResponseBodyFiles setModifyTime(String modifyTime) {
            this.modifyTime = modifyTime;
            return this;
        }
        public String getModifyTime() {
            return this.modifyTime;
        }

        public ListFilesResponseBodyFiles setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

        public ListFilesResponseBodyFiles setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public ListFilesResponseBodyFiles setThumbnail(String thumbnail) {
            this.thumbnail = thumbnail;
            return this;
        }
        public String getThumbnail() {
            return this.thumbnail;
        }

    }

}
