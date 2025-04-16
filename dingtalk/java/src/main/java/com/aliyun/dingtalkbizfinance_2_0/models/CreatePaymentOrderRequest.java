// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class CreatePaymentOrderRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("amount")
    public String amount;

    /**
     * <strong>example:</strong>
     * <p>1741941518884</p>
     */
    @NameInMap("expireTime")
    public Long expireTime;

    /**
     * <strong>example:</strong>
     * <p>xxxxabc</p>
     */
    @NameInMap("outBizNo")
    public String outBizNo;

    @NameInMap("payeeAccountDTO")
    public CreatePaymentOrderRequestPayeeAccountDTO payeeAccountDTO;

    @NameInMap("payerAccountDTO")
    public CreatePaymentOrderRequestPayerAccountDTO payerAccountDTO;

    /**
     * <strong>example:</strong>
     * <p>日常报销</p>
     */
    @NameInMap("paymentOrderTitle")
    public String paymentOrderTitle;

    /**
     * <strong>example:</strong>
     * <p>备注</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <strong>example:</strong>
     * <p>付款用途</p>
     */
    @NameInMap("usage")
    public String usage;

    /**
     * <strong>example:</strong>
     * <p>5046195764756652</p>
     */
    @NameInMap("userId")
    public String userId;

    public static CreatePaymentOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        CreatePaymentOrderRequest self = new CreatePaymentOrderRequest();
        return TeaModel.build(map, self);
    }

    public CreatePaymentOrderRequest setAmount(String amount) {
        this.amount = amount;
        return this;
    }
    public String getAmount() {
        return this.amount;
    }

    public CreatePaymentOrderRequest setExpireTime(Long expireTime) {
        this.expireTime = expireTime;
        return this;
    }
    public Long getExpireTime() {
        return this.expireTime;
    }

    public CreatePaymentOrderRequest setOutBizNo(String outBizNo) {
        this.outBizNo = outBizNo;
        return this;
    }
    public String getOutBizNo() {
        return this.outBizNo;
    }

    public CreatePaymentOrderRequest setPayeeAccountDTO(CreatePaymentOrderRequestPayeeAccountDTO payeeAccountDTO) {
        this.payeeAccountDTO = payeeAccountDTO;
        return this;
    }
    public CreatePaymentOrderRequestPayeeAccountDTO getPayeeAccountDTO() {
        return this.payeeAccountDTO;
    }

    public CreatePaymentOrderRequest setPayerAccountDTO(CreatePaymentOrderRequestPayerAccountDTO payerAccountDTO) {
        this.payerAccountDTO = payerAccountDTO;
        return this;
    }
    public CreatePaymentOrderRequestPayerAccountDTO getPayerAccountDTO() {
        return this.payerAccountDTO;
    }

    public CreatePaymentOrderRequest setPaymentOrderTitle(String paymentOrderTitle) {
        this.paymentOrderTitle = paymentOrderTitle;
        return this;
    }
    public String getPaymentOrderTitle() {
        return this.paymentOrderTitle;
    }

    public CreatePaymentOrderRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public CreatePaymentOrderRequest setUsage(String usage) {
        this.usage = usage;
        return this;
    }
    public String getUsage() {
        return this.usage;
    }

    public CreatePaymentOrderRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class CreatePaymentOrderRequestPayeeAccountDTOBankOpenDTO extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>钉钉中国</p>
         */
        @NameInMap("accountName")
        public String accountName;

        /**
         * <strong>example:</strong>
         * <p>1025884624512</p>
         */
        @NameInMap("bankBranchCode")
        public String bankBranchCode;

        /**
         * <strong>example:</strong>
         * <p>招商银行杭州余杭分行</p>
         */
        @NameInMap("bankBranchName")
        public String bankBranchName;

        /**
         * <strong>example:</strong>
         * <p>122215111012</p>
         */
        @NameInMap("bankCardNo")
        public String bankCardNo;

        /**
         * <strong>example:</strong>
         * <p>ICBC</p>
         */
        @NameInMap("bankCode")
        public String bankCode;

        /**
         * <strong>example:</strong>
         * <p>招商银行</p>
         */
        @NameInMap("bankName")
        public String bankName;

        /**
         * <strong>example:</strong>
         * <p>PERSONAL_BANK_CARD</p>
         */
        @NameInMap("type")
        public String type;

        public static CreatePaymentOrderRequestPayeeAccountDTOBankOpenDTO build(java.util.Map<String, ?> map) throws Exception {
            CreatePaymentOrderRequestPayeeAccountDTOBankOpenDTO self = new CreatePaymentOrderRequestPayeeAccountDTOBankOpenDTO();
            return TeaModel.build(map, self);
        }

        public CreatePaymentOrderRequestPayeeAccountDTOBankOpenDTO setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

        public CreatePaymentOrderRequestPayeeAccountDTOBankOpenDTO setBankBranchCode(String bankBranchCode) {
            this.bankBranchCode = bankBranchCode;
            return this;
        }
        public String getBankBranchCode() {
            return this.bankBranchCode;
        }

        public CreatePaymentOrderRequestPayeeAccountDTOBankOpenDTO setBankBranchName(String bankBranchName) {
            this.bankBranchName = bankBranchName;
            return this;
        }
        public String getBankBranchName() {
            return this.bankBranchName;
        }

        public CreatePaymentOrderRequestPayeeAccountDTOBankOpenDTO setBankCardNo(String bankCardNo) {
            this.bankCardNo = bankCardNo;
            return this;
        }
        public String getBankCardNo() {
            return this.bankCardNo;
        }

        public CreatePaymentOrderRequestPayeeAccountDTOBankOpenDTO setBankCode(String bankCode) {
            this.bankCode = bankCode;
            return this;
        }
        public String getBankCode() {
            return this.bankCode;
        }

        public CreatePaymentOrderRequestPayeeAccountDTOBankOpenDTO setBankName(String bankName) {
            this.bankName = bankName;
            return this;
        }
        public String getBankName() {
            return this.bankName;
        }

        public CreatePaymentOrderRequestPayeeAccountDTOBankOpenDTO setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class CreatePaymentOrderRequestPayeeAccountDTO extends TeaModel {
        @NameInMap("bankOpenDTO")
        public CreatePaymentOrderRequestPayeeAccountDTOBankOpenDTO bankOpenDTO;

        public static CreatePaymentOrderRequestPayeeAccountDTO build(java.util.Map<String, ?> map) throws Exception {
            CreatePaymentOrderRequestPayeeAccountDTO self = new CreatePaymentOrderRequestPayeeAccountDTO();
            return TeaModel.build(map, self);
        }

        public CreatePaymentOrderRequestPayeeAccountDTO setBankOpenDTO(CreatePaymentOrderRequestPayeeAccountDTOBankOpenDTO bankOpenDTO) {
            this.bankOpenDTO = bankOpenDTO;
            return this;
        }
        public CreatePaymentOrderRequestPayeeAccountDTOBankOpenDTO getBankOpenDTO() {
            return this.bankOpenDTO;
        }

    }

    public static class CreatePaymentOrderRequestPayerAccountDTO extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>ACC_XXXXX</p>
         */
        @NameInMap("enterpriseAccountCode")
        public String enterpriseAccountCode;

        public static CreatePaymentOrderRequestPayerAccountDTO build(java.util.Map<String, ?> map) throws Exception {
            CreatePaymentOrderRequestPayerAccountDTO self = new CreatePaymentOrderRequestPayerAccountDTO();
            return TeaModel.build(map, self);
        }

        public CreatePaymentOrderRequestPayerAccountDTO setEnterpriseAccountCode(String enterpriseAccountCode) {
            this.enterpriseAccountCode = enterpriseAccountCode;
            return this;
        }
        public String getEnterpriseAccountCode() {
            return this.enterpriseAccountCode;
        }

    }

}
