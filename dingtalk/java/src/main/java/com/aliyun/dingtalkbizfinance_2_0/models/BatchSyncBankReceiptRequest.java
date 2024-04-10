// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class BatchSyncBankReceiptRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<BatchSyncBankReceiptRequestBody> body;

    public static BatchSyncBankReceiptRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchSyncBankReceiptRequest self = new BatchSyncBankReceiptRequest();
        return TeaModel.build(map, self);
    }

    public BatchSyncBankReceiptRequest setBody(java.util.List<BatchSyncBankReceiptRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<BatchSyncBankReceiptRequestBody> getBody() {
        return this.body;
    }

    public static class BatchSyncBankReceiptRequestBody extends TeaModel {
        @NameInMap("fileDownloadUrl")
        public String fileDownloadUrl;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("messageId")
        public String messageId;

        @NameInMap("messageIdType")
        public String messageIdType;

        public static BatchSyncBankReceiptRequestBody build(java.util.Map<String, ?> map) throws Exception {
            BatchSyncBankReceiptRequestBody self = new BatchSyncBankReceiptRequestBody();
            return TeaModel.build(map, self);
        }

        public BatchSyncBankReceiptRequestBody setFileDownloadUrl(String fileDownloadUrl) {
            this.fileDownloadUrl = fileDownloadUrl;
            return this;
        }
        public String getFileDownloadUrl() {
            return this.fileDownloadUrl;
        }

        public BatchSyncBankReceiptRequestBody setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public BatchSyncBankReceiptRequestBody setMessageId(String messageId) {
            this.messageId = messageId;
            return this;
        }
        public String getMessageId() {
            return this.messageId;
        }

        public BatchSyncBankReceiptRequestBody setMessageIdType(String messageIdType) {
            this.messageIdType = messageIdType;
            return this;
        }
        public String getMessageIdType() {
            return this.messageIdType;
        }

    }

}
