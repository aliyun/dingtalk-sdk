// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryPaymentOrderDetailResponseBody extends TeaModel {
    @NameInMap("orderList")
    public java.util.List<QueryPaymentOrderDetailResponseBodyOrderList> orderList;

    @NameInMap("requestId")
    public String requestId;

    public static QueryPaymentOrderDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPaymentOrderDetailResponseBody self = new QueryPaymentOrderDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPaymentOrderDetailResponseBody setOrderList(java.util.List<QueryPaymentOrderDetailResponseBodyOrderList> orderList) {
        this.orderList = orderList;
        return this;
    }
    public java.util.List<QueryPaymentOrderDetailResponseBodyOrderList> getOrderList() {
        return this.orderList;
    }

    public QueryPaymentOrderDetailResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public static class QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTOBankDTO extends TeaModel {
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

        public static QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTOBankDTO build(java.util.Map<String, ?> map) throws Exception {
            QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTOBankDTO self = new QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTOBankDTO();
            return TeaModel.build(map, self);
        }

        public QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTOBankDTO setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTOBankDTO setBankBranchCode(String bankBranchCode) {
            this.bankBranchCode = bankBranchCode;
            return this;
        }
        public String getBankBranchCode() {
            return this.bankBranchCode;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTOBankDTO setBankBranchName(String bankBranchName) {
            this.bankBranchName = bankBranchName;
            return this;
        }
        public String getBankBranchName() {
            return this.bankBranchName;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTOBankDTO setBankCardNo(String bankCardNo) {
            this.bankCardNo = bankCardNo;
            return this;
        }
        public String getBankCardNo() {
            return this.bankCardNo;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTOBankDTO setBankCode(String bankCode) {
            this.bankCode = bankCode;
            return this;
        }
        public String getBankCode() {
            return this.bankCode;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTOBankDTO setBankName(String bankName) {
            this.bankName = bankName;
            return this;
        }
        public String getBankName() {
            return this.bankName;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTOBankDTO setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTO extends TeaModel {
        @NameInMap("bankDTO")
        public QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTOBankDTO bankDTO;

        public static QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTO build(java.util.Map<String, ?> map) throws Exception {
            QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTO self = new QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTO();
            return TeaModel.build(map, self);
        }

        public QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTO setBankDTO(QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTOBankDTO bankDTO) {
            this.bankDTO = bankDTO;
            return this;
        }
        public QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTOBankDTO getBankDTO() {
            return this.bankDTO;
        }

    }

    public static class QueryPaymentOrderDetailResponseBodyOrderListPayerAccountDTO extends TeaModel {
        @NameInMap("enterpriseAccountCode")
        public String enterpriseAccountCode;

        public static QueryPaymentOrderDetailResponseBodyOrderListPayerAccountDTO build(java.util.Map<String, ?> map) throws Exception {
            QueryPaymentOrderDetailResponseBodyOrderListPayerAccountDTO self = new QueryPaymentOrderDetailResponseBodyOrderListPayerAccountDTO();
            return TeaModel.build(map, self);
        }

        public QueryPaymentOrderDetailResponseBodyOrderListPayerAccountDTO setEnterpriseAccountCode(String enterpriseAccountCode) {
            this.enterpriseAccountCode = enterpriseAccountCode;
            return this;
        }
        public String getEnterpriseAccountCode() {
            return this.enterpriseAccountCode;
        }

    }

    public static class QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTOBankDTO extends TeaModel {
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

        public static QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTOBankDTO build(java.util.Map<String, ?> map) throws Exception {
            QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTOBankDTO self = new QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTOBankDTO();
            return TeaModel.build(map, self);
        }

        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTOBankDTO setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTOBankDTO setBankBranchCode(String bankBranchCode) {
            this.bankBranchCode = bankBranchCode;
            return this;
        }
        public String getBankBranchCode() {
            return this.bankBranchCode;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTOBankDTO setBankBranchName(String bankBranchName) {
            this.bankBranchName = bankBranchName;
            return this;
        }
        public String getBankBranchName() {
            return this.bankBranchName;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTOBankDTO setBankCardNo(String bankCardNo) {
            this.bankCardNo = bankCardNo;
            return this;
        }
        public String getBankCardNo() {
            return this.bankCardNo;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTOBankDTO setBankCode(String bankCode) {
            this.bankCode = bankCode;
            return this;
        }
        public String getBankCode() {
            return this.bankCode;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTOBankDTO setBankName(String bankName) {
            this.bankName = bankName;
            return this;
        }
        public String getBankName() {
            return this.bankName;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTOBankDTO setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTO extends TeaModel {
        @NameInMap("bankDTO")
        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTOBankDTO bankDTO;

        public static QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTO build(java.util.Map<String, ?> map) throws Exception {
            QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTO self = new QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTO();
            return TeaModel.build(map, self);
        }

        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTO setBankDTO(QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTOBankDTO bankDTO) {
            this.bankDTO = bankDTO;
            return this;
        }
        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTOBankDTO getBankDTO() {
            return this.bankDTO;
        }

    }

    public static class QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayerAccountDTO extends TeaModel {
        @NameInMap("enterpriseAccountCode")
        public String enterpriseAccountCode;

        public static QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayerAccountDTO build(java.util.Map<String, ?> map) throws Exception {
            QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayerAccountDTO self = new QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayerAccountDTO();
            return TeaModel.build(map, self);
        }

        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayerAccountDTO setEnterpriseAccountCode(String enterpriseAccountCode) {
            this.enterpriseAccountCode = enterpriseAccountCode;
            return this;
        }
        public String getEnterpriseAccountCode() {
            return this.enterpriseAccountCode;
        }

    }

    public static class QueryPaymentOrderDetailResponseBodyOrderListSubOrderList extends TeaModel {
        @NameInMap("amount")
        public String amount;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("orderNo")
        public String orderNo;

        @NameInMap("outBizNo")
        public String outBizNo;

        @NameInMap("payeeAccountDTO")
        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTO payeeAccountDTO;

        @NameInMap("payerAccountDTO")
        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayerAccountDTO payerAccountDTO;

        @NameInMap("remark")
        public String remark;

        @NameInMap("status")
        public String status;

        @NameInMap("usage")
        public String usage;

        @NameInMap("userId")
        public String userId;

        public static QueryPaymentOrderDetailResponseBodyOrderListSubOrderList build(java.util.Map<String, ?> map) throws Exception {
            QueryPaymentOrderDetailResponseBodyOrderListSubOrderList self = new QueryPaymentOrderDetailResponseBodyOrderListSubOrderList();
            return TeaModel.build(map, self);
        }

        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderList setOrderNo(String orderNo) {
            this.orderNo = orderNo;
            return this;
        }
        public String getOrderNo() {
            return this.orderNo;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderList setOutBizNo(String outBizNo) {
            this.outBizNo = outBizNo;
            return this;
        }
        public String getOutBizNo() {
            return this.outBizNo;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderList setPayeeAccountDTO(QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTO payeeAccountDTO) {
            this.payeeAccountDTO = payeeAccountDTO;
            return this;
        }
        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTO getPayeeAccountDTO() {
            return this.payeeAccountDTO;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderList setPayerAccountDTO(QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayerAccountDTO payerAccountDTO) {
            this.payerAccountDTO = payerAccountDTO;
            return this;
        }
        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayerAccountDTO getPayerAccountDTO() {
            return this.payerAccountDTO;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderList setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderList setUsage(String usage) {
            this.usage = usage;
            return this;
        }
        public String getUsage() {
            return this.usage;
        }

        public QueryPaymentOrderDetailResponseBodyOrderListSubOrderList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryPaymentOrderDetailResponseBodyOrderList extends TeaModel {
        @NameInMap("amount")
        public String amount;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("orderNo")
        public String orderNo;

        @NameInMap("outBizNo")
        public String outBizNo;

        @NameInMap("payeeAccountDTO")
        public QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTO payeeAccountDTO;

        @NameInMap("payerAccountDTO")
        public QueryPaymentOrderDetailResponseBodyOrderListPayerAccountDTO payerAccountDTO;

        @NameInMap("remark")
        public String remark;

        @NameInMap("status")
        public String status;

        @NameInMap("subOrderList")
        public java.util.List<QueryPaymentOrderDetailResponseBodyOrderListSubOrderList> subOrderList;

        @NameInMap("usage")
        public String usage;

        @NameInMap("userId")
        public String userId;

        public static QueryPaymentOrderDetailResponseBodyOrderList build(java.util.Map<String, ?> map) throws Exception {
            QueryPaymentOrderDetailResponseBodyOrderList self = new QueryPaymentOrderDetailResponseBodyOrderList();
            return TeaModel.build(map, self);
        }

        public QueryPaymentOrderDetailResponseBodyOrderList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public QueryPaymentOrderDetailResponseBodyOrderList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryPaymentOrderDetailResponseBodyOrderList setOrderNo(String orderNo) {
            this.orderNo = orderNo;
            return this;
        }
        public String getOrderNo() {
            return this.orderNo;
        }

        public QueryPaymentOrderDetailResponseBodyOrderList setOutBizNo(String outBizNo) {
            this.outBizNo = outBizNo;
            return this;
        }
        public String getOutBizNo() {
            return this.outBizNo;
        }

        public QueryPaymentOrderDetailResponseBodyOrderList setPayeeAccountDTO(QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTO payeeAccountDTO) {
            this.payeeAccountDTO = payeeAccountDTO;
            return this;
        }
        public QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTO getPayeeAccountDTO() {
            return this.payeeAccountDTO;
        }

        public QueryPaymentOrderDetailResponseBodyOrderList setPayerAccountDTO(QueryPaymentOrderDetailResponseBodyOrderListPayerAccountDTO payerAccountDTO) {
            this.payerAccountDTO = payerAccountDTO;
            return this;
        }
        public QueryPaymentOrderDetailResponseBodyOrderListPayerAccountDTO getPayerAccountDTO() {
            return this.payerAccountDTO;
        }

        public QueryPaymentOrderDetailResponseBodyOrderList setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public QueryPaymentOrderDetailResponseBodyOrderList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QueryPaymentOrderDetailResponseBodyOrderList setSubOrderList(java.util.List<QueryPaymentOrderDetailResponseBodyOrderListSubOrderList> subOrderList) {
            this.subOrderList = subOrderList;
            return this;
        }
        public java.util.List<QueryPaymentOrderDetailResponseBodyOrderListSubOrderList> getSubOrderList() {
            return this.subOrderList;
        }

        public QueryPaymentOrderDetailResponseBodyOrderList setUsage(String usage) {
            this.usage = usage;
            return this;
        }
        public String getUsage() {
            return this.usage;
        }

        public QueryPaymentOrderDetailResponseBodyOrderList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
