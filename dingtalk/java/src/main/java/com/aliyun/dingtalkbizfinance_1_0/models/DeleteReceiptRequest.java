// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class DeleteReceiptRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("receipts")
    public java.util.List<DeleteReceiptRequestReceipts> receipts;

    public static DeleteReceiptRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteReceiptRequest self = new DeleteReceiptRequest();
        return TeaModel.build(map, self);
    }

    public DeleteReceiptRequest setReceipts(java.util.List<DeleteReceiptRequestReceipts> receipts) {
        this.receipts = receipts;
        return this;
    }
    public java.util.List<DeleteReceiptRequestReceipts> getReceipts() {
        return this.receipts;
    }

    public static class DeleteReceiptRequestReceipts extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("deleteUserId")
        public String deleteUserId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("receiptType")
        public Long receiptType;

        public static DeleteReceiptRequestReceipts build(java.util.Map<String, ?> map) throws Exception {
            DeleteReceiptRequestReceipts self = new DeleteReceiptRequestReceipts();
            return TeaModel.build(map, self);
        }

        public DeleteReceiptRequestReceipts setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public DeleteReceiptRequestReceipts setDeleteUserId(String deleteUserId) {
            this.deleteUserId = deleteUserId;
            return this;
        }
        public String getDeleteUserId() {
            return this.deleteUserId;
        }

        public DeleteReceiptRequestReceipts setReceiptType(Long receiptType) {
            this.receiptType = receiptType;
            return this;
        }
        public Long getReceiptType() {
            return this.receiptType;
        }

    }

}
