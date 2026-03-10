// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryPaymentRecallFileVTwoResponseBody extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("paymentRecallFileList")
    public java.util.List<QueryPaymentRecallFileVTwoResponseBodyPaymentRecallFileList> paymentRecallFileList;

    public static QueryPaymentRecallFileVTwoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPaymentRecallFileVTwoResponseBody self = new QueryPaymentRecallFileVTwoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPaymentRecallFileVTwoResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryPaymentRecallFileVTwoResponseBody setPaymentRecallFileList(java.util.List<QueryPaymentRecallFileVTwoResponseBodyPaymentRecallFileList> paymentRecallFileList) {
        this.paymentRecallFileList = paymentRecallFileList;
        return this;
    }
    public java.util.List<QueryPaymentRecallFileVTwoResponseBodyPaymentRecallFileList> getPaymentRecallFileList() {
        return this.paymentRecallFileList;
    }

    public static class QueryPaymentRecallFileVTwoResponseBodyPaymentRecallFileList extends TeaModel {
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

        @NameInMap("recallFileUrl")
        public String recallFileUrl;

        @NameInMap("spaceId")
        public String spaceId;

        public static QueryPaymentRecallFileVTwoResponseBodyPaymentRecallFileList build(java.util.Map<String, ?> map) throws Exception {
            QueryPaymentRecallFileVTwoResponseBodyPaymentRecallFileList self = new QueryPaymentRecallFileVTwoResponseBodyPaymentRecallFileList();
            return TeaModel.build(map, self);
        }

        public QueryPaymentRecallFileVTwoResponseBodyPaymentRecallFileList setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public QueryPaymentRecallFileVTwoResponseBodyPaymentRecallFileList setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public QueryPaymentRecallFileVTwoResponseBodyPaymentRecallFileList setFileSize(String fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public String getFileSize() {
            return this.fileSize;
        }

        public QueryPaymentRecallFileVTwoResponseBodyPaymentRecallFileList setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public QueryPaymentRecallFileVTwoResponseBodyPaymentRecallFileList setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public QueryPaymentRecallFileVTwoResponseBodyPaymentRecallFileList setOrderNo(String orderNo) {
            this.orderNo = orderNo;
            return this;
        }
        public String getOrderNo() {
            return this.orderNo;
        }

        public QueryPaymentRecallFileVTwoResponseBodyPaymentRecallFileList setPreviewUrl(String previewUrl) {
            this.previewUrl = previewUrl;
            return this;
        }
        public String getPreviewUrl() {
            return this.previewUrl;
        }

        public QueryPaymentRecallFileVTwoResponseBodyPaymentRecallFileList setRecallFileUrl(String recallFileUrl) {
            this.recallFileUrl = recallFileUrl;
            return this;
        }
        public String getRecallFileUrl() {
            return this.recallFileUrl;
        }

        public QueryPaymentRecallFileVTwoResponseBodyPaymentRecallFileList setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

}
