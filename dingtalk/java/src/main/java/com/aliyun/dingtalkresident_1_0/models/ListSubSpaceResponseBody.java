// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class ListSubSpaceResponseBody extends TeaModel {
    /**
     * <p>result</p>
     */
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

        /**
         * <p>房屋状态：0空置/1未领/2入住/3空关/4装修</p>
         */
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

        /**
         * <p>空间类型为楼时，1高层/2低层/3别墅/4其他，空间类型为房屋是，1住宅/2公寓/3排屋/4洋房/5叠墅/6别墅/7商铺/8办公用房/9经营用房/10其他</p>
         */
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
