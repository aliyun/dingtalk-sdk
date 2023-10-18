// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStorelistExportTaskRecordResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<DigitalStorelistExportTaskRecordResponseBodyContent> content;

    public static DigitalStorelistExportTaskRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DigitalStorelistExportTaskRecordResponseBody self = new DigitalStorelistExportTaskRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public DigitalStorelistExportTaskRecordResponseBody setContent(java.util.List<DigitalStorelistExportTaskRecordResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<DigitalStorelistExportTaskRecordResponseBodyContent> getContent() {
        return this.content;
    }

    public static class DigitalStorelistExportTaskRecordResponseBodyContent extends TeaModel {
        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileType")
        public String fileType;

        @NameInMap("fileUrl")
        public String fileUrl;

        @NameInMap("id")
        public String id;

        @NameInMap("isImport")
        public String isImport;

        @NameInMap("remark")
        public String remark;

        @NameInMap("status")
        public String status;

        @NameInMap("successNum")
        public String successNum;

        @NameInMap("totalNum")
        public String totalNum;

        public static DigitalStorelistExportTaskRecordResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            DigitalStorelistExportTaskRecordResponseBodyContent self = new DigitalStorelistExportTaskRecordResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public DigitalStorelistExportTaskRecordResponseBodyContent setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public DigitalStorelistExportTaskRecordResponseBodyContent setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public DigitalStorelistExportTaskRecordResponseBodyContent setFileUrl(String fileUrl) {
            this.fileUrl = fileUrl;
            return this;
        }
        public String getFileUrl() {
            return this.fileUrl;
        }

        public DigitalStorelistExportTaskRecordResponseBodyContent setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public DigitalStorelistExportTaskRecordResponseBodyContent setIsImport(String isImport) {
            this.isImport = isImport;
            return this;
        }
        public String getIsImport() {
            return this.isImport;
        }

        public DigitalStorelistExportTaskRecordResponseBodyContent setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public DigitalStorelistExportTaskRecordResponseBodyContent setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public DigitalStorelistExportTaskRecordResponseBodyContent setSuccessNum(String successNum) {
            this.successNum = successNum;
            return this;
        }
        public String getSuccessNum() {
            return this.successNum;
        }

        public DigitalStorelistExportTaskRecordResponseBodyContent setTotalNum(String totalNum) {
            this.totalNum = totalNum;
            return this;
        }
        public String getTotalNum() {
            return this.totalNum;
        }

    }

}
