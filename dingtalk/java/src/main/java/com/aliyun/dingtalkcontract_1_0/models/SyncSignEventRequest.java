// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class SyncSignEventRequest extends TeaModel {
    @NameInMap("contractBizId")
    public String contractBizId;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("extInfo")
    public java.util.Map<String, String> extInfo;

    @NameInMap("sealType")
    public java.util.List<String> sealType;

    @NameInMap("signDate")
    public Long signDate;

    @NameInMap("signFileList")
    public java.util.List<SyncSignEventRequestSignFileList> signFileList;

    @NameInMap("staffId")
    public String staffId;

    public static SyncSignEventRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncSignEventRequest self = new SyncSignEventRequest();
        return TeaModel.build(map, self);
    }

    public SyncSignEventRequest setContractBizId(String contractBizId) {
        this.contractBizId = contractBizId;
        return this;
    }
    public String getContractBizId() {
        return this.contractBizId;
    }

    public SyncSignEventRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public SyncSignEventRequest setExtInfo(java.util.Map<String, String> extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public java.util.Map<String, String> getExtInfo() {
        return this.extInfo;
    }

    public SyncSignEventRequest setSealType(java.util.List<String> sealType) {
        this.sealType = sealType;
        return this;
    }
    public java.util.List<String> getSealType() {
        return this.sealType;
    }

    public SyncSignEventRequest setSignDate(Long signDate) {
        this.signDate = signDate;
        return this;
    }
    public Long getSignDate() {
        return this.signDate;
    }

    public SyncSignEventRequest setSignFileList(java.util.List<SyncSignEventRequestSignFileList> signFileList) {
        this.signFileList = signFileList;
        return this;
    }
    public java.util.List<SyncSignEventRequestSignFileList> getSignFileList() {
        return this.signFileList;
    }

    public SyncSignEventRequest setStaffId(String staffId) {
        this.staffId = staffId;
        return this;
    }
    public String getStaffId() {
        return this.staffId;
    }

    public static class SyncSignEventRequestSignFileList extends TeaModel {
        @NameInMap("fileDownloadUrl")
        public String fileDownloadUrl;

        @NameInMap("fileId")
        public String fileId;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileSize")
        public Long fileSize;

        @NameInMap("fileType")
        public String fileType;

        @NameInMap("spaceId")
        public String spaceId;

        public static SyncSignEventRequestSignFileList build(java.util.Map<String, ?> map) throws Exception {
            SyncSignEventRequestSignFileList self = new SyncSignEventRequestSignFileList();
            return TeaModel.build(map, self);
        }

        public SyncSignEventRequestSignFileList setFileDownloadUrl(String fileDownloadUrl) {
            this.fileDownloadUrl = fileDownloadUrl;
            return this;
        }
        public String getFileDownloadUrl() {
            return this.fileDownloadUrl;
        }

        public SyncSignEventRequestSignFileList setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public SyncSignEventRequestSignFileList setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public SyncSignEventRequestSignFileList setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public SyncSignEventRequestSignFileList setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public SyncSignEventRequestSignFileList setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

}
