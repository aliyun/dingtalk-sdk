// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class DeleteReceiptRequest extends TeaModel {
    /**
     * <p>单据列表，最长不超过10条</p>
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
         * <p>单据唯一编号</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>修改者工号</p>
         */
        @NameInMap("deleteUserId")
        public String deleteUserId;

        /**
         * <p>单据类型：1付款单，2收款单</p>
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
