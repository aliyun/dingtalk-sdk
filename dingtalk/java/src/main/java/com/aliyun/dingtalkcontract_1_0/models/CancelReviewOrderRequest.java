// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CancelReviewOrderRequest extends TeaModel {
    @NameInMap("endFiles")
    public java.util.List<CancelReviewOrderRequestEndFiles> endFiles;

    @NameInMap("extension")
    public String extension;

    @NameInMap("orderId")
    public String orderId;

    public static CancelReviewOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelReviewOrderRequest self = new CancelReviewOrderRequest();
        return TeaModel.build(map, self);
    }

    public CancelReviewOrderRequest setEndFiles(java.util.List<CancelReviewOrderRequestEndFiles> endFiles) {
        this.endFiles = endFiles;
        return this;
    }
    public java.util.List<CancelReviewOrderRequestEndFiles> getEndFiles() {
        return this.endFiles;
    }

    public CancelReviewOrderRequest setExtension(String extension) {
        this.extension = extension;
        return this;
    }
    public String getExtension() {
        return this.extension;
    }

    public CancelReviewOrderRequest setOrderId(String orderId) {
        this.orderId = orderId;
        return this;
    }
    public String getOrderId() {
        return this.orderId;
    }

    public static class CancelReviewOrderRequestEndFiles extends TeaModel {
        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileSize")
        public String fileSize;

        @NameInMap("fileType")
        public String fileType;

        @NameInMap("fileVersion")
        public Integer fileVersion;

        @NameInMap("url")
        public String url;

        public static CancelReviewOrderRequestEndFiles build(java.util.Map<String, ?> map) throws Exception {
            CancelReviewOrderRequestEndFiles self = new CancelReviewOrderRequestEndFiles();
            return TeaModel.build(map, self);
        }

        public CancelReviewOrderRequestEndFiles setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public CancelReviewOrderRequestEndFiles setFileSize(String fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public String getFileSize() {
            return this.fileSize;
        }

        public CancelReviewOrderRequestEndFiles setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public CancelReviewOrderRequestEndFiles setFileVersion(Integer fileVersion) {
            this.fileVersion = fileVersion;
            return this;
        }
        public Integer getFileVersion() {
            return this.fileVersion;
        }

        public CancelReviewOrderRequestEndFiles setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
