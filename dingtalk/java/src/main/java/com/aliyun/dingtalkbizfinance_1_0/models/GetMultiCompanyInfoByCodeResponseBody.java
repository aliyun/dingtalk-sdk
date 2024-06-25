// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetMultiCompanyInfoByCodeResponseBody extends TeaModel {
    @NameInMap("advancedSettingList")
    public java.util.List<GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList> advancedSettingList;

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
        /**
         * <strong>example:</strong>
         * <p>relateedInvoice</p>
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
