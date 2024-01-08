// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoGetFileListResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<ChatMemoGetFileListResponseBodyData> data;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("total")
    public Integer total;

    @NameInMap("totalPage")
    public Integer totalPage;

    public static ChatMemoGetFileListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoGetFileListResponseBody self = new ChatMemoGetFileListResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatMemoGetFileListResponseBody setData(java.util.List<ChatMemoGetFileListResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<ChatMemoGetFileListResponseBodyData> getData() {
        return this.data;
    }

    public ChatMemoGetFileListResponseBody setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ChatMemoGetFileListResponseBody setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ChatMemoGetFileListResponseBody setTotal(Integer total) {
        this.total = total;
        return this;
    }
    public Integer getTotal() {
        return this.total;
    }

    public ChatMemoGetFileListResponseBody setTotalPage(Integer totalPage) {
        this.totalPage = totalPage;
        return this;
    }
    public Integer getTotalPage() {
        return this.totalPage;
    }

    public static class ChatMemoGetFileListResponseBodyData extends TeaModel {
        @NameInMap("bizId")
        public String bizId;

        @NameInMap("fileDesc")
        public String fileDesc;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("mediaId")
        public String mediaId;

        @NameInMap("tagMap")
        public java.util.Map<String, java.util.List<String>> tagMap;

        public static ChatMemoGetFileListResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            ChatMemoGetFileListResponseBodyData self = new ChatMemoGetFileListResponseBodyData();
            return TeaModel.build(map, self);
        }

        public ChatMemoGetFileListResponseBodyData setBizId(String bizId) {
            this.bizId = bizId;
            return this;
        }
        public String getBizId() {
            return this.bizId;
        }

        public ChatMemoGetFileListResponseBodyData setFileDesc(String fileDesc) {
            this.fileDesc = fileDesc;
            return this;
        }
        public String getFileDesc() {
            return this.fileDesc;
        }

        public ChatMemoGetFileListResponseBodyData setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public ChatMemoGetFileListResponseBodyData setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

        public ChatMemoGetFileListResponseBodyData setTagMap(java.util.Map<String, java.util.List<String>> tagMap) {
            this.tagMap = tagMap;
            return this;
        }
        public java.util.Map<String, java.util.List<String>> getTagMap() {
            return this.tagMap;
        }

    }

}
