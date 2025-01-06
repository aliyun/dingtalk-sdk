// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class BatchQueryPaymentRecallFileResponseBody extends TeaModel {
    @NameInMap("paymentRecallFileList")
    public java.util.List<BatchQueryPaymentRecallFileResponseBodyPaymentRecallFileList> paymentRecallFileList;

    public static BatchQueryPaymentRecallFileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryPaymentRecallFileResponseBody self = new BatchQueryPaymentRecallFileResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchQueryPaymentRecallFileResponseBody setPaymentRecallFileList(java.util.List<BatchQueryPaymentRecallFileResponseBodyPaymentRecallFileList> paymentRecallFileList) {
        this.paymentRecallFileList = paymentRecallFileList;
        return this;
    }
    public java.util.List<BatchQueryPaymentRecallFileResponseBodyPaymentRecallFileList> getPaymentRecallFileList() {
        return this.paymentRecallFileList;
    }

    public static class BatchQueryPaymentRecallFileResponseBodyPaymentRecallFileList extends TeaModel {
        @NameInMap("detailId")
        public String detailId;

        @NameInMap("fileId")
        public String fileId;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileSize")
        public String fileSize;

        @NameInMap("fileType")
        public String fileType;

        @NameInMap("recallFileUrl")
        public String recallFileUrl;

        @NameInMap("spaceId")
        public String spaceId;

        public static BatchQueryPaymentRecallFileResponseBodyPaymentRecallFileList build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryPaymentRecallFileResponseBodyPaymentRecallFileList self = new BatchQueryPaymentRecallFileResponseBodyPaymentRecallFileList();
            return TeaModel.build(map, self);
        }

        public BatchQueryPaymentRecallFileResponseBodyPaymentRecallFileList setDetailId(String detailId) {
            this.detailId = detailId;
            return this;
        }
        public String getDetailId() {
            return this.detailId;
        }

        public BatchQueryPaymentRecallFileResponseBodyPaymentRecallFileList setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public BatchQueryPaymentRecallFileResponseBodyPaymentRecallFileList setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public BatchQueryPaymentRecallFileResponseBodyPaymentRecallFileList setFileSize(String fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public String getFileSize() {
            return this.fileSize;
        }

        public BatchQueryPaymentRecallFileResponseBodyPaymentRecallFileList setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public BatchQueryPaymentRecallFileResponseBodyPaymentRecallFileList setRecallFileUrl(String recallFileUrl) {
            this.recallFileUrl = recallFileUrl;
            return this;
        }
        public String getRecallFileUrl() {
            return this.recallFileUrl;
        }

        public BatchQueryPaymentRecallFileResponseBodyPaymentRecallFileList setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

}
