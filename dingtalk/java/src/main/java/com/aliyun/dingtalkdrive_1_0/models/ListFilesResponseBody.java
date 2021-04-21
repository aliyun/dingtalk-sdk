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

        // 文件后缀
        @NameInMap("fileExtension")
        public String fileExtension;

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

        public ListFilesResponseBodyFiles setFileExtension(String fileExtension) {
            this.fileExtension = fileExtension;
            return this;
        }
        public String getFileExtension() {
            return this.fileExtension;
        }

    }

}
