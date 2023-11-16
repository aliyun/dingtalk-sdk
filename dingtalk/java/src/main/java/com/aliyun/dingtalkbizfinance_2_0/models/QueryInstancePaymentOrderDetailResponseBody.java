// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryInstancePaymentOrderDetailResponseBody extends TeaModel {
    @NameInMap("amount")
    public String amount;

    @NameInMap("instanceId")
    public String instanceId;

    @NameInMap("payeeAccountDTO")
    public QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTO payeeAccountDTO;

    @NameInMap("payerAccountDTO")
    public QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTO payerAccountDTO;

    @NameInMap("remark")
    public String remark;

    @NameInMap("usage")
    public String usage;

    @NameInMap("userId")
    public String userId;

    public static QueryInstancePaymentOrderDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryInstancePaymentOrderDetailResponseBody self = new QueryInstancePaymentOrderDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryInstancePaymentOrderDetailResponseBody setAmount(String amount) {
        this.amount = amount;
        return this;
    }
    public String getAmount() {
        return this.amount;
    }

    public QueryInstancePaymentOrderDetailResponseBody setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public QueryInstancePaymentOrderDetailResponseBody setPayeeAccountDTO(QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTO payeeAccountDTO) {
        this.payeeAccountDTO = payeeAccountDTO;
        return this;
    }
    public QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTO getPayeeAccountDTO() {
        return this.payeeAccountDTO;
    }

    public QueryInstancePaymentOrderDetailResponseBody setPayerAccountDTO(QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTO payerAccountDTO) {
        this.payerAccountDTO = payerAccountDTO;
        return this;
    }
    public QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTO getPayerAccountDTO() {
        return this.payerAccountDTO;
    }

    public QueryInstancePaymentOrderDetailResponseBody setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public QueryInstancePaymentOrderDetailResponseBody setUsage(String usage) {
        this.usage = usage;
        return this;
    }
    public String getUsage() {
        return this.usage;
    }

    public QueryInstancePaymentOrderDetailResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO extends TeaModel {
        @NameInMap("accountName")
        public String accountName;

        @NameInMap("bankBranchCode")
        public String bankBranchCode;

        @NameInMap("bankBranchName")
        public String bankBranchName;

        @NameInMap("bankCardNo")
        public String bankCardNo;

        @NameInMap("bankCode")
        public String bankCode;

        @NameInMap("bankName")
        public String bankName;

        @NameInMap("type")
        public String type;

        public static QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO build(java.util.Map<String, ?> map) throws Exception {
            QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO self = new QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO();
            return TeaModel.build(map, self);
        }

        public QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

        public QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO setBankBranchCode(String bankBranchCode) {
            this.bankBranchCode = bankBranchCode;
            return this;
        }
        public String getBankBranchCode() {
            return this.bankBranchCode;
        }

        public QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO setBankBranchName(String bankBranchName) {
            this.bankBranchName = bankBranchName;
            return this;
        }
        public String getBankBranchName() {
            return this.bankBranchName;
        }

        public QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO setBankCardNo(String bankCardNo) {
            this.bankCardNo = bankCardNo;
            return this;
        }
        public String getBankCardNo() {
            return this.bankCardNo;
        }

        public QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO setBankCode(String bankCode) {
            this.bankCode = bankCode;
            return this;
        }
        public String getBankCode() {
            return this.bankCode;
        }

        public QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO setBankName(String bankName) {
            this.bankName = bankName;
            return this;
        }
        public String getBankName() {
            return this.bankName;
        }

        public QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTO extends TeaModel {
        @NameInMap("bankOpenDTO")
        public QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO bankOpenDTO;

        public static QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTO build(java.util.Map<String, ?> map) throws Exception {
            QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTO self = new QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTO();
            return TeaModel.build(map, self);
        }

        public QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTO setBankOpenDTO(QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO bankOpenDTO) {
            this.bankOpenDTO = bankOpenDTO;
            return this;
        }
        public QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO getBankOpenDTO() {
            return this.bankOpenDTO;
        }

    }

    public static class QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO extends TeaModel {
        @NameInMap("accountName")
        public String accountName;

        @NameInMap("bankBranchCode")
        public String bankBranchCode;

        @NameInMap("bankBranchName")
        public String bankBranchName;

        @NameInMap("bankCardNo")
        public String bankCardNo;

        @NameInMap("bankCode")
        public String bankCode;

        @NameInMap("bankName")
        public String bankName;

        @NameInMap("type")
        public String type;

        public static QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO build(java.util.Map<String, ?> map) throws Exception {
            QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO self = new QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO();
            return TeaModel.build(map, self);
        }

        public QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

        public QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO setBankBranchCode(String bankBranchCode) {
            this.bankBranchCode = bankBranchCode;
            return this;
        }
        public String getBankBranchCode() {
            return this.bankBranchCode;
        }

        public QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO setBankBranchName(String bankBranchName) {
            this.bankBranchName = bankBranchName;
            return this;
        }
        public String getBankBranchName() {
            return this.bankBranchName;
        }

        public QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO setBankCardNo(String bankCardNo) {
            this.bankCardNo = bankCardNo;
            return this;
        }
        public String getBankCardNo() {
            return this.bankCardNo;
        }

        public QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO setBankCode(String bankCode) {
            this.bankCode = bankCode;
            return this;
        }
        public String getBankCode() {
            return this.bankCode;
        }

        public QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO setBankName(String bankName) {
            this.bankName = bankName;
            return this;
        }
        public String getBankName() {
            return this.bankName;
        }

        public QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTO extends TeaModel {
        @NameInMap("bankOpenDTO")
        public QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO bankOpenDTO;

        @NameInMap("enterpriseAccountCode")
        public String enterpriseAccountCode;

        public static QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTO build(java.util.Map<String, ?> map) throws Exception {
            QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTO self = new QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTO();
            return TeaModel.build(map, self);
        }

        public QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTO setBankOpenDTO(QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO bankOpenDTO) {
            this.bankOpenDTO = bankOpenDTO;
            return this;
        }
        public QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO getBankOpenDTO() {
            return this.bankOpenDTO;
        }

        public QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTO setEnterpriseAccountCode(String enterpriseAccountCode) {
            this.enterpriseAccountCode = enterpriseAccountCode;
            return this;
        }
        public String getEnterpriseAccountCode() {
            return this.enterpriseAccountCode;
        }

    }

}
