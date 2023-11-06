// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryInstancePaymentOrderDetailResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryInstancePaymentOrderDetailResponseBodyResult result;

    public static QueryInstancePaymentOrderDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryInstancePaymentOrderDetailResponseBody self = new QueryInstancePaymentOrderDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryInstancePaymentOrderDetailResponseBody setResult(QueryInstancePaymentOrderDetailResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryInstancePaymentOrderDetailResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTOBankOpenDTO extends TeaModel {
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

        public static QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTOBankOpenDTO build(java.util.Map<String, ?> map) throws Exception {
            QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTOBankOpenDTO self = new QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTOBankOpenDTO();
            return TeaModel.build(map, self);
        }

        public QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTOBankOpenDTO setBankBranchCode(String bankBranchCode) {
            this.bankBranchCode = bankBranchCode;
            return this;
        }
        public String getBankBranchCode() {
            return this.bankBranchCode;
        }

        public QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTOBankOpenDTO setBankBranchName(String bankBranchName) {
            this.bankBranchName = bankBranchName;
            return this;
        }
        public String getBankBranchName() {
            return this.bankBranchName;
        }

        public QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTOBankOpenDTO setBankCardNo(String bankCardNo) {
            this.bankCardNo = bankCardNo;
            return this;
        }
        public String getBankCardNo() {
            return this.bankCardNo;
        }

        public QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTOBankOpenDTO setBankCode(String bankCode) {
            this.bankCode = bankCode;
            return this;
        }
        public String getBankCode() {
            return this.bankCode;
        }

        public QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTOBankOpenDTO setBankName(String bankName) {
            this.bankName = bankName;
            return this;
        }
        public String getBankName() {
            return this.bankName;
        }

        public QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTOBankOpenDTO setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTO extends TeaModel {
        @NameInMap("bankOpenDTO")
        public QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTOBankOpenDTO bankOpenDTO;

        public static QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTO build(java.util.Map<String, ?> map) throws Exception {
            QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTO self = new QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTO();
            return TeaModel.build(map, self);
        }

        public QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTO setBankOpenDTO(QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTOBankOpenDTO bankOpenDTO) {
            this.bankOpenDTO = bankOpenDTO;
            return this;
        }
        public QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTOBankOpenDTO getBankOpenDTO() {
            return this.bankOpenDTO;
        }

    }

    public static class QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTOBankOpenDTO extends TeaModel {
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

        public static QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTOBankOpenDTO build(java.util.Map<String, ?> map) throws Exception {
            QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTOBankOpenDTO self = new QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTOBankOpenDTO();
            return TeaModel.build(map, self);
        }

        public QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTOBankOpenDTO setBankBranchCode(String bankBranchCode) {
            this.bankBranchCode = bankBranchCode;
            return this;
        }
        public String getBankBranchCode() {
            return this.bankBranchCode;
        }

        public QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTOBankOpenDTO setBankBranchName(String bankBranchName) {
            this.bankBranchName = bankBranchName;
            return this;
        }
        public String getBankBranchName() {
            return this.bankBranchName;
        }

        public QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTOBankOpenDTO setBankCardNo(String bankCardNo) {
            this.bankCardNo = bankCardNo;
            return this;
        }
        public String getBankCardNo() {
            return this.bankCardNo;
        }

        public QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTOBankOpenDTO setBankCode(String bankCode) {
            this.bankCode = bankCode;
            return this;
        }
        public String getBankCode() {
            return this.bankCode;
        }

        public QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTOBankOpenDTO setBankName(String bankName) {
            this.bankName = bankName;
            return this;
        }
        public String getBankName() {
            return this.bankName;
        }

        public QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTOBankOpenDTO setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTO extends TeaModel {
        @NameInMap("bankOpenDTO")
        public QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTOBankOpenDTO bankOpenDTO;

        @NameInMap("enterpriseAccountCode")
        public String enterpriseAccountCode;

        public static QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTO build(java.util.Map<String, ?> map) throws Exception {
            QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTO self = new QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTO();
            return TeaModel.build(map, self);
        }

        public QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTO setBankOpenDTO(QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTOBankOpenDTO bankOpenDTO) {
            this.bankOpenDTO = bankOpenDTO;
            return this;
        }
        public QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTOBankOpenDTO getBankOpenDTO() {
            return this.bankOpenDTO;
        }

        public QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTO setEnterpriseAccountCode(String enterpriseAccountCode) {
            this.enterpriseAccountCode = enterpriseAccountCode;
            return this;
        }
        public String getEnterpriseAccountCode() {
            return this.enterpriseAccountCode;
        }

    }

    public static class QueryInstancePaymentOrderDetailResponseBodyResult extends TeaModel {
        @NameInMap("amount")
        public String amount;

        @NameInMap("instanceId")
        public String instanceId;

        @NameInMap("payeeAccountDTO")
        public QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTO payeeAccountDTO;

        @NameInMap("payerAccountDTO")
        public QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTO payerAccountDTO;

        @NameInMap("remark")
        public String remark;

        @NameInMap("usage")
        public String usage;

        @NameInMap("userId")
        public String userId;

        public static QueryInstancePaymentOrderDetailResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryInstancePaymentOrderDetailResponseBodyResult self = new QueryInstancePaymentOrderDetailResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryInstancePaymentOrderDetailResponseBodyResult setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public QueryInstancePaymentOrderDetailResponseBodyResult setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public QueryInstancePaymentOrderDetailResponseBodyResult setPayeeAccountDTO(QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTO payeeAccountDTO) {
            this.payeeAccountDTO = payeeAccountDTO;
            return this;
        }
        public QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTO getPayeeAccountDTO() {
            return this.payeeAccountDTO;
        }

        public QueryInstancePaymentOrderDetailResponseBodyResult setPayerAccountDTO(QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTO payerAccountDTO) {
            this.payerAccountDTO = payerAccountDTO;
            return this;
        }
        public QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTO getPayerAccountDTO() {
            return this.payerAccountDTO;
        }

        public QueryInstancePaymentOrderDetailResponseBodyResult setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public QueryInstancePaymentOrderDetailResponseBodyResult setUsage(String usage) {
            this.usage = usage;
            return this;
        }
        public String getUsage() {
            return this.usage;
        }

        public QueryInstancePaymentOrderDetailResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
