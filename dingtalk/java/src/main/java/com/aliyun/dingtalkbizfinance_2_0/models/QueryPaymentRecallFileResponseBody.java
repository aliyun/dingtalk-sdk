// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryPaymentRecallFileResponseBody extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("paymentRecallFileList")
    public java.util.List<QueryPaymentRecallFileResponseBodyPaymentRecallFileList> paymentRecallFileList;

    public static QueryPaymentRecallFileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPaymentRecallFileResponseBody self = new QueryPaymentRecallFileResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPaymentRecallFileResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryPaymentRecallFileResponseBody setPaymentRecallFileList(java.util.List<QueryPaymentRecallFileResponseBodyPaymentRecallFileList> paymentRecallFileList) {
        this.paymentRecallFileList = paymentRecallFileList;
        return this;
    }
    public java.util.List<QueryPaymentRecallFileResponseBodyPaymentRecallFileList> getPaymentRecallFileList() {
        return this.paymentRecallFileList;
    }

    public static class QueryPaymentRecallFileResponseBodyPaymentRecallFileList extends TeaModel {
        @NameInMap("fileId")
        public String fileId;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileSize")
        public String fileSize;

        @NameInMap("fileType")
        public String fileType;

        @NameInMap("instanceId")
        public String instanceId;

        @NameInMap("orderNo")
        public String orderNo;

        @NameInMap("previewUrl")
        public String previewUrl;

        @NameInMap("spaceId")
        public String spaceId;

        public static QueryPaymentRecallFileResponseBodyPaymentRecallFileList build(java.util.Map<String, ?> map) throws Exception {
            QueryPaymentRecallFileResponseBodyPaymentRecallFileList self = new QueryPaymentRecallFileResponseBodyPaymentRecallFileList();
            return TeaModel.build(map, self);
        }

        public QueryPaymentRecallFileResponseBodyPaymentRecallFileList setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public QueryPaymentRecallFileResponseBodyPaymentRecallFileList setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public QueryPaymentRecallFileResponseBodyPaymentRecallFileList setFileSize(String fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public String getFileSize() {
            return this.fileSize;
        }

        public QueryPaymentRecallFileResponseBodyPaymentRecallFileList setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public QueryPaymentRecallFileResponseBodyPaymentRecallFileList setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public QueryPaymentRecallFileResponseBodyPaymentRecallFileList setOrderNo(String orderNo) {
            this.orderNo = orderNo;
            return this;
        }
        public String getOrderNo() {
            return this.orderNo;
        }

        public QueryPaymentRecallFileResponseBodyPaymentRecallFileList setPreviewUrl(String previewUrl) {
            this.previewUrl = previewUrl;
            return this;
        }
        public String getPreviewUrl() {
            return this.previewUrl;
        }

        public QueryPaymentRecallFileResponseBodyPaymentRecallFileList setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

}
