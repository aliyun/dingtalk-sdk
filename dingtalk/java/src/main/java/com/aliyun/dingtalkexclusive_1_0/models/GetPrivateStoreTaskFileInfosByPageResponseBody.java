// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPrivateStoreTaskFileInfosByPageResponseBody extends TeaModel {
    @NameInMap("items")
    public java.util.List<GetPrivateStoreTaskFileInfosByPageResponseBodyItems> items;

    /**
     * <strong>example:</strong>
     * <p>123abc</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("total")
    public Integer total;

    public static GetPrivateStoreTaskFileInfosByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPrivateStoreTaskFileInfosByPageResponseBody self = new GetPrivateStoreTaskFileInfosByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPrivateStoreTaskFileInfosByPageResponseBody setItems(java.util.List<GetPrivateStoreTaskFileInfosByPageResponseBodyItems> items) {
        this.items = items;
        return this;
    }
    public java.util.List<GetPrivateStoreTaskFileInfosByPageResponseBodyItems> getItems() {
        return this.items;
    }

    public GetPrivateStoreTaskFileInfosByPageResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetPrivateStoreTaskFileInfosByPageResponseBody setTotal(Integer total) {
        this.total = total;
        return this;
    }
    public Integer getTotal() {
        return this.total;
    }

    public static class GetPrivateStoreTaskFileInfosByPageResponseBodyItems extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>普通文件</p>
         */
        @NameInMap("classTagName")
        public String classTagName;

        /**
         * <strong>example:</strong>
         * <p>1234</p>
         */
        @NameInMap("dentryId")
        public String dentryId;

        /**
         * <strong>example:</strong>
         * <p>1234566</p>
         */
        @NameInMap("fileCreateTime")
        public Long fileCreateTime;

        /**
         * <strong>example:</strong>
         * <p>安装包</p>
         */
        @NameInMap("fileFormatName")
        public String fileFormatName;

        /**
         * <strong>example:</strong>
         * <p>1234566</p>
         */
        @NameInMap("fileModifiedTime")
        public Long fileModifiedTime;

        /**
         * <strong>example:</strong>
         * <p>我的表格.xls</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <strong>example:</strong>
         * <p>钉钉云盘</p>
         */
        @NameInMap("fileScopeName")
        public String fileScopeName;

        /**
         * <strong>example:</strong>
         * <p>1GB</p>
         */
        @NameInMap("fileSizeName")
        public String fileSizeName;

        /**
         * <strong>example:</strong>
         * <p>1234</p>
         */
        @NameInMap("spaceId")
        public Long spaceId;

        public static GetPrivateStoreTaskFileInfosByPageResponseBodyItems build(java.util.Map<String, ?> map) throws Exception {
            GetPrivateStoreTaskFileInfosByPageResponseBodyItems self = new GetPrivateStoreTaskFileInfosByPageResponseBodyItems();
            return TeaModel.build(map, self);
        }

        public GetPrivateStoreTaskFileInfosByPageResponseBodyItems setClassTagName(String classTagName) {
            this.classTagName = classTagName;
            return this;
        }
        public String getClassTagName() {
            return this.classTagName;
        }

        public GetPrivateStoreTaskFileInfosByPageResponseBodyItems setDentryId(String dentryId) {
            this.dentryId = dentryId;
            return this;
        }
        public String getDentryId() {
            return this.dentryId;
        }

        public GetPrivateStoreTaskFileInfosByPageResponseBodyItems setFileCreateTime(Long fileCreateTime) {
            this.fileCreateTime = fileCreateTime;
            return this;
        }
        public Long getFileCreateTime() {
            return this.fileCreateTime;
        }

        public GetPrivateStoreTaskFileInfosByPageResponseBodyItems setFileFormatName(String fileFormatName) {
            this.fileFormatName = fileFormatName;
            return this;
        }
        public String getFileFormatName() {
            return this.fileFormatName;
        }

        public GetPrivateStoreTaskFileInfosByPageResponseBodyItems setFileModifiedTime(Long fileModifiedTime) {
            this.fileModifiedTime = fileModifiedTime;
            return this;
        }
        public Long getFileModifiedTime() {
            return this.fileModifiedTime;
        }

        public GetPrivateStoreTaskFileInfosByPageResponseBodyItems setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public GetPrivateStoreTaskFileInfosByPageResponseBodyItems setFileScopeName(String fileScopeName) {
            this.fileScopeName = fileScopeName;
            return this;
        }
        public String getFileScopeName() {
            return this.fileScopeName;
        }

        public GetPrivateStoreTaskFileInfosByPageResponseBodyItems setFileSizeName(String fileSizeName) {
            this.fileSizeName = fileSizeName;
            return this;
        }
        public String getFileSizeName() {
            return this.fileSizeName;
        }

        public GetPrivateStoreTaskFileInfosByPageResponseBodyItems setSpaceId(Long spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public Long getSpaceId() {
            return this.spaceId;
        }

    }

}
