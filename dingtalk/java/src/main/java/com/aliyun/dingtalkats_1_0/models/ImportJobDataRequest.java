// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class ImportJobDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public java.util.List<ImportJobDataRequestBody> body;

    public static ImportJobDataRequest build(java.util.Map<String, ?> map) throws Exception {
        ImportJobDataRequest self = new ImportJobDataRequest();
        return TeaModel.build(map, self);
    }

    public ImportJobDataRequest setBody(java.util.List<ImportJobDataRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<ImportJobDataRequestBody> getBody() {
        return this.body;
    }

    public static class ImportJobDataRequestBodyAddress extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("cityCode")
        public String cityCode;

        @NameInMap("customName")
        public String customName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("districtCode")
        public String districtCode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("latitude")
        public String latitude;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("longitude")
        public String longitude;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("provinceCode")
        public String provinceCode;

        public static ImportJobDataRequestBodyAddress build(java.util.Map<String, ?> map) throws Exception {
            ImportJobDataRequestBodyAddress self = new ImportJobDataRequestBodyAddress();
            return TeaModel.build(map, self);
        }

        public ImportJobDataRequestBodyAddress setCityCode(String cityCode) {
            this.cityCode = cityCode;
            return this;
        }
        public String getCityCode() {
            return this.cityCode;
        }

        public ImportJobDataRequestBodyAddress setCustomName(String customName) {
            this.customName = customName;
            return this;
        }
        public String getCustomName() {
            return this.customName;
        }

        public ImportJobDataRequestBodyAddress setDistrictCode(String districtCode) {
            this.districtCode = districtCode;
            return this;
        }
        public String getDistrictCode() {
            return this.districtCode;
        }

        public ImportJobDataRequestBodyAddress setLatitude(String latitude) {
            this.latitude = latitude;
            return this;
        }
        public String getLatitude() {
            return this.latitude;
        }

        public ImportJobDataRequestBodyAddress setLongitude(String longitude) {
            this.longitude = longitude;
            return this;
        }
        public String getLongitude() {
            return this.longitude;
        }

        public ImportJobDataRequestBodyAddress setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ImportJobDataRequestBodyAddress setProvinceCode(String provinceCode) {
            this.provinceCode = provinceCode;
            return this;
        }
        public String getProvinceCode() {
            return this.provinceCode;
        }

    }

    public static class ImportJobDataRequestBodyFullTimeExt extends TeaModel {
        @NameInMap("salaryMonth")
        public Integer salaryMonth;

        public static ImportJobDataRequestBodyFullTimeExt build(java.util.Map<String, ?> map) throws Exception {
            ImportJobDataRequestBodyFullTimeExt self = new ImportJobDataRequestBodyFullTimeExt();
            return TeaModel.build(map, self);
        }

        public ImportJobDataRequestBodyFullTimeExt setSalaryMonth(Integer salaryMonth) {
            this.salaryMonth = salaryMonth;
            return this;
        }
        public Integer getSalaryMonth() {
            return this.salaryMonth;
        }

    }

    public static class ImportJobDataRequestBody extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("address")
        public ImportJobDataRequestBodyAddress address;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("category")
        public String category;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("experience")
        public String experience;

        @NameInMap("fullTimeExt")
        public ImportJobDataRequestBodyFullTimeExt fullTimeExt;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("jobNature")
        public String jobNature;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("maxSalary")
        public Long maxSalary;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("minSalary")
        public Long minSalary;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("requiredEdu")
        public Integer requiredEdu;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userId")
        public String userId;

        public static ImportJobDataRequestBody build(java.util.Map<String, ?> map) throws Exception {
            ImportJobDataRequestBody self = new ImportJobDataRequestBody();
            return TeaModel.build(map, self);
        }

        public ImportJobDataRequestBody setAddress(ImportJobDataRequestBodyAddress address) {
            this.address = address;
            return this;
        }
        public ImportJobDataRequestBodyAddress getAddress() {
            return this.address;
        }

        public ImportJobDataRequestBody setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public ImportJobDataRequestBody setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ImportJobDataRequestBody setExperience(String experience) {
            this.experience = experience;
            return this;
        }
        public String getExperience() {
            return this.experience;
        }

        public ImportJobDataRequestBody setFullTimeExt(ImportJobDataRequestBodyFullTimeExt fullTimeExt) {
            this.fullTimeExt = fullTimeExt;
            return this;
        }
        public ImportJobDataRequestBodyFullTimeExt getFullTimeExt() {
            return this.fullTimeExt;
        }

        public ImportJobDataRequestBody setJobNature(String jobNature) {
            this.jobNature = jobNature;
            return this;
        }
        public String getJobNature() {
            return this.jobNature;
        }

        public ImportJobDataRequestBody setMaxSalary(Long maxSalary) {
            this.maxSalary = maxSalary;
            return this;
        }
        public Long getMaxSalary() {
            return this.maxSalary;
        }

        public ImportJobDataRequestBody setMinSalary(Long minSalary) {
            this.minSalary = minSalary;
            return this;
        }
        public Long getMinSalary() {
            return this.minSalary;
        }

        public ImportJobDataRequestBody setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ImportJobDataRequestBody setRequiredEdu(Integer requiredEdu) {
            this.requiredEdu = requiredEdu;
            return this;
        }
        public Integer getRequiredEdu() {
            return this.requiredEdu;
        }

        public ImportJobDataRequestBody setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
