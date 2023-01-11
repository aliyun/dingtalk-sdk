// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ListFilesResponseBody extends TeaModel {
    /**
     * <p>文件列表</p>
     */
    @NameInMap("files")
    public java.util.List<ListFilesResponseBodyFiles> files;

    /**
     * <p>分页加载锚点, nextToken不为空表示有更多数据</p>
     */
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
         * <p>文件图标</p>
         */
        @NameInMap("icon")
        public String icon;

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

        /**
         * <p>文件缩略图</p>
         */
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
