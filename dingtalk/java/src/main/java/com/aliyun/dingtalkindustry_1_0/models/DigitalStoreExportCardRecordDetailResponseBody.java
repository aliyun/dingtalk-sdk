// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreExportCardRecordDetailResponseBody extends TeaModel {
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

    public static DigitalStoreExportCardRecordDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreExportCardRecordDetailResponseBody self = new DigitalStoreExportCardRecordDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public DigitalStoreExportCardRecordDetailResponseBody setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public DigitalStoreExportCardRecordDetailResponseBody setFileType(String fileType) {
        this.fileType = fileType;
        return this;
    }
    public String getFileType() {
        return this.fileType;
    }

    public DigitalStoreExportCardRecordDetailResponseBody setFileUrl(String fileUrl) {
        this.fileUrl = fileUrl;
        return this;
    }
    public String getFileUrl() {
        return this.fileUrl;
    }

    public DigitalStoreExportCardRecordDetailResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public DigitalStoreExportCardRecordDetailResponseBody setIsImport(String isImport) {
        this.isImport = isImport;
        return this;
    }
    public String getIsImport() {
        return this.isImport;
    }

    public DigitalStoreExportCardRecordDetailResponseBody setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public DigitalStoreExportCardRecordDetailResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public DigitalStoreExportCardRecordDetailResponseBody setSuccessNum(String successNum) {
        this.successNum = successNum;
        return this;
    }
    public String getSuccessNum() {
        return this.successNum;
    }

    public DigitalStoreExportCardRecordDetailResponseBody setTotalNum(String totalNum) {
        this.totalNum = totalNum;
        return this;
    }
    public String getTotalNum() {
        return this.totalNum;
    }

}
