// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class ListSubSpaceResponseBody extends TeaModel {
    // result
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
        @NameInMap("referId")
        public Long referId;

        @NameInMap("spaceName")
        public String spaceName;

        @NameInMap("tagCode")
        public String tagCode;

        // 空间类型为楼时，1高层/2低层/3别墅/4其他，空间类型为房屋是，1住宅/2公寓/3排屋/4洋房/5叠墅/6别墅/7商铺/8办公用房/9经营用房/10其他
        @NameInMap("type")
        public String type;

        @NameInMap("floor")
        public String floor;

        @NameInMap("isVirtual")
        public Integer isVirtual;

        @NameInMap("billingArea")
        public Float billingArea;

        @NameInMap("buildingArea")
        public Float buildingArea;

        // 房屋状态：0空置/1未领/2入住/3空关/4装修
        @NameInMap("houseState")
        public Integer houseState;

        @NameInMap("parentReferId")
        public Long parentReferId;

        public static ListSubSpaceResponseBodySpaceList build(java.util.Map<String, ?> map) throws Exception {
            ListSubSpaceResponseBodySpaceList self = new ListSubSpaceResponseBodySpaceList();
            return TeaModel.build(map, self);
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

        public ListSubSpaceResponseBodySpaceList setFloor(String floor) {
            this.floor = floor;
            return this;
        }
        public String getFloor() {
            return this.floor;
        }

        public ListSubSpaceResponseBodySpaceList setIsVirtual(Integer isVirtual) {
            this.isVirtual = isVirtual;
            return this;
        }
        public Integer getIsVirtual() {
            return this.isVirtual;
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

        public ListSubSpaceResponseBodySpaceList setHouseState(Integer houseState) {
            this.houseState = houseState;
            return this;
        }
        public Integer getHouseState() {
            return this.houseState;
        }

        public ListSubSpaceResponseBodySpaceList setParentReferId(Long parentReferId) {
            this.parentReferId = parentReferId;
            return this;
        }
        public Long getParentReferId() {
            return this.parentReferId;
        }

    }

}
