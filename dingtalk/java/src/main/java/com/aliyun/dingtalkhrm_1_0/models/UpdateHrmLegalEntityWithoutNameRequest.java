// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateHrmLegalEntityWithoutNameRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("createUserId")
    public String createUserId;

    @NameInMap("ext")
    public UpdateHrmLegalEntityWithoutNameRequestExt ext;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("legalEntityName")
    public String legalEntityName;

    @NameInMap("legalEntityShortName")
    public String legalEntityShortName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("legalEntityStatus")
    public Integer legalEntityStatus;

    @NameInMap("legalPersonName")
    public String legalPersonName;

    @NameInMap("dingTenantId")
    public Long dingTenantId;

    public static UpdateHrmLegalEntityWithoutNameRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateHrmLegalEntityWithoutNameRequest self = new UpdateHrmLegalEntityWithoutNameRequest();
        return TeaModel.build(map, self);
    }

    public UpdateHrmLegalEntityWithoutNameRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public UpdateHrmLegalEntityWithoutNameRequest setCreateUserId(String createUserId) {
        this.createUserId = createUserId;
        return this;
    }
    public String getCreateUserId() {
        return this.createUserId;
    }

    public UpdateHrmLegalEntityWithoutNameRequest setExt(UpdateHrmLegalEntityWithoutNameRequestExt ext) {
        this.ext = ext;
        return this;
    }
    public UpdateHrmLegalEntityWithoutNameRequestExt getExt() {
        return this.ext;
    }

    public UpdateHrmLegalEntityWithoutNameRequest setLegalEntityName(String legalEntityName) {
        this.legalEntityName = legalEntityName;
        return this;
    }
    public String getLegalEntityName() {
        return this.legalEntityName;
    }

    public UpdateHrmLegalEntityWithoutNameRequest setLegalEntityShortName(String legalEntityShortName) {
        this.legalEntityShortName = legalEntityShortName;
        return this;
    }
    public String getLegalEntityShortName() {
        return this.legalEntityShortName;
    }

    public UpdateHrmLegalEntityWithoutNameRequest setLegalEntityStatus(Integer legalEntityStatus) {
        this.legalEntityStatus = legalEntityStatus;
        return this;
    }
    public Integer getLegalEntityStatus() {
        return this.legalEntityStatus;
    }

    public UpdateHrmLegalEntityWithoutNameRequest setLegalPersonName(String legalPersonName) {
        this.legalPersonName = legalPersonName;
        return this;
    }
    public String getLegalPersonName() {
        return this.legalPersonName;
    }

    public UpdateHrmLegalEntityWithoutNameRequest setDingTenantId(Long dingTenantId) {
        this.dingTenantId = dingTenantId;
        return this;
    }
    public Long getDingTenantId() {
        return this.dingTenantId;
    }

    public static class UpdateHrmLegalEntityWithoutNameRequestExtManageAddress extends TeaModel {
        @NameInMap("areaCode")
        public String areaCode;

        @NameInMap("areaName")
        public String areaName;

        @NameInMap("cityCode")
        public String cityCode;

        @NameInMap("cityName")
        public String cityName;

        @NameInMap("countryCode")
        public String countryCode;

        @NameInMap("countryName")
        public String countryName;

        @NameInMap("detailAddress")
        public String detailAddress;

        @NameInMap("globalAreaType")
        public String globalAreaType;

        @NameInMap("provinceCode")
        public String provinceCode;

        @NameInMap("provinceName")
        public String provinceName;

        public static UpdateHrmLegalEntityWithoutNameRequestExtManageAddress build(java.util.Map<String, ?> map) throws Exception {
            UpdateHrmLegalEntityWithoutNameRequestExtManageAddress self = new UpdateHrmLegalEntityWithoutNameRequestExtManageAddress();
            return TeaModel.build(map, self);
        }

        public UpdateHrmLegalEntityWithoutNameRequestExtManageAddress setAreaCode(String areaCode) {
            this.areaCode = areaCode;
            return this;
        }
        public String getAreaCode() {
            return this.areaCode;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExtManageAddress setAreaName(String areaName) {
            this.areaName = areaName;
            return this;
        }
        public String getAreaName() {
            return this.areaName;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExtManageAddress setCityCode(String cityCode) {
            this.cityCode = cityCode;
            return this;
        }
        public String getCityCode() {
            return this.cityCode;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExtManageAddress setCityName(String cityName) {
            this.cityName = cityName;
            return this;
        }
        public String getCityName() {
            return this.cityName;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExtManageAddress setCountryCode(String countryCode) {
            this.countryCode = countryCode;
            return this;
        }
        public String getCountryCode() {
            return this.countryCode;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExtManageAddress setCountryName(String countryName) {
            this.countryName = countryName;
            return this;
        }
        public String getCountryName() {
            return this.countryName;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExtManageAddress setDetailAddress(String detailAddress) {
            this.detailAddress = detailAddress;
            return this;
        }
        public String getDetailAddress() {
            return this.detailAddress;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExtManageAddress setGlobalAreaType(String globalAreaType) {
            this.globalAreaType = globalAreaType;
            return this;
        }
        public String getGlobalAreaType() {
            return this.globalAreaType;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExtManageAddress setProvinceCode(String provinceCode) {
            this.provinceCode = provinceCode;
            return this;
        }
        public String getProvinceCode() {
            return this.provinceCode;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExtManageAddress setProvinceName(String provinceName) {
            this.provinceName = provinceName;
            return this;
        }
        public String getProvinceName() {
            return this.provinceName;
        }

    }

    public static class UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress extends TeaModel {
        @NameInMap("areaCode")
        public String areaCode;

        @NameInMap("areaName")
        public String areaName;

        @NameInMap("cityCode")
        public String cityCode;

        @NameInMap("cityName")
        public String cityName;

        @NameInMap("countryCode")
        public String countryCode;

        @NameInMap("countryName")
        public String countryName;

        @NameInMap("detailAddress")
        public String detailAddress;

        @NameInMap("globalAreaType")
        public String globalAreaType;

        @NameInMap("provinceCode")
        public String provinceCode;

        @NameInMap("provinceName")
        public String provinceName;

        public static UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress build(java.util.Map<String, ?> map) throws Exception {
            UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress self = new UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress();
            return TeaModel.build(map, self);
        }

        public UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress setAreaCode(String areaCode) {
            this.areaCode = areaCode;
            return this;
        }
        public String getAreaCode() {
            return this.areaCode;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress setAreaName(String areaName) {
            this.areaName = areaName;
            return this;
        }
        public String getAreaName() {
            return this.areaName;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress setCityCode(String cityCode) {
            this.cityCode = cityCode;
            return this;
        }
        public String getCityCode() {
            return this.cityCode;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress setCityName(String cityName) {
            this.cityName = cityName;
            return this;
        }
        public String getCityName() {
            return this.cityName;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress setCountryCode(String countryCode) {
            this.countryCode = countryCode;
            return this;
        }
        public String getCountryCode() {
            return this.countryCode;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress setCountryName(String countryName) {
            this.countryName = countryName;
            return this;
        }
        public String getCountryName() {
            return this.countryName;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress setDetailAddress(String detailAddress) {
            this.detailAddress = detailAddress;
            return this;
        }
        public String getDetailAddress() {
            return this.detailAddress;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress setGlobalAreaType(String globalAreaType) {
            this.globalAreaType = globalAreaType;
            return this;
        }
        public String getGlobalAreaType() {
            return this.globalAreaType;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress setProvinceCode(String provinceCode) {
            this.provinceCode = provinceCode;
            return this;
        }
        public String getProvinceCode() {
            return this.provinceCode;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress setProvinceName(String provinceName) {
            this.provinceName = provinceName;
            return this;
        }
        public String getProvinceName() {
            return this.provinceName;
        }

    }

    public static class UpdateHrmLegalEntityWithoutNameRequestExt extends TeaModel {
        @NameInMap("legalEntityEnName")
        public String legalEntityEnName;

        @NameInMap("legalEntityEnShortName")
        public String legalEntityEnShortName;

        @NameInMap("legalEntityType")
        public String legalEntityType;

        @NameInMap("manageAddress")
        public UpdateHrmLegalEntityWithoutNameRequestExtManageAddress manageAddress;

        @NameInMap("registrationAddress")
        public UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress registrationAddress;

        @NameInMap("registrationDate")
        public Long registrationDate;

        @NameInMap("unifiedSocialCreditCode")
        public String unifiedSocialCreditCode;

        @NameInMap("zipCode")
        public String zipCode;

        public static UpdateHrmLegalEntityWithoutNameRequestExt build(java.util.Map<String, ?> map) throws Exception {
            UpdateHrmLegalEntityWithoutNameRequestExt self = new UpdateHrmLegalEntityWithoutNameRequestExt();
            return TeaModel.build(map, self);
        }

        public UpdateHrmLegalEntityWithoutNameRequestExt setLegalEntityEnName(String legalEntityEnName) {
            this.legalEntityEnName = legalEntityEnName;
            return this;
        }
        public String getLegalEntityEnName() {
            return this.legalEntityEnName;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExt setLegalEntityEnShortName(String legalEntityEnShortName) {
            this.legalEntityEnShortName = legalEntityEnShortName;
            return this;
        }
        public String getLegalEntityEnShortName() {
            return this.legalEntityEnShortName;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExt setLegalEntityType(String legalEntityType) {
            this.legalEntityType = legalEntityType;
            return this;
        }
        public String getLegalEntityType() {
            return this.legalEntityType;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExt setManageAddress(UpdateHrmLegalEntityWithoutNameRequestExtManageAddress manageAddress) {
            this.manageAddress = manageAddress;
            return this;
        }
        public UpdateHrmLegalEntityWithoutNameRequestExtManageAddress getManageAddress() {
            return this.manageAddress;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExt setRegistrationAddress(UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress registrationAddress) {
            this.registrationAddress = registrationAddress;
            return this;
        }
        public UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress getRegistrationAddress() {
            return this.registrationAddress;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExt setRegistrationDate(Long registrationDate) {
            this.registrationDate = registrationDate;
            return this;
        }
        public Long getRegistrationDate() {
            return this.registrationDate;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExt setUnifiedSocialCreditCode(String unifiedSocialCreditCode) {
            this.unifiedSocialCreditCode = unifiedSocialCreditCode;
            return this;
        }
        public String getUnifiedSocialCreditCode() {
            return this.unifiedSocialCreditCode;
        }

        public UpdateHrmLegalEntityWithoutNameRequestExt setZipCode(String zipCode) {
            this.zipCode = zipCode;
            return this;
        }
        public String getZipCode() {
            return this.zipCode;
        }

    }

}
