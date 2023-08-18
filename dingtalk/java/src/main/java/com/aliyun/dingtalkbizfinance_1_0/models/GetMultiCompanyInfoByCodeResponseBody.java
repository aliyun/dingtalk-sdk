// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetMultiCompanyInfoByCodeResponseBody extends TeaModel {
    @NameInMap("advancedSettingList")
    public java.util.List<GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList> advancedSettingList;

    @NameInMap("companyCode")
    public String companyCode;

    @NameInMap("companyName")
    public String companyName;

    @NameInMap("remark")
    public String remark;

    @NameInMap("status")
    public String status;

    @NameInMap("taxNature")
    public String taxNature;

    @NameInMap("taxNo")
    public String taxNo;

    public static GetMultiCompanyInfoByCodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMultiCompanyInfoByCodeResponseBody self = new GetMultiCompanyInfoByCodeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMultiCompanyInfoByCodeResponseBody setAdvancedSettingList(java.util.List<GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList> advancedSettingList) {
        this.advancedSettingList = advancedSettingList;
        return this;
    }
    public java.util.List<GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList> getAdvancedSettingList() {
        return this.advancedSettingList;
    }

    public GetMultiCompanyInfoByCodeResponseBody setCompanyCode(String companyCode) {
        this.companyCode = companyCode;
        return this;
    }
    public String getCompanyCode() {
        return this.companyCode;
    }

    public GetMultiCompanyInfoByCodeResponseBody setCompanyName(String companyName) {
        this.companyName = companyName;
        return this;
    }
    public String getCompanyName() {
        return this.companyName;
    }

    public GetMultiCompanyInfoByCodeResponseBody setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public GetMultiCompanyInfoByCodeResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public GetMultiCompanyInfoByCodeResponseBody setTaxNature(String taxNature) {
        this.taxNature = taxNature;
        return this;
    }
    public String getTaxNature() {
        return this.taxNature;
    }

    public GetMultiCompanyInfoByCodeResponseBody setTaxNo(String taxNo) {
        this.taxNo = taxNo;
        return this;
    }
    public String getTaxNo() {
        return this.taxNo;
    }

    public static class GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList extends TeaModel {
        @NameInMap("advancedSettingKey")
        public String advancedSettingKey;

        @NameInMap("advancedSettingName")
        public String advancedSettingName;

        @NameInMap("endDate")
        public Long endDate;

        @NameInMap("value")
        public Boolean value;

        public static GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList build(java.util.Map<String, ?> map) throws Exception {
            GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList self = new GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList();
            return TeaModel.build(map, self);
        }

        public GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList setAdvancedSettingKey(String advancedSettingKey) {
            this.advancedSettingKey = advancedSettingKey;
            return this;
        }
        public String getAdvancedSettingKey() {
            return this.advancedSettingKey;
        }

        public GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList setAdvancedSettingName(String advancedSettingName) {
            this.advancedSettingName = advancedSettingName;
            return this;
        }
        public String getAdvancedSettingName() {
            return this.advancedSettingName;
        }

        public GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList setEndDate(Long endDate) {
            this.endDate = endDate;
            return this;
        }
        public Long getEndDate() {
            return this.endDate;
        }

        public GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList setValue(Boolean value) {
            this.value = value;
            return this;
        }
        public Boolean getValue() {
            return this.value;
        }

    }

}
