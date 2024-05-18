// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AddHrmLegalEntityRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("createUserId")
    public String createUserId;

    @NameInMap("ext")
    public AddHrmLegalEntityRequestExt ext;

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

    public static AddHrmLegalEntityRequest build(java.util.Map<String, ?> map) throws Exception {
        AddHrmLegalEntityRequest self = new AddHrmLegalEntityRequest();
        return TeaModel.build(map, self);
    }

    public AddHrmLegalEntityRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public AddHrmLegalEntityRequest setCreateUserId(String createUserId) {
        this.createUserId = createUserId;
        return this;
    }
    public String getCreateUserId() {
        return this.createUserId;
    }

    public AddHrmLegalEntityRequest setExt(AddHrmLegalEntityRequestExt ext) {
        this.ext = ext;
        return this;
    }
    public AddHrmLegalEntityRequestExt getExt() {
        return this.ext;
    }

    public AddHrmLegalEntityRequest setLegalEntityName(String legalEntityName) {
        this.legalEntityName = legalEntityName;
        return this;
    }
    public String getLegalEntityName() {
        return this.legalEntityName;
    }

    public AddHrmLegalEntityRequest setLegalEntityShortName(String legalEntityShortName) {
        this.legalEntityShortName = legalEntityShortName;
        return this;
    }
    public String getLegalEntityShortName() {
        return this.legalEntityShortName;
    }

    public AddHrmLegalEntityRequest setLegalEntityStatus(Integer legalEntityStatus) {
        this.legalEntityStatus = legalEntityStatus;
        return this;
    }
    public Integer getLegalEntityStatus() {
        return this.legalEntityStatus;
    }

    public AddHrmLegalEntityRequest setLegalPersonName(String legalPersonName) {
        this.legalPersonName = legalPersonName;
        return this;
    }
    public String getLegalPersonName() {
        return this.legalPersonName;
    }

    public AddHrmLegalEntityRequest setDingTenantId(Long dingTenantId) {
        this.dingTenantId = dingTenantId;
        return this;
    }
    public Long getDingTenantId() {
        return this.dingTenantId;
    }

    public static class AddHrmLegalEntityRequestExtManageAddress extends TeaModel {
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

        public static AddHrmLegalEntityRequestExtManageAddress build(java.util.Map<String, ?> map) throws Exception {
            AddHrmLegalEntityRequestExtManageAddress self = new AddHrmLegalEntityRequestExtManageAddress();
            return TeaModel.build(map, self);
        }

        public AddHrmLegalEntityRequestExtManageAddress setAreaCode(String areaCode) {
            this.areaCode = areaCode;
            return this;
        }
        public String getAreaCode() {
            return this.areaCode;
        }

        public AddHrmLegalEntityRequestExtManageAddress setAreaName(String areaName) {
            this.areaName = areaName;
            return this;
        }
        public String getAreaName() {
            return this.areaName;
        }

        public AddHrmLegalEntityRequestExtManageAddress setCityCode(String cityCode) {
            this.cityCode = cityCode;
            return this;
        }
        public String getCityCode() {
            return this.cityCode;
        }

        public AddHrmLegalEntityRequestExtManageAddress setCityName(String cityName) {
            this.cityName = cityName;
            return this;
        }
        public String getCityName() {
            return this.cityName;
        }

        public AddHrmLegalEntityRequestExtManageAddress setCountryCode(String countryCode) {
            this.countryCode = countryCode;
            return this;
        }
        public String getCountryCode() {
            return this.countryCode;
        }

        public AddHrmLegalEntityRequestExtManageAddress setCountryName(String countryName) {
            this.countryName = countryName;
            return this;
        }
        public String getCountryName() {
            return this.countryName;
        }

        public AddHrmLegalEntityRequestExtManageAddress setDetailAddress(String detailAddress) {
            this.detailAddress = detailAddress;
            return this;
        }
        public String getDetailAddress() {
            return this.detailAddress;
        }

        public AddHrmLegalEntityRequestExtManageAddress setGlobalAreaType(String globalAreaType) {
            this.globalAreaType = globalAreaType;
            return this;
        }
        public String getGlobalAreaType() {
            return this.globalAreaType;
        }

        public AddHrmLegalEntityRequestExtManageAddress setProvinceCode(String provinceCode) {
            this.provinceCode = provinceCode;
            return this;
        }
        public String getProvinceCode() {
            return this.provinceCode;
        }

        public AddHrmLegalEntityRequestExtManageAddress setProvinceName(String provinceName) {
            this.provinceName = provinceName;
            return this;
        }
        public String getProvinceName() {
            return this.provinceName;
        }

    }

    public static class AddHrmLegalEntityRequestExtRegistrationAddress extends TeaModel {
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

        public static AddHrmLegalEntityRequestExtRegistrationAddress build(java.util.Map<String, ?> map) throws Exception {
            AddHrmLegalEntityRequestExtRegistrationAddress self = new AddHrmLegalEntityRequestExtRegistrationAddress();
            return TeaModel.build(map, self);
        }

        public AddHrmLegalEntityRequestExtRegistrationAddress setAreaCode(String areaCode) {
            this.areaCode = areaCode;
            return this;
        }
        public String getAreaCode() {
            return this.areaCode;
        }

        public AddHrmLegalEntityRequestExtRegistrationAddress setAreaName(String areaName) {
            this.areaName = areaName;
            return this;
        }
        public String getAreaName() {
            return this.areaName;
        }

        public AddHrmLegalEntityRequestExtRegistrationAddress setCityCode(String cityCode) {
            this.cityCode = cityCode;
            return this;
        }
        public String getCityCode() {
            return this.cityCode;
        }

        public AddHrmLegalEntityRequestExtRegistrationAddress setCityName(String cityName) {
            this.cityName = cityName;
            return this;
        }
        public String getCityName() {
            return this.cityName;
        }

        public AddHrmLegalEntityRequestExtRegistrationAddress setCountryCode(String countryCode) {
            this.countryCode = countryCode;
            return this;
        }
        public String getCountryCode() {
            return this.countryCode;
        }

        public AddHrmLegalEntityRequestExtRegistrationAddress setCountryName(String countryName) {
            this.countryName = countryName;
            return this;
        }
        public String getCountryName() {
            return this.countryName;
        }

        public AddHrmLegalEntityRequestExtRegistrationAddress setDetailAddress(String detailAddress) {
            this.detailAddress = detailAddress;
            return this;
        }
        public String getDetailAddress() {
            return this.detailAddress;
        }

        public AddHrmLegalEntityRequestExtRegistrationAddress setGlobalAreaType(String globalAreaType) {
            this.globalAreaType = globalAreaType;
            return this;
        }
        public String getGlobalAreaType() {
            return this.globalAreaType;
        }

        public AddHrmLegalEntityRequestExtRegistrationAddress setProvinceCode(String provinceCode) {
            this.provinceCode = provinceCode;
            return this;
        }
        public String getProvinceCode() {
            return this.provinceCode;
        }

        public AddHrmLegalEntityRequestExtRegistrationAddress setProvinceName(String provinceName) {
            this.provinceName = provinceName;
            return this;
        }
        public String getProvinceName() {
            return this.provinceName;
        }

    }

    public static class AddHrmLegalEntityRequestExt extends TeaModel {
        @NameInMap("legalEntityEnName")
        public String legalEntityEnName;

        @NameInMap("legalEntityEnShortName")
        public String legalEntityEnShortName;

        @NameInMap("legalEntityType")
        public String legalEntityType;

        @NameInMap("manageAddress")
        public AddHrmLegalEntityRequestExtManageAddress manageAddress;

        @NameInMap("registrationAddress")
        public AddHrmLegalEntityRequestExtRegistrationAddress registrationAddress;

        @NameInMap("registrationDate")
        public Long registrationDate;

        @NameInMap("unifiedSocialCreditCode")
        public String unifiedSocialCreditCode;

        @NameInMap("zipCode")
        public String zipCode;

        public static AddHrmLegalEntityRequestExt build(java.util.Map<String, ?> map) throws Exception {
            AddHrmLegalEntityRequestExt self = new AddHrmLegalEntityRequestExt();
            return TeaModel.build(map, self);
        }

        public AddHrmLegalEntityRequestExt setLegalEntityEnName(String legalEntityEnName) {
            this.legalEntityEnName = legalEntityEnName;
            return this;
        }
        public String getLegalEntityEnName() {
            return this.legalEntityEnName;
        }

        public AddHrmLegalEntityRequestExt setLegalEntityEnShortName(String legalEntityEnShortName) {
            this.legalEntityEnShortName = legalEntityEnShortName;
            return this;
        }
        public String getLegalEntityEnShortName() {
            return this.legalEntityEnShortName;
        }

        public AddHrmLegalEntityRequestExt setLegalEntityType(String legalEntityType) {
            this.legalEntityType = legalEntityType;
            return this;
        }
        public String getLegalEntityType() {
            return this.legalEntityType;
        }

        public AddHrmLegalEntityRequestExt setManageAddress(AddHrmLegalEntityRequestExtManageAddress manageAddress) {
            this.manageAddress = manageAddress;
            return this;
        }
        public AddHrmLegalEntityRequestExtManageAddress getManageAddress() {
            return this.manageAddress;
        }

        public AddHrmLegalEntityRequestExt setRegistrationAddress(AddHrmLegalEntityRequestExtRegistrationAddress registrationAddress) {
            this.registrationAddress = registrationAddress;
            return this;
        }
        public AddHrmLegalEntityRequestExtRegistrationAddress getRegistrationAddress() {
            return this.registrationAddress;
        }

        public AddHrmLegalEntityRequestExt setRegistrationDate(Long registrationDate) {
            this.registrationDate = registrationDate;
            return this;
        }
        public Long getRegistrationDate() {
            return this.registrationDate;
        }

        public AddHrmLegalEntityRequestExt setUnifiedSocialCreditCode(String unifiedSocialCreditCode) {
            this.unifiedSocialCreditCode = unifiedSocialCreditCode;
            return this;
        }
        public String getUnifiedSocialCreditCode() {
            return this.unifiedSocialCreditCode;
        }

        public AddHrmLegalEntityRequestExt setZipCode(String zipCode) {
            this.zipCode = zipCode;
            return this;
        }
        public String getZipCode() {
            return this.zipCode;
        }

    }

}
