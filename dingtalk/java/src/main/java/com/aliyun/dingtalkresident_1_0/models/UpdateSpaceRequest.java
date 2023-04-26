// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateSpaceRequest extends TeaModel {
    @NameInMap("spaceInfoVOList")
    public java.util.List<UpdateSpaceRequestSpaceInfoVOList> spaceInfoVOList;

    public static UpdateSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateSpaceRequest self = new UpdateSpaceRequest();
        return TeaModel.build(map, self);
    }

    public UpdateSpaceRequest setSpaceInfoVOList(java.util.List<UpdateSpaceRequestSpaceInfoVOList> spaceInfoVOList) {
        this.spaceInfoVOList = spaceInfoVOList;
        return this;
    }
    public java.util.List<UpdateSpaceRequestSpaceInfoVOList> getSpaceInfoVOList() {
        return this.spaceInfoVOList;
    }

    public static class UpdateSpaceRequestSpaceInfoVOList extends TeaModel {
        @NameInMap("billingArea")
        public Float billingArea;

        @NameInMap("buildingArea")
        public Float buildingArea;

        @NameInMap("buildingType")
        public Long buildingType;

        @NameInMap("deptId")
        public Long deptId;

        @NameInMap("floor")
        public String floor;

        @NameInMap("houseState")
        public Long houseState;

        @NameInMap("houseType")
        public Long houseType;

        @NameInMap("name")
        public String name;

        @NameInMap("parentDeptId")
        public Long parentDeptId;

        @NameInMap("tagCode")
        public String tagCode;

        public static UpdateSpaceRequestSpaceInfoVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateSpaceRequestSpaceInfoVOList self = new UpdateSpaceRequestSpaceInfoVOList();
            return TeaModel.build(map, self);
        }

        public UpdateSpaceRequestSpaceInfoVOList setBillingArea(Float billingArea) {
            this.billingArea = billingArea;
            return this;
        }
        public Float getBillingArea() {
            return this.billingArea;
        }

        public UpdateSpaceRequestSpaceInfoVOList setBuildingArea(Float buildingArea) {
            this.buildingArea = buildingArea;
            return this;
        }
        public Float getBuildingArea() {
            return this.buildingArea;
        }

        public UpdateSpaceRequestSpaceInfoVOList setBuildingType(Long buildingType) {
            this.buildingType = buildingType;
            return this;
        }
        public Long getBuildingType() {
            return this.buildingType;
        }

        public UpdateSpaceRequestSpaceInfoVOList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public UpdateSpaceRequestSpaceInfoVOList setFloor(String floor) {
            this.floor = floor;
            return this;
        }
        public String getFloor() {
            return this.floor;
        }

        public UpdateSpaceRequestSpaceInfoVOList setHouseState(Long houseState) {
            this.houseState = houseState;
            return this;
        }
        public Long getHouseState() {
            return this.houseState;
        }

        public UpdateSpaceRequestSpaceInfoVOList setHouseType(Long houseType) {
            this.houseType = houseType;
            return this;
        }
        public Long getHouseType() {
            return this.houseType;
        }

        public UpdateSpaceRequestSpaceInfoVOList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public UpdateSpaceRequestSpaceInfoVOList setParentDeptId(Long parentDeptId) {
            this.parentDeptId = parentDeptId;
            return this;
        }
        public Long getParentDeptId() {
            return this.parentDeptId;
        }

        public UpdateSpaceRequestSpaceInfoVOList setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

    }

}
