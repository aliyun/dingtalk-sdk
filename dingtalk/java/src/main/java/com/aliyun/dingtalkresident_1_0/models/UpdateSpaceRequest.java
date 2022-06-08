// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateSpaceRequest extends TeaModel {
    // 修改后空间信息
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
        // 计费面积
        @NameInMap("billingArea")
        public Float billingArea;

        // 建筑面积
        @NameInMap("buildingArea")
        public Float buildingArea;

        // 楼栋类型
        @NameInMap("buildingType")
        public Long buildingType;

        // 修改的空间的唯一标识
        @NameInMap("deptId")
        public Long deptId;

        // 房屋所在楼层，当tagCode为House时选填
        @NameInMap("floor")
        public String floor;

        // 房屋状态，tagcode为house时选填，0空置/1未领/2入住/3空关/4装修
        @NameInMap("houseState")
        public Long houseState;

        // 房屋类型，当tagcode为House时必填
        @NameInMap("houseType")
        public Long houseType;

        // 修改后名称
        @NameInMap("name")
        public String name;

        @NameInMap("parentDeptId")
        public Long parentDeptId;

        // 空间类型
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
