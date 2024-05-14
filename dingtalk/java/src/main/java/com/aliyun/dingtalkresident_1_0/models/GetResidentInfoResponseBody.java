// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetResidentInfoResponseBody extends TeaModel {
    @NameInMap("address")
    public String address;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("allUserGroupOpenConversationId")
    public String allUserGroupOpenConversationId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("allUserGroupOwnerUserId")
    public String allUserGroupOwnerUserId;

    @NameInMap("buildingArea")
    public Float buildingArea;

    @NameInMap("cityId")
    public Integer cityId;

    @NameInMap("contactMode")
    public Integer contactMode;

    @NameInMap("countyId")
    public Integer countyId;

    @NameInMap("deliveryTime")
    public Long deliveryTime;

    @NameInMap("location")
    public String location;

    @NameInMap("name")
    public String name;

    @NameInMap("projectManager")
    public GetResidentInfoResponseBodyProjectManager projectManager;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("propertyDeptGroupOpenConversationId")
    public String propertyDeptGroupOpenConversationId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("propertyDeptGroupOwnerUserId")
    public String propertyDeptGroupOwnerUserId;

    @NameInMap("provId")
    public Long provId;

    @NameInMap("scopeEast")
    public String scopeEast;

    @NameInMap("scopeNorth")
    public String scopeNorth;

    @NameInMap("scopeSouth")
    public String scopeSouth;

    @NameInMap("scopeWest")
    public String scopeWest;

    @NameInMap("telephone")
    public String telephone;

    @NameInMap("townId")
    public Integer townId;

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
        @NameInMap("avatar")
        public String avatar;

        @NameInMap("userId")
        public String userId;

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
