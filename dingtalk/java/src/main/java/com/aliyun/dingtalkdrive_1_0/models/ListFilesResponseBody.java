// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ListFilesResponseBody extends TeaModel {
    // 文件列表
    @NameInMap("files")
    public java.util.List<ListFilesResponseBodyFiles> files;

    // 分页加载锚点, nextToken不为空表示有更多数据
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
        // 空间id
        @NameInMap("spaceId")
        public String spaceId;

        // 父目录id
        @NameInMap("parentId")
        public String parentId;

        // 文件id
        @NameInMap("fileId")
        public String fileId;

        // 文件名称
        @NameInMap("fileName")
        public String fileName;

        // 文件路径
        @NameInMap("filePath")
        public String filePath;

        // 文件类型
        @NameInMap("fileType")
        public String fileType;

        // 文件内容类型
        @NameInMap("contentType")
        public String contentType;

        // 文件后缀
        @NameInMap("fileExtension")
        public String fileExtension;

        // 文件大小
        @NameInMap("fileSize")
        public Long fileSize;

        // 文件缩略图
        @NameInMap("thumbnail")
        public String thumbnail;

        // 文件图标
        @NameInMap("icon")
        public String icon;

        // 创建时间
        @NameInMap("createTime")
        public String createTime;

        // 修改时间
        @NameInMap("modifyTime")
        public String modifyTime;

        // 创建者
        @NameInMap("creator")
        public String creator;

        // 修改者
        @NameInMap("modifier")
        public String modifier;

        public static ListFilesResponseBodyFiles build(java.util.Map<String, ?> map) throws Exception {
            ListFilesResponseBodyFiles self = new ListFilesResponseBodyFiles();
            return TeaModel.build(map, self);
        }

        public ListFilesResponseBodyFiles setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public ListFilesResponseBodyFiles setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
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

        public ListFilesResponseBodyFiles setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public ListFilesResponseBodyFiles setContentType(String contentType) {
            this.contentType = contentType;
            return this;
        }
        public String getContentType() {
            return this.contentType;
        }

        public ListFilesResponseBodyFiles setFileExtension(String fileExtension) {
            this.fileExtension = fileExtension;
            return this;
        }
        public String getFileExtension() {
            return this.fileExtension;
        }

        public ListFilesResponseBodyFiles setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public ListFilesResponseBodyFiles setThumbnail(String thumbnail) {
            this.thumbnail = thumbnail;
            return this;
        }
        public String getThumbnail() {
            return this.thumbnail;
        }

        public ListFilesResponseBodyFiles setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public ListFilesResponseBodyFiles setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListFilesResponseBodyFiles setModifyTime(String modifyTime) {
            this.modifyTime = modifyTime;
            return this;
        }
        public String getModifyTime() {
            return this.modifyTime;
        }

        public ListFilesResponseBodyFiles setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public ListFilesResponseBodyFiles setModifier(String modifier) {
            this.modifier = modifier;
            return this;
        }
        public String getModifier() {
            return this.modifier;
        }

    }

}
