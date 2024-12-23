// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryMultiCompanyInfoResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<QueryMultiCompanyInfoResponseBodyList> list;

    public static QueryMultiCompanyInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMultiCompanyInfoResponseBody self = new QueryMultiCompanyInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMultiCompanyInfoResponseBody setList(java.util.List<QueryMultiCompanyInfoResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryMultiCompanyInfoResponseBodyList> getList() {
        return this.list;
    }

    public static class QueryMultiCompanyInfoResponseBodyListAdvancedSettingList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>relatedInvoice</p>
         */
        @NameInMap("advancedSettingKey")
        public String advancedSettingKey;

        /**
         * <strong>example:</strong>
         * <p>关联发票</p>
         */
        @NameInMap("advancedSettingName")
        public String advancedSettingName;

        /**
         * <strong>example:</strong>
         * <p>123456789</p>
         */
        @NameInMap("endDate")
        public Long endDate;

        @NameInMap("valid")
        public Boolean valid;

        @NameInMap("value")
        public Boolean value;

        public static QueryMultiCompanyInfoResponseBodyListAdvancedSettingList build(java.util.Map<String, ?> map) throws Exception {
            QueryMultiCompanyInfoResponseBodyListAdvancedSettingList self = new QueryMultiCompanyInfoResponseBodyListAdvancedSettingList();
            return TeaModel.build(map, self);
        }

        public QueryMultiCompanyInfoResponseBodyListAdvancedSettingList setAdvancedSettingKey(String advancedSettingKey) {
            this.advancedSettingKey = advancedSettingKey;
            return this;
        }
        public String getAdvancedSettingKey() {
            return this.advancedSettingKey;
        }

        public QueryMultiCompanyInfoResponseBodyListAdvancedSettingList setAdvancedSettingName(String advancedSettingName) {
            this.advancedSettingName = advancedSettingName;
            return this;
        }
        public String getAdvancedSettingName() {
            return this.advancedSettingName;
        }

        public QueryMultiCompanyInfoResponseBodyListAdvancedSettingList setEndDate(Long endDate) {
            this.endDate = endDate;
            return this;
        }
        public Long getEndDate() {
            return this.endDate;
        }

        public QueryMultiCompanyInfoResponseBodyListAdvancedSettingList setValid(Boolean valid) {
            this.valid = valid;
            return this;
        }
        public Boolean getValid() {
            return this.valid;
        }

        public QueryMultiCompanyInfoResponseBodyListAdvancedSettingList setValue(Boolean value) {
            this.value = value;
            return this;
        }
        public Boolean getValue() {
            return this.value;
        }

    }

    public static class QueryMultiCompanyInfoResponseBodyList extends TeaModel {
        @NameInMap("accountantBookId")
        public String accountantBookId;

        @NameInMap("advancedSettingList")
        public java.util.List<QueryMultiCompanyInfoResponseBodyListAdvancedSettingList> advancedSettingList;

        /**
         * <strong>example:</strong>
         * <p>COM_DEFAULT</p>
         */
        @NameInMap("companyCode")
        public String companyCode;

        /**
         * <strong>example:</strong>
         * <p>钉钉</p>
         */
        @NameInMap("companyName")
        public String companyName;

        /**
         * <strong>example:</strong>
         * <p>123456789</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <strong>example:</strong>
         * <p>备注</p>
         */
        @NameInMap("remark")
        public String remark;

        /**
         * <strong>example:</strong>
         * <p>valid</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <strong>example:</strong>
         * <p>generalTaxpayer</p>
         */
        @NameInMap("taxNature")
        public String taxNature;

        /**
         * <strong>example:</strong>
         * <p>123456789012345</p>
         */
        @NameInMap("taxNo")
        public String taxNo;

        public static QueryMultiCompanyInfoResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryMultiCompanyInfoResponseBodyList self = new QueryMultiCompanyInfoResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryMultiCompanyInfoResponseBodyList setAccountantBookId(String accountantBookId) {
            this.accountantBookId = accountantBookId;
            return this;
        }
        public String getAccountantBookId() {
            return this.accountantBookId;
        }

        public QueryMultiCompanyInfoResponseBodyList setAdvancedSettingList(java.util.List<QueryMultiCompanyInfoResponseBodyListAdvancedSettingList> advancedSettingList) {
            this.advancedSettingList = advancedSettingList;
            return this;
        }
        public java.util.List<QueryMultiCompanyInfoResponseBodyListAdvancedSettingList> getAdvancedSettingList() {
            return this.advancedSettingList;
        }

        public QueryMultiCompanyInfoResponseBodyList setCompanyCode(String companyCode) {
            this.companyCode = companyCode;
            return this;
        }
        public String getCompanyCode() {
            return this.companyCode;
        }

        public QueryMultiCompanyInfoResponseBodyList setCompanyName(String companyName) {
            this.companyName = companyName;
            return this;
        }
        public String getCompanyName() {
            return this.companyName;
        }

        public QueryMultiCompanyInfoResponseBodyList setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public QueryMultiCompanyInfoResponseBodyList setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public QueryMultiCompanyInfoResponseBodyList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QueryMultiCompanyInfoResponseBodyList setTaxNature(String taxNature) {
            this.taxNature = taxNature;
            return this;
        }
        public String getTaxNature() {
            return this.taxNature;
        }

        public QueryMultiCompanyInfoResponseBodyList setTaxNo(String taxNo) {
            this.taxNo = taxNo;
            return this;
        }
        public String getTaxNo() {
            return this.taxNo;
        }

    }

}
