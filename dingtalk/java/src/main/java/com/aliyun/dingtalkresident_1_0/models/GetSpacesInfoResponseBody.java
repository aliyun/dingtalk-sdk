// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetSpacesInfoResponseBody extends TeaModel {
    @NameInMap("spaceList")
    public java.util.List<GetSpacesInfoResponseBodySpaceList> spaceList;

    public static GetSpacesInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSpacesInfoResponseBody self = new GetSpacesInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSpacesInfoResponseBody setSpaceList(java.util.List<GetSpacesInfoResponseBodySpaceList> spaceList) {
        this.spaceList = spaceList;
        return this;
    }
    public java.util.List<GetSpacesInfoResponseBodySpaceList> getSpaceList() {
        return this.spaceList;
    }

    public static class GetSpacesInfoResponseBodySpaceList extends TeaModel {
        @NameInMap("billingArea")
        public Float billingArea;

        @NameInMap("buildingArea")
        public Float buildingArea;

        @NameInMap("floor")
        public String floor;

        @NameInMap("houseState")
        public Integer houseState;

        @NameInMap("isVirtual")
        public Integer isVirtual;

        @NameInMap("parentReferId")
        public Long parentReferId;

        @NameInMap("referId")
        public Long referId;

        @NameInMap("spaceName")
        public String spaceName;

        @NameInMap("tagCode")
        public String tagCode;

        @NameInMap("type")
        public String type;

        public static GetSpacesInfoResponseBodySpaceList build(java.util.Map<String, ?> map) throws Exception {
            GetSpacesInfoResponseBodySpaceList self = new GetSpacesInfoResponseBodySpaceList();
            return TeaModel.build(map, self);
        }

        public GetSpacesInfoResponseBodySpaceList setBillingArea(Float billingArea) {
            this.billingArea = billingArea;
            return this;
        }
        public Float getBillingArea() {
            return this.billingArea;
        }

        public GetSpacesInfoResponseBodySpaceList setBuildingArea(Float buildingArea) {
            this.buildingArea = buildingArea;
            return this;
        }
        public Float getBuildingArea() {
            return this.buildingArea;
        }

        public GetSpacesInfoResponseBodySpaceList setFloor(String floor) {
            this.floor = floor;
            return this;
        }
        public String getFloor() {
            return this.floor;
        }

        public GetSpacesInfoResponseBodySpaceList setHouseState(Integer houseState) {
            this.houseState = houseState;
            return this;
        }
        public Integer getHouseState() {
            return this.houseState;
        }

        public GetSpacesInfoResponseBodySpaceList setIsVirtual(Integer isVirtual) {
            this.isVirtual = isVirtual;
            return this;
        }
        public Integer getIsVirtual() {
            return this.isVirtual;
        }

        public GetSpacesInfoResponseBodySpaceList setParentReferId(Long parentReferId) {
            this.parentReferId = parentReferId;
            return this;
        }
        public Long getParentReferId() {
            return this.parentReferId;
        }

        public GetSpacesInfoResponseBodySpaceList setReferId(Long referId) {
            this.referId = referId;
            return this;
        }
        public Long getReferId() {
            return this.referId;
        }

        public GetSpacesInfoResponseBodySpaceList setSpaceName(String spaceName) {
            this.spaceName = spaceName;
            return this;
        }
        public String getSpaceName() {
            return this.spaceName;
        }

        public GetSpacesInfoResponseBodySpaceList setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

        public GetSpacesInfoResponseBodySpaceList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
