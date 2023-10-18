// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreExportCardRecordResponseBody extends TeaModel {
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

    public static DigitalStoreExportCardRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreExportCardRecordResponseBody self = new DigitalStoreExportCardRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public DigitalStoreExportCardRecordResponseBody setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public DigitalStoreExportCardRecordResponseBody setFileType(String fileType) {
        this.fileType = fileType;
        return this;
    }
    public String getFileType() {
        return this.fileType;
    }

    public DigitalStoreExportCardRecordResponseBody setFileUrl(String fileUrl) {
        this.fileUrl = fileUrl;
        return this;
    }
    public String getFileUrl() {
        return this.fileUrl;
    }

    public DigitalStoreExportCardRecordResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public DigitalStoreExportCardRecordResponseBody setIsImport(String isImport) {
        this.isImport = isImport;
        return this;
    }
    public String getIsImport() {
        return this.isImport;
    }

    public DigitalStoreExportCardRecordResponseBody setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public DigitalStoreExportCardRecordResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public DigitalStoreExportCardRecordResponseBody setSuccessNum(String successNum) {
        this.successNum = successNum;
        return this;
    }
    public String getSuccessNum() {
        return this.successNum;
    }

    public DigitalStoreExportCardRecordResponseBody setTotalNum(String totalNum) {
        this.totalNum = totalNum;
        return this;
    }
    public String getTotalNum() {
        return this.totalNum;
    }

}
