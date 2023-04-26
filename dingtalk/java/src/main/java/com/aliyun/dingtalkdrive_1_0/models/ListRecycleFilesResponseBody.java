// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ListRecycleFilesResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("recycleItems")
    public java.util.List<ListRecycleFilesResponseBodyRecycleItems> recycleItems;

    public static ListRecycleFilesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListRecycleFilesResponseBody self = new ListRecycleFilesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListRecycleFilesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListRecycleFilesResponseBody setRecycleItems(java.util.List<ListRecycleFilesResponseBodyRecycleItems> recycleItems) {
        this.recycleItems = recycleItems;
        return this;
    }
    public java.util.List<ListRecycleFilesResponseBodyRecycleItems> getRecycleItems() {
        return this.recycleItems;
    }

    public static class ListRecycleFilesResponseBodyRecycleItems extends TeaModel {
        @NameInMap("contentType")
        public String contentType;

        @NameInMap("deleteStaffId")
        public String deleteStaffId;

        @NameInMap("deleteTime")
        public String deleteTime;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("filePath")
        public String filePath;

        @NameInMap("fileSize")
        public Long fileSize;

        @NameInMap("fileType")
        public String fileType;

        @NameInMap("recycleItemId")
        public String recycleItemId;

        public static ListRecycleFilesResponseBodyRecycleItems build(java.util.Map<String, ?> map) throws Exception {
            ListRecycleFilesResponseBodyRecycleItems self = new ListRecycleFilesResponseBodyRecycleItems();
            return TeaModel.build(map, self);
        }

        public ListRecycleFilesResponseBodyRecycleItems setContentType(String contentType) {
            this.contentType = contentType;
            return this;
        }
        public String getContentType() {
            return this.contentType;
        }

        public ListRecycleFilesResponseBodyRecycleItems setDeleteStaffId(String deleteStaffId) {
            this.deleteStaffId = deleteStaffId;
            return this;
        }
        public String getDeleteStaffId() {
            return this.deleteStaffId;
        }

        public ListRecycleFilesResponseBodyRecycleItems setDeleteTime(String deleteTime) {
            this.deleteTime = deleteTime;
            return this;
        }
        public String getDeleteTime() {
            return this.deleteTime;
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

        public ListRecycleFilesResponseBodyRecycleItems setRecycleItemId(String recycleItemId) {
            this.recycleItemId = recycleItemId;
            return this;
        }
        public String getRecycleItemId() {
            return this.recycleItemId;
        }

    }

}
