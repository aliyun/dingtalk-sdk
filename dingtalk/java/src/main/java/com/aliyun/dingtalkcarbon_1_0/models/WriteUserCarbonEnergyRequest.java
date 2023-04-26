// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteUserCarbonEnergyRequest extends TeaModel {
    @NameInMap("userDetailsList")
    public java.util.List<WriteUserCarbonEnergyRequestUserDetailsList> userDetailsList;

    public static WriteUserCarbonEnergyRequest build(java.util.Map<String, ?> map) throws Exception {
        WriteUserCarbonEnergyRequest self = new WriteUserCarbonEnergyRequest();
        return TeaModel.build(map, self);
    }

    public WriteUserCarbonEnergyRequest setUserDetailsList(java.util.List<WriteUserCarbonEnergyRequestUserDetailsList> userDetailsList) {
        this.userDetailsList = userDetailsList;
        return this;
    }
    public java.util.List<WriteUserCarbonEnergyRequestUserDetailsList> getUserDetailsList() {
        return this.userDetailsList;
    }

    public static class WriteUserCarbonEnergyRequestUserDetailsList extends TeaModel {
        @NameInMap("actionEndTime")
        public String actionEndTime;

        @NameInMap("actionId")
        public String actionId;

        @NameInMap("actionStartTime")
        public String actionStartTime;

        @NameInMap("actionType")
        public String actionType;

        @NameInMap("carbonAmount")
        public String carbonAmount;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("deptId")
        public Long deptId;

        @NameInMap("userId")
        public String userId;

        @NameInMap("version")
        public Integer version;

        public static WriteUserCarbonEnergyRequestUserDetailsList build(java.util.Map<String, ?> map) throws Exception {
            WriteUserCarbonEnergyRequestUserDetailsList self = new WriteUserCarbonEnergyRequestUserDetailsList();
            return TeaModel.build(map, self);
        }

        public WriteUserCarbonEnergyRequestUserDetailsList setActionEndTime(String actionEndTime) {
            this.actionEndTime = actionEndTime;
            return this;
        }
        public String getActionEndTime() {
            return this.actionEndTime;
        }

        public WriteUserCarbonEnergyRequestUserDetailsList setActionId(String actionId) {
            this.actionId = actionId;
            return this;
        }
        public String getActionId() {
            return this.actionId;
        }

        public WriteUserCarbonEnergyRequestUserDetailsList setActionStartTime(String actionStartTime) {
            this.actionStartTime = actionStartTime;
            return this;
        }
        public String getActionStartTime() {
            return this.actionStartTime;
        }

        public WriteUserCarbonEnergyRequestUserDetailsList setActionType(String actionType) {
            this.actionType = actionType;
            return this;
        }
        public String getActionType() {
            return this.actionType;
        }

        public WriteUserCarbonEnergyRequestUserDetailsList setCarbonAmount(String carbonAmount) {
            this.carbonAmount = carbonAmount;
            return this;
        }
        public String getCarbonAmount() {
            return this.carbonAmount;
        }

        public WriteUserCarbonEnergyRequestUserDetailsList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public WriteUserCarbonEnergyRequestUserDetailsList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public WriteUserCarbonEnergyRequestUserDetailsList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public WriteUserCarbonEnergyRequestUserDetailsList setVersion(Integer version) {
            this.version = version;
            return this;
        }
        public Integer getVersion() {
            return this.version;
        }

    }

}
