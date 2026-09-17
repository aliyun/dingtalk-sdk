// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryAttachmentResponseBody extends TeaModel {
    @NameInMap("attachmentList")
    public java.util.List<QueryAttachmentResponseBodyAttachmentList> attachmentList;

    @NameInMap("processInstanceId")
    public String processInstanceId;

    public static QueryAttachmentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAttachmentResponseBody self = new QueryAttachmentResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAttachmentResponseBody setAttachmentList(java.util.List<QueryAttachmentResponseBodyAttachmentList> attachmentList) {
        this.attachmentList = attachmentList;
        return this;
    }
    public java.util.List<QueryAttachmentResponseBodyAttachmentList> getAttachmentList() {
        return this.attachmentList;
    }

    public QueryAttachmentResponseBody setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public static class QueryAttachmentResponseBodyAttachmentList extends TeaModel {
        @NameInMap("attachmentType")
        public String attachmentType;

        @NameInMap("downloadUrl")
        public String downloadUrl;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileSize")
        public String fileSize;

        @NameInMap("fileType")
        public String fileType;

        @NameInMap("location")
        public String location;

        public static QueryAttachmentResponseBodyAttachmentList build(java.util.Map<String, ?> map) throws Exception {
            QueryAttachmentResponseBodyAttachmentList self = new QueryAttachmentResponseBodyAttachmentList();
            return TeaModel.build(map, self);
        }

        public QueryAttachmentResponseBodyAttachmentList setAttachmentType(String attachmentType) {
            this.attachmentType = attachmentType;
            return this;
        }
        public String getAttachmentType() {
            return this.attachmentType;
        }

        public QueryAttachmentResponseBodyAttachmentList setDownloadUrl(String downloadUrl) {
            this.downloadUrl = downloadUrl;
            return this;
        }
        public String getDownloadUrl() {
            return this.downloadUrl;
        }

        public QueryAttachmentResponseBodyAttachmentList setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public QueryAttachmentResponseBodyAttachmentList setFileSize(String fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public String getFileSize() {
            return this.fileSize;
        }

        public QueryAttachmentResponseBodyAttachmentList setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public QueryAttachmentResponseBodyAttachmentList setLocation(String location) {
            this.location = location;
            return this;
        }
        public String getLocation() {
            return this.location;
        }

    }

}
