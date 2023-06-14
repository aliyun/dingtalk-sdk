// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkactivity_1_0.models;

import com.aliyun.tea.*;

public class CreateActivityRequest extends TeaModel {
    @NameInMap("detail")
    public CreateActivityRequestDetail detail;

    public static CreateActivityRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateActivityRequest self = new CreateActivityRequest();
        return TeaModel.build(map, self);
    }

    public CreateActivityRequest setDetail(CreateActivityRequestDetail detail) {
        this.detail = detail;
        return this;
    }
    public CreateActivityRequestDetail getDetail() {
        return this.detail;
    }

    public static class CreateActivityRequestDetailAddress extends TeaModel {
        @NameInMap("district")
        public String district;

        @NameInMap("lat")
        public String lat;

        @NameInMap("lng")
        public String lng;

        @NameInMap("name")
        public String name;

        public static CreateActivityRequestDetailAddress build(java.util.Map<String, ?> map) throws Exception {
            CreateActivityRequestDetailAddress self = new CreateActivityRequestDetailAddress();
            return TeaModel.build(map, self);
        }

        public CreateActivityRequestDetailAddress setDistrict(String district) {
            this.district = district;
            return this;
        }
        public String getDistrict() {
            return this.district;
        }

        public CreateActivityRequestDetailAddress setLat(String lat) {
            this.lat = lat;
            return this;
        }
        public String getLat() {
            return this.lat;
        }

        public CreateActivityRequestDetailAddress setLng(String lng) {
            this.lng = lng;
            return this;
        }
        public String getLng() {
            return this.lng;
        }

        public CreateActivityRequestDetailAddress setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class CreateActivityRequestDetail extends TeaModel {
        @NameInMap("address")
        public CreateActivityRequestDetailAddress address;

        @NameInMap("bannerMediaId")
        public String bannerMediaId;

        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("foreignId")
        public String foreignId;

        @NameInMap("industry")
        public String industry;

        @NameInMap("roleName")
        public String roleName;

        @NameInMap("source")
        public String source;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("title")
        public String title;

        @NameInMap("type")
        public Integer type;

        @NameInMap("url")
        public String url;

        public static CreateActivityRequestDetail build(java.util.Map<String, ?> map) throws Exception {
            CreateActivityRequestDetail self = new CreateActivityRequestDetail();
            return TeaModel.build(map, self);
        }

        public CreateActivityRequestDetail setAddress(CreateActivityRequestDetailAddress address) {
            this.address = address;
            return this;
        }
        public CreateActivityRequestDetailAddress getAddress() {
            return this.address;
        }

        public CreateActivityRequestDetail setBannerMediaId(String bannerMediaId) {
            this.bannerMediaId = bannerMediaId;
            return this;
        }
        public String getBannerMediaId() {
            return this.bannerMediaId;
        }

        public CreateActivityRequestDetail setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public CreateActivityRequestDetail setForeignId(String foreignId) {
            this.foreignId = foreignId;
            return this;
        }
        public String getForeignId() {
            return this.foreignId;
        }

        public CreateActivityRequestDetail setIndustry(String industry) {
            this.industry = industry;
            return this;
        }
        public String getIndustry() {
            return this.industry;
        }

        public CreateActivityRequestDetail setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

        public CreateActivityRequestDetail setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

        public CreateActivityRequestDetail setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public CreateActivityRequestDetail setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public CreateActivityRequestDetail setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

        public CreateActivityRequestDetail setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
