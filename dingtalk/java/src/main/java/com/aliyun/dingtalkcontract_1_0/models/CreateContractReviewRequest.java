// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractReviewRequest extends TeaModel {
    @NameInMap("companyList")
    public java.util.List<String> companyList;

    @NameInMap("customReviewRules")
    public String customReviewRules;

    @NameInMap("fileInfo")
    public CreateContractReviewRequestFileInfo fileInfo;

    @NameInMap("originatorUserId")
    public String originatorUserId;

    @NameInMap("reviewPosition")
    public String reviewPosition;

    @NameInMap("reviewResultType")
    public String reviewResultType;

    @NameInMap("reviewType")
    public String reviewType;

    public static CreateContractReviewRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateContractReviewRequest self = new CreateContractReviewRequest();
        return TeaModel.build(map, self);
    }

    public CreateContractReviewRequest setCompanyList(java.util.List<String> companyList) {
        this.companyList = companyList;
        return this;
    }
    public java.util.List<String> getCompanyList() {
        return this.companyList;
    }

    public CreateContractReviewRequest setCustomReviewRules(String customReviewRules) {
        this.customReviewRules = customReviewRules;
        return this;
    }
    public String getCustomReviewRules() {
        return this.customReviewRules;
    }

    public CreateContractReviewRequest setFileInfo(CreateContractReviewRequestFileInfo fileInfo) {
        this.fileInfo = fileInfo;
        return this;
    }
    public CreateContractReviewRequestFileInfo getFileInfo() {
        return this.fileInfo;
    }

    public CreateContractReviewRequest setOriginatorUserId(String originatorUserId) {
        this.originatorUserId = originatorUserId;
        return this;
    }
    public String getOriginatorUserId() {
        return this.originatorUserId;
    }

    public CreateContractReviewRequest setReviewPosition(String reviewPosition) {
        this.reviewPosition = reviewPosition;
        return this;
    }
    public String getReviewPosition() {
        return this.reviewPosition;
    }

    public CreateContractReviewRequest setReviewResultType(String reviewResultType) {
        this.reviewResultType = reviewResultType;
        return this;
    }
    public String getReviewResultType() {
        return this.reviewResultType;
    }

    public CreateContractReviewRequest setReviewType(String reviewType) {
        this.reviewType = reviewType;
        return this;
    }
    public String getReviewType() {
        return this.reviewType;
    }

    public static class CreateContractReviewRequestFileInfo extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fileId")
        public String fileId;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileSize")
        public String fileSize;

        @NameInMap("fileType")
        public String fileType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        public static CreateContractReviewRequestFileInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateContractReviewRequestFileInfo self = new CreateContractReviewRequestFileInfo();
            return TeaModel.build(map, self);
        }

        public CreateContractReviewRequestFileInfo setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public CreateContractReviewRequestFileInfo setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public CreateContractReviewRequestFileInfo setFileSize(String fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public String getFileSize() {
            return this.fileSize;
        }

        public CreateContractReviewRequestFileInfo setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public CreateContractReviewRequestFileInfo setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

}
