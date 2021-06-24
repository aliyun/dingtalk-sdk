// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ListRecycleFilesResponseBody extends TeaModel {
    // 回收站文件列表
    @NameInMap("recycleItems")
    public java.util.List<ListRecycleFilesResponseBodyRecycleItems> recycleItems;

    // 加载更多锚点, nextToken不为空表示有更多数据
    @NameInMap("nextToken")
    public String nextToken;

    public static ListRecycleFilesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListRecycleFilesResponseBody self = new ListRecycleFilesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListRecycleFilesResponseBody setRecycleItems(java.util.List<ListRecycleFilesResponseBodyRecycleItems> recycleItems) {
        this.recycleItems = recycleItems;
        return this;
    }
    public java.util.List<ListRecycleFilesResponseBodyRecycleItems> getRecycleItems() {
        return this.recycleItems;
    }

    public ListRecycleFilesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class ListRecycleFilesResponseBodyRecycleItems extends TeaModel {
        // 回收站item id
        @NameInMap("recycleItemId")
        public String recycleItemId;

        // 删除时间
        @NameInMap("deleteTime")
        public String deleteTime;

        // 文件大小
        @NameInMap("fileSize")
        public Long fileSize;

        // 文件类型
        @NameInMap("fileType")
        public String fileType;

        // 文件内容类型
        @NameInMap("contentType")
        public String contentType;

        // 文件名称
        @NameInMap("fileName")
        public String fileName;

        // 文件路径
        @NameInMap("filePath")
        public String filePath;

        public static ListRecycleFilesResponseBodyRecycleItems build(java.util.Map<String, ?> map) throws Exception {
            ListRecycleFilesResponseBodyRecycleItems self = new ListRecycleFilesResponseBodyRecycleItems();
            return TeaModel.build(map, self);
        }

        public ListRecycleFilesResponseBodyRecycleItems setRecycleItemId(String recycleItemId) {
            this.recycleItemId = recycleItemId;
            return this;
        }
        public String getRecycleItemId() {
            return this.recycleItemId;
        }

        public ListRecycleFilesResponseBodyRecycleItems setDeleteTime(String deleteTime) {
            this.deleteTime = deleteTime;
            return this;
        }
        public String getDeleteTime() {
            return this.deleteTime;
        }

        public ListRecycleFilesResponseBodyRecycleItems setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public ListRecycleFilesResponseBodyRecycleItems setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public ListRecycleFilesResponseBodyRecycleItems setContentType(String contentType) {
            this.contentType = contentType;
            return this;
        }
        public String getContentType() {
            return this.contentType;
        }

        public ListRecycleFilesResponseBodyRecycleItems setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public ListRecycleFilesResponseBodyRecycleItems setFilePath(String filePath) {
            this.filePath = filePath;
            return this;
        }
        public String getFilePath() {
            return this.filePath;
        }

    }

}
