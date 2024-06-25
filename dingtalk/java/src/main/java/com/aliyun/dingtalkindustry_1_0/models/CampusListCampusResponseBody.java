// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusListCampusResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<CampusListCampusResponseBodyResult> result;

    public static CampusListCampusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CampusListCampusResponseBody self = new CampusListCampusResponseBody();
        return TeaModel.build(map, self);
    }

    public CampusListCampusResponseBody setResult(java.util.List<CampusListCampusResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<CampusListCampusResponseBodyResult> getResult() {
        return this.result;
    }

    public static class CampusListCampusResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>杭州市余杭区</p>
         */
        @NameInMap("address")
        public String address;

        /**
         * <strong>example:</strong>
         * <p>121212.1</p>
         */
        @NameInMap("area")
        public Double area;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("belongProjectGroupId")
        public Long belongProjectGroupId;

        /**
         * <strong>example:</strong>
         * <p>ding121212</p>
         */
        @NameInMap("campusCorpId")
        public String campusCorpId;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("campusDeptId")
        public Long campusDeptId;

        /**
         * <strong>example:</strong>
         * <p>测试园区</p>
         */
        @NameInMap("campusName")
        public String campusName;

        /**
         * <strong>example:</strong>
         * <p>30450</p>
         */
        @NameInMap("cityId")
        public Integer cityId;

        /**
         * <strong>example:</strong>
         * <p>中国</p>
         */
        @NameInMap("country")
        public String country;

        /**
         * <strong>example:</strong>
         * <p>304501</p>
         */
        @NameInMap("countyId")
        public Integer countyId;

        /**
         * <strong>example:</strong>
         * <p>测试</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <strong>example:</strong>
         * <p>扩展</p>
         */
        @NameInMap("extend")
        public String extend;

        /**
         * <strong>example:</strong>
         * <p>120.1321,28.1213</p>
         */
        @NameInMap("location")
        public String location;

        /**
         * <strong>example:</strong>
         * <p>1655704317794</p>
         */
        @NameInMap("orderEndTime")
        public Long orderEndTime;

        /**
         * <strong>example:</strong>
         * <p>规格1</p>
         */
        @NameInMap("orderInfo")
        public String orderInfo;

        /**
         * <strong>example:</strong>
         * <p>1655704317794</p>
         */
        @NameInMap("orderStartTime")
        public Long orderStartTime;

        /**
         * <strong>example:</strong>
         * <p>304</p>
         */
        @NameInMap("provId")
        public Integer provId;

        /**
         * <strong>example:</strong>
         * <p>13914773133</p>
         */
        @NameInMap("telephone")
        public String telephone;

        public static CampusListCampusResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CampusListCampusResponseBodyResult self = new CampusListCampusResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CampusListCampusResponseBodyResult setAddress(String address) {
            this.address = address;
            return this;
        }
        public String getAddress() {
            return this.address;
        }

        public CampusListCampusResponseBodyResult setArea(Double area) {
            this.area = area;
            return this;
        }
        public Double getArea() {
            return this.area;
        }

        public CampusListCampusResponseBodyResult setBelongProjectGroupId(Long belongProjectGroupId) {
            this.belongProjectGroupId = belongProjectGroupId;
            return this;
        }
        public Long getBelongProjectGroupId() {
            return this.belongProjectGroupId;
        }

        public CampusListCampusResponseBodyResult setCampusCorpId(String campusCorpId) {
            this.campusCorpId = campusCorpId;
            return this;
        }
        public String getCampusCorpId() {
            return this.campusCorpId;
        }

        public CampusListCampusResponseBodyResult setCampusDeptId(Long campusDeptId) {
            this.campusDeptId = campusDeptId;
            return this;
        }
        public Long getCampusDeptId() {
            return this.campusDeptId;
        }

        public CampusListCampusResponseBodyResult setCampusName(String campusName) {
            this.campusName = campusName;
            return this;
        }
        public String getCampusName() {
            return this.campusName;
        }

        public CampusListCampusResponseBodyResult setCityId(Integer cityId) {
            this.cityId = cityId;
            return this;
        }
        public Integer getCityId() {
            return this.cityId;
        }

        public CampusListCampusResponseBodyResult setCountry(String country) {
            this.country = country;
            return this;
        }
        public String getCountry() {
            return this.country;
        }

        public CampusListCampusResponseBodyResult setCountyId(Integer countyId) {
            this.countyId = countyId;
            return this;
        }
        public Integer getCountyId() {
            return this.countyId;
        }

        public CampusListCampusResponseBodyResult setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public CampusListCampusResponseBodyResult setExtend(String extend) {
            this.extend = extend;
            return this;
        }
        public String getExtend() {
            return this.extend;
        }

        public CampusListCampusResponseBodyResult setLocation(String location) {
            this.location = location;
            return this;
        }
        public String getLocation() {
            return this.location;
        }

        public CampusListCampusResponseBodyResult setOrderEndTime(Long orderEndTime) {
            this.orderEndTime = orderEndTime;
            return this;
        }
        public Long getOrderEndTime() {
            return this.orderEndTime;
        }

        public CampusListCampusResponseBodyResult setOrderInfo(String orderInfo) {
            this.orderInfo = orderInfo;
            return this;
        }
        public String getOrderInfo() {
            return this.orderInfo;
        }

        public CampusListCampusResponseBodyResult setOrderStartTime(Long orderStartTime) {
            this.orderStartTime = orderStartTime;
            return this;
        }
        public Long getOrderStartTime() {
            return this.orderStartTime;
        }

        public CampusListCampusResponseBodyResult setProvId(Integer provId) {
            this.provId = provId;
            return this;
        }
        public Integer getProvId() {
            return this.provId;
        }

        public CampusListCampusResponseBodyResult setTelephone(String telephone) {
            this.telephone = telephone;
            return this;
        }
        public String getTelephone() {
            return this.telephone;
        }

    }

}
