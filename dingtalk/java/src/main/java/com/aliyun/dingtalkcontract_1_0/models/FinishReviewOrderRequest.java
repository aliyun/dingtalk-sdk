// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class FinishReviewOrderRequest extends TeaModel {
    @NameInMap("endFiles")
    public java.util.List<FinishReviewOrderRequestEndFiles> endFiles;

    /**
     * <strong>example:</strong>
     * <p>{}</p>
     */
    @NameInMap("extension")
    public String extension;

    /**
     * <strong>example:</strong>
     * <p>12345678</p>
     */
    @NameInMap("orderId")
    public String orderId;

    public static FinishReviewOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        FinishReviewOrderRequest self = new FinishReviewOrderRequest();
        return TeaModel.build(map, self);
    }

    public FinishReviewOrderRequest setEndFiles(java.util.List<FinishReviewOrderRequestEndFiles> endFiles) {
        this.endFiles = endFiles;
        return this;
    }
    public java.util.List<FinishReviewOrderRequestEndFiles> getEndFiles() {
        return this.endFiles;
    }

    public FinishReviewOrderRequest setExtension(String extension) {
        this.extension = extension;
        return this;
    }
    public String getExtension() {
        return this.extension;
    }

    public FinishReviewOrderRequest setOrderId(String orderId) {
        this.orderId = orderId;
        return this;
    }
    public String getOrderId() {
        return this.orderId;
    }

    public static class FinishReviewOrderRequestEndFiles extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>合同文件</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <strong>example:</strong>
         * <p>12</p>
         */
        @NameInMap("fileSize")
        public String fileSize;

        /**
         * <strong>example:</strong>
         * <p>word</p>
         */
        @NameInMap("fileType")
        public String fileType;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("fileVersion")
        public Integer fileVersion;

        /**
         * <strong>example:</strong>
         * <p><a href="http://oss.com">http://oss.com</a></p>
         */
        @NameInMap("url")
        public String url;

        public static FinishReviewOrderRequestEndFiles build(java.util.Map<String, ?> map) throws Exception {
            FinishReviewOrderRequestEndFiles self = new FinishReviewOrderRequestEndFiles();
            return TeaModel.build(map, self);
        }

        public FinishReviewOrderRequestEndFiles setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public FinishReviewOrderRequestEndFiles setFileSize(String fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public String getFileSize() {
            return this.fileSize;
        }

        public FinishReviewOrderRequestEndFiles setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public FinishReviewOrderRequestEndFiles setFileVersion(Integer fileVersion) {
            this.fileVersion = fileVersion;
            return this;
        }
        public Integer getFileVersion() {
            return this.fileVersion;
        }

        public FinishReviewOrderRequestEndFiles setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
