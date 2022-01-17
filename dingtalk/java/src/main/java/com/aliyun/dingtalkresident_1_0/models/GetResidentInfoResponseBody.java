// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetResidentInfoResponseBody extends TeaModel {
    // 小区地址
    @NameInMap("address")
    public String address;

    // 全员群opencid
    @NameInMap("allUserGroupOpenConversationId")
    public String allUserGroupOpenConversationId;

    // 全员群群主 userid
    @NameInMap("allUserGroupOwnerUserId")
    public String allUserGroupOwnerUserId;

    @NameInMap("buildingArea")
    public Float buildingArea;

    // 小区归属的市的id
    @NameInMap("cityId")
    public Integer cityId;

    // 通信录模式:0标准/1自定义
    @NameInMap("contactMode")
    public Integer contactMode;

    // 小区归属的区/县的id
    @NameInMap("countyId")
    public Integer countyId;

    // 交付时间
    @NameInMap("deliveryTime")
    public Long deliveryTime;

    // 经纬度，格式：经度,纬度
    @NameInMap("location")
    public String location;

    // 小区名称
    @NameInMap("name")
    public String name;

    @NameInMap("projectManager")
    public GetResidentInfoResponseBodyProjectManager projectManager;

    // 物业部门群cid
    @NameInMap("propertyDeptGroupOpenConversationId")
    public String propertyDeptGroupOpenConversationId;

    // 物业部门群主userid
    @NameInMap("propertyDeptGroupOwnerUserId")
    public String propertyDeptGroupOwnerUserId;

    // 小区归属的省的id
    @NameInMap("provId")
    public Long provId;

    // 物业管理范围-东
    @NameInMap("scopeEast")
    public String scopeEast;

    // 物业管理范围-北
    @NameInMap("scopeNorth")
    public String scopeNorth;

    // 物业管理范围-南
    @NameInMap("scopeSouth")
    public String scopeSouth;

    // 物业管理范围-西
    @NameInMap("scopeWest")
    public String scopeWest;

    // 物业电话
    @NameInMap("telephone")
    public String telephone;

    // 小区归属的街道/镇的id
    @NameInMap("townId")
    public Integer townId;

    // 1纯住宅；2:商住混合；3:办公；4:办公商业混合；5:商业；6:公共场所；7:其他
    @NameInMap("type")
    public Integer type;

    public static GetResidentInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetResidentInfoResponseBody self = new GetResidentInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetResidentInfoResponseBody setAddress(String address) {
        this.address = address;
        return this;
    }
    public String getAddress() {
        return this.address;
    }

    public GetResidentInfoResponseBody setAllUserGroupOpenConversationId(String allUserGroupOpenConversationId) {
        this.allUserGroupOpenConversationId = allUserGroupOpenConversationId;
        return this;
    }
    public String getAllUserGroupOpenConversationId() {
        return this.allUserGroupOpenConversationId;
    }

    public GetResidentInfoResponseBody setAllUserGroupOwnerUserId(String allUserGroupOwnerUserId) {
        this.allUserGroupOwnerUserId = allUserGroupOwnerUserId;
        return this;
    }
    public String getAllUserGroupOwnerUserId() {
        return this.allUserGroupOwnerUserId;
    }

    public GetResidentInfoResponseBody setBuildingArea(Float buildingArea) {
        this.buildingArea = buildingArea;
        return this;
    }
    public Float getBuildingArea() {
        return this.buildingArea;
    }

    public GetResidentInfoResponseBody setCityId(Integer cityId) {
        this.cityId = cityId;
        return this;
    }
    public Integer getCityId() {
        return this.cityId;
    }

    public GetResidentInfoResponseBody setContactMode(Integer contactMode) {
        this.contactMode = contactMode;
        return this;
    }
    public Integer getContactMode() {
        return this.contactMode;
    }

    public GetResidentInfoResponseBody setCountyId(Integer countyId) {
        this.countyId = countyId;
        return this;
    }
    public Integer getCountyId() {
        return this.countyId;
    }

    public GetResidentInfoResponseBody setDeliveryTime(Long deliveryTime) {
        this.deliveryTime = deliveryTime;
        return this;
    }
    public Long getDeliveryTime() {
        return this.deliveryTime;
    }

    public GetResidentInfoResponseBody setLocation(String location) {
        this.location = location;
        return this;
    }
    public String getLocation() {
        return this.location;
    }

    public GetResidentInfoResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetResidentInfoResponseBody setProjectManager(GetResidentInfoResponseBodyProjectManager projectManager) {
        this.projectManager = projectManager;
        return this;
    }
    public GetResidentInfoResponseBodyProjectManager getProjectManager() {
        return this.projectManager;
    }

    public GetResidentInfoResponseBody setPropertyDeptGroupOpenConversationId(String propertyDeptGroupOpenConversationId) {
        this.propertyDeptGroupOpenConversationId = propertyDeptGroupOpenConversationId;
        return this;
    }
    public String getPropertyDeptGroupOpenConversationId() {
        return this.propertyDeptGroupOpenConversationId;
    }

    public GetResidentInfoResponseBody setPropertyDeptGroupOwnerUserId(String propertyDeptGroupOwnerUserId) {
        this.propertyDeptGroupOwnerUserId = propertyDeptGroupOwnerUserId;
        return this;
    }
    public String getPropertyDeptGroupOwnerUserId() {
        return this.propertyDeptGroupOwnerUserId;
    }

    public GetResidentInfoResponseBody setProvId(Long provId) {
        this.provId = provId;
        return this;
    }
    public Long getProvId() {
        return this.provId;
    }

    public GetResidentInfoResponseBody setScopeEast(String scopeEast) {
        this.scopeEast = scopeEast;
        return this;
    }
    public String getScopeEast() {
        return this.scopeEast;
    }

    public GetResidentInfoResponseBody setScopeNorth(String scopeNorth) {
        this.scopeNorth = scopeNorth;
        return this;
    }
    public String getScopeNorth() {
        return this.scopeNorth;
    }

    public GetResidentInfoResponseBody setScopeSouth(String scopeSouth) {
        this.scopeSouth = scopeSouth;
        return this;
    }
    public String getScopeSouth() {
        return this.scopeSouth;
    }

    public GetResidentInfoResponseBody setScopeWest(String scopeWest) {
        this.scopeWest = scopeWest;
        return this;
    }
    public String getScopeWest() {
        return this.scopeWest;
    }

    public GetResidentInfoResponseBody setTelephone(String telephone) {
        this.telephone = telephone;
        return this;
    }
    public String getTelephone() {
        return this.telephone;
    }

    public GetResidentInfoResponseBody setTownId(Integer townId) {
        this.townId = townId;
        return this;
    }
    public Integer getTownId() {
        return this.townId;
    }

    public GetResidentInfoResponseBody setType(Integer type) {
        this.type = type;
        return this;
    }
    public Integer getType() {
        return this.type;
    }

    public static class GetResidentInfoResponseBodyProjectManager extends TeaModel {
        // 头像
        @NameInMap("avatar")
        public String avatar;

        // 人员唯一标识
        @NameInMap("userId")
        public String userId;

        // 姓名
        @NameInMap("userName")
        public String userName;

        public static GetResidentInfoResponseBodyProjectManager build(java.util.Map<String, ?> map) throws Exception {
            GetResidentInfoResponseBodyProjectManager self = new GetResidentInfoResponseBodyProjectManager();
            return TeaModel.build(map, self);
        }

        public GetResidentInfoResponseBodyProjectManager setAvatar(String avatar) {
            this.avatar = avatar;
            return this;
        }
        public String getAvatar() {
            return this.avatar;
        }

        public GetResidentInfoResponseBodyProjectManager setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public GetResidentInfoResponseBodyProjectManager setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

}
