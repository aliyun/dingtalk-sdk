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
        @NameInMap("advancedSettingKey")
        public String advancedSettingKey;

        @NameInMap("advancedSettingName")
        public String advancedSettingName;

        @NameInMap("endDate")
        public Long endDate;

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

        public QueryMultiCompanyInfoResponseBodyListAdvancedSettingList setValue(Boolean value) {
            this.value = value;
            return this;
        }
        public Boolean getValue() {
            return this.value;
        }

    }

    public static class QueryMultiCompanyInfoResponseBodyList extends TeaModel {
        @NameInMap("advancedSettingList")
        public java.util.List<QueryMultiCompanyInfoResponseBodyListAdvancedSettingList> advancedSettingList;

        @NameInMap("companyCode")
        public String companyCode;

        @NameInMap("companyName")
        public String companyName;

        @NameInMap("createTime")
        public String createTime;

        @NameInMap("remark")
        public String remark;

        @NameInMap("status")
        public String status;

        @NameInMap("taxNature")
        public String taxNature;

        @NameInMap("taxNo")
        public String taxNo;

        public static QueryMultiCompanyInfoResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryMultiCompanyInfoResponseBodyList self = new QueryMultiCompanyInfoResponseBodyList();
            return TeaModel.build(map, self);
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
