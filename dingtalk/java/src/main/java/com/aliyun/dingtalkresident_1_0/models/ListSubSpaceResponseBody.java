// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class ListSubSpaceResponseBody extends TeaModel {
    @NameInMap("spaceList")
    public java.util.List<ListSubSpaceResponseBodySpaceList> spaceList;

    public static ListSubSpaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListSubSpaceResponseBody self = new ListSubSpaceResponseBody();
        return TeaModel.build(map, self);
    }

    public ListSubSpaceResponseBody setSpaceList(java.util.List<ListSubSpaceResponseBodySpaceList> spaceList) {
        this.spaceList = spaceList;
        return this;
    }
    public java.util.List<ListSubSpaceResponseBodySpaceList> getSpaceList() {
        return this.spaceList;
    }

    public static class ListSubSpaceResponseBodySpaceList extends TeaModel {
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

        public static ListSubSpaceResponseBodySpaceList build(java.util.Map<String, ?> map) throws Exception {
            ListSubSpaceResponseBodySpaceList self = new ListSubSpaceResponseBodySpaceList();
            return TeaModel.build(map, self);
        }

        public ListSubSpaceResponseBodySpaceList setBillingArea(Float billingArea) {
            this.billingArea = billingArea;
            return this;
        }
        public Float getBillingArea() {
            return this.billingArea;
        }

        public ListSubSpaceResponseBodySpaceList setBuildingArea(Float buildingArea) {
            this.buildingArea = buildingArea;
            return this;
        }
        public Float getBuildingArea() {
            return this.buildingArea;
        }

        public ListSubSpaceResponseBodySpaceList setFloor(String floor) {
            this.floor = floor;
            return this;
        }
        public String getFloor() {
            return this.floor;
        }

        public ListSubSpaceResponseBodySpaceList setHouseState(Integer houseState) {
            this.houseState = houseState;
            return this;
        }
        public Integer getHouseState() {
            return this.houseState;
        }

        public ListSubSpaceResponseBodySpaceList setIsVirtual(Integer isVirtual) {
            this.isVirtual = isVirtual;
            return this;
        }
        public Integer getIsVirtual() {
            return this.isVirtual;
        }

        public ListSubSpaceResponseBodySpaceList setParentReferId(Long parentReferId) {
            this.parentReferId = parentReferId;
            return this;
        }
        public Long getParentReferId() {
            return this.parentReferId;
        }

        public ListSubSpaceResponseBodySpaceList setReferId(Long referId) {
            this.referId = referId;
            return this;
        }
        public Long getReferId() {
            return this.referId;
        }

        public ListSubSpaceResponseBodySpaceList setSpaceName(String spaceName) {
            this.spaceName = spaceName;
            return this;
        }
        public String getSpaceName() {
            return this.spaceName;
        }

        public ListSubSpaceResponseBodySpaceList setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

        public ListSubSpaceResponseBodySpaceList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
