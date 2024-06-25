// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateSpaceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>A栋</p>
     */
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
        /**
         * <strong>example:</strong>
         * <p>123.4</p>
         */
        @NameInMap("billingArea")
        public Float billingArea;

        /**
         * <strong>example:</strong>
         * <p>123.4</p>
         */
        @NameInMap("buildingArea")
        public Float buildingArea;

        /**
         * <strong>example:</strong>
         * <p>当tagcode为Building的时候必填</p>
         */
        @NameInMap("buildingType")
        public Long buildingType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>10005</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        /**
         * <strong>example:</strong>
         * <p>12</p>
         */
        @NameInMap("floor")
        public String floor;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("houseState")
        public Long houseState;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("houseType")
        public Long houseType;

        /**
         * <strong>example:</strong>
         * <p>二单元</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("parentDeptId")
        public Long parentDeptId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>空间类型标签code，House/Unit/Building/Partition</p>
         */
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
