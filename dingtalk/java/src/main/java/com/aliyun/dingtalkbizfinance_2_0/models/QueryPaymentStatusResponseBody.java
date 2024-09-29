// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryPaymentStatusResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>dingXXX</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>收款账户错误</p>
     */
    @NameInMap("failReason")
    public String failReason;

    /**
     * <strong>example:</strong>
     * <p>ABC</p>
     */
    @NameInMap("instanceId")
    public String instanceId;

    /**
     * <strong>example:</strong>
     * <p>20241112</p>
     */
    @NameInMap("orderNo")
    public String orderNo;

    @NameInMap("payeeAccountInfo")
    public QueryPaymentStatusResponseBodyPayeeAccountInfo payeeAccountInfo;

    @NameInMap("payerAccountInfo")
    public QueryPaymentStatusResponseBodyPayerAccountInfo payerAccountInfo;

    /**
     * <strong>example:</strong>
     * <p>SUCCESS</p>
     */
    @NameInMap("paymentStatus")
    public String paymentStatus;

    /**
     * <strong>example:</strong>
     * <p>2024-11-11 00:00:00</p>
     */
    @NameInMap("paymentTime")
    public String paymentTime;

    /**
     * <strong>example:</strong>
     * <p>ABC</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <strong>example:</strong>
     * <p>报销</p>
     */
    @NameInMap("usage")
    public String usage;

    /**
     * <strong>example:</strong>
     * <p>504</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryPaymentStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPaymentStatusResponseBody self = new QueryPaymentStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPaymentStatusResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryPaymentStatusResponseBody setFailReason(String failReason) {
        this.failReason = failReason;
        return this;
    }
    public String getFailReason() {
        return this.failReason;
    }

    public QueryPaymentStatusResponseBody setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public QueryPaymentStatusResponseBody setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public QueryPaymentStatusResponseBody setPayeeAccountInfo(QueryPaymentStatusResponseBodyPayeeAccountInfo payeeAccountInfo) {
        this.payeeAccountInfo = payeeAccountInfo;
        return this;
    }
    public QueryPaymentStatusResponseBodyPayeeAccountInfo getPayeeAccountInfo() {
        return this.payeeAccountInfo;
    }

    public QueryPaymentStatusResponseBody setPayerAccountInfo(QueryPaymentStatusResponseBodyPayerAccountInfo payerAccountInfo) {
        this.payerAccountInfo = payerAccountInfo;
        return this;
    }
    public QueryPaymentStatusResponseBodyPayerAccountInfo getPayerAccountInfo() {
        return this.payerAccountInfo;
    }

    public QueryPaymentStatusResponseBody setPaymentStatus(String paymentStatus) {
        this.paymentStatus = paymentStatus;
        return this;
    }
    public String getPaymentStatus() {
        return this.paymentStatus;
    }

    public QueryPaymentStatusResponseBody setPaymentTime(String paymentTime) {
        this.paymentTime = paymentTime;
        return this;
    }
    public String getPaymentTime() {
        return this.paymentTime;
    }

    public QueryPaymentStatusResponseBody setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public QueryPaymentStatusResponseBody setUsage(String usage) {
        this.usage = usage;
        return this;
    }
    public String getUsage() {
        return this.usage;
    }

    public QueryPaymentStatusResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class QueryPaymentStatusResponseBodyPayeeAccountInfoBankOpenDTO extends TeaModel {
        @NameInMap("bankBranchName")
        public String bankBranchName;

        @NameInMap("bankCardNo")
        public String bankCardNo;

        @NameInMap("bankName")
        public String bankName;

        public static QueryPaymentStatusResponseBodyPayeeAccountInfoBankOpenDTO build(java.util.Map<String, ?> map) throws Exception {
            QueryPaymentStatusResponseBodyPayeeAccountInfoBankOpenDTO self = new QueryPaymentStatusResponseBodyPayeeAccountInfoBankOpenDTO();
            return TeaModel.build(map, self);
        }

        public QueryPaymentStatusResponseBodyPayeeAccountInfoBankOpenDTO setBankBranchName(String bankBranchName) {
            this.bankBranchName = bankBranchName;
            return this;
        }
        public String getBankBranchName() {
            return this.bankBranchName;
        }

        public QueryPaymentStatusResponseBodyPayeeAccountInfoBankOpenDTO setBankCardNo(String bankCardNo) {
            this.bankCardNo = bankCardNo;
            return this;
        }
        public String getBankCardNo() {
            return this.bankCardNo;
        }

        public QueryPaymentStatusResponseBodyPayeeAccountInfoBankOpenDTO setBankName(String bankName) {
            this.bankName = bankName;
            return this;
        }
        public String getBankName() {
            return this.bankName;
        }

    }

    public static class QueryPaymentStatusResponseBodyPayeeAccountInfo extends TeaModel {
        @NameInMap("bankOpenDTO")
        public QueryPaymentStatusResponseBodyPayeeAccountInfoBankOpenDTO bankOpenDTO;

        public static QueryPaymentStatusResponseBodyPayeeAccountInfo build(java.util.Map<String, ?> map) throws Exception {
            QueryPaymentStatusResponseBodyPayeeAccountInfo self = new QueryPaymentStatusResponseBodyPayeeAccountInfo();
            return TeaModel.build(map, self);
        }

        public QueryPaymentStatusResponseBodyPayeeAccountInfo setBankOpenDTO(QueryPaymentStatusResponseBodyPayeeAccountInfoBankOpenDTO bankOpenDTO) {
            this.bankOpenDTO = bankOpenDTO;
            return this;
        }
        public QueryPaymentStatusResponseBodyPayeeAccountInfoBankOpenDTO getBankOpenDTO() {
            return this.bankOpenDTO;
        }

    }

    public static class QueryPaymentStatusResponseBodyPayerAccountInfoBankOpenDTO extends TeaModel {
        @NameInMap("bankBranchName")
        public String bankBranchName;

        @NameInMap("bankCardNo")
        public String bankCardNo;

        @NameInMap("bankName")
        public String bankName;

        public static QueryPaymentStatusResponseBodyPayerAccountInfoBankOpenDTO build(java.util.Map<String, ?> map) throws Exception {
            QueryPaymentStatusResponseBodyPayerAccountInfoBankOpenDTO self = new QueryPaymentStatusResponseBodyPayerAccountInfoBankOpenDTO();
            return TeaModel.build(map, self);
        }

        public QueryPaymentStatusResponseBodyPayerAccountInfoBankOpenDTO setBankBranchName(String bankBranchName) {
            this.bankBranchName = bankBranchName;
            return this;
        }
        public String getBankBranchName() {
            return this.bankBranchName;
        }

        public QueryPaymentStatusResponseBodyPayerAccountInfoBankOpenDTO setBankCardNo(String bankCardNo) {
            this.bankCardNo = bankCardNo;
            return this;
        }
        public String getBankCardNo() {
            return this.bankCardNo;
        }

        public QueryPaymentStatusResponseBodyPayerAccountInfoBankOpenDTO setBankName(String bankName) {
            this.bankName = bankName;
            return this;
        }
        public String getBankName() {
            return this.bankName;
        }

    }

    public static class QueryPaymentStatusResponseBodyPayerAccountInfo extends TeaModel {
        @NameInMap("accountType")
        public String accountType;

        @NameInMap("bankOpenDTO")
        public QueryPaymentStatusResponseBodyPayerAccountInfoBankOpenDTO bankOpenDTO;

        @NameInMap("enterpriseAccountCode")
        public String enterpriseAccountCode;

        public static QueryPaymentStatusResponseBodyPayerAccountInfo build(java.util.Map<String, ?> map) throws Exception {
            QueryPaymentStatusResponseBodyPayerAccountInfo self = new QueryPaymentStatusResponseBodyPayerAccountInfo();
            return TeaModel.build(map, self);
        }

        public QueryPaymentStatusResponseBodyPayerAccountInfo setAccountType(String accountType) {
            this.accountType = accountType;
            return this;
        }
        public String getAccountType() {
            return this.accountType;
        }

        public QueryPaymentStatusResponseBodyPayerAccountInfo setBankOpenDTO(QueryPaymentStatusResponseBodyPayerAccountInfoBankOpenDTO bankOpenDTO) {
            this.bankOpenDTO = bankOpenDTO;
            return this;
        }
        public QueryPaymentStatusResponseBodyPayerAccountInfoBankOpenDTO getBankOpenDTO() {
            return this.bankOpenDTO;
        }

        public QueryPaymentStatusResponseBodyPayerAccountInfo setEnterpriseAccountCode(String enterpriseAccountCode) {
            this.enterpriseAccountCode = enterpriseAccountCode;
            return this;
        }
        public String getEnterpriseAccountCode() {
            return this.enterpriseAccountCode;
        }

    }

}
