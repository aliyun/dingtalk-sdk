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
        /**
         * <strong>example:</strong>
         * <p>2021-11-26 10:09:37</p>
         */
        @NameInMap("actionEndTime")
        public String actionEndTime;

        /**
         * <strong>example:</strong>
         * <p>12320211126</p>
         */
        @NameInMap("actionId")
        public String actionId;

        /**
         * <strong>example:</strong>
         * <p>2021-11-26 10:09:37</p>
         */
        @NameInMap("actionStartTime")
        public String actionStartTime;

        /**
         * <strong>example:</strong>
         * <p>VIDEO</p>
         */
        @NameInMap("actionType")
        public String actionType;

        /**
         * <strong>example:</strong>
         * <p>3.21</p>
         */
        @NameInMap("carbonAmount")
        public String carbonAmount;

        /**
         * <strong>example:</strong>
         * <p>ding12344</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>111</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
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
