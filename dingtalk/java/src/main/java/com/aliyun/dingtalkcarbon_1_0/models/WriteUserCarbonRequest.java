// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteUserCarbonRequest extends TeaModel {
    @NameInMap("userDetailsList")
    public java.util.List<WriteUserCarbonRequestUserDetailsList> userDetailsList;

    public static WriteUserCarbonRequest build(java.util.Map<String, ?> map) throws Exception {
        WriteUserCarbonRequest self = new WriteUserCarbonRequest();
        return TeaModel.build(map, self);
    }

    public WriteUserCarbonRequest setUserDetailsList(java.util.List<WriteUserCarbonRequestUserDetailsList> userDetailsList) {
        this.userDetailsList = userDetailsList;
        return this;
    }
    public java.util.List<WriteUserCarbonRequestUserDetailsList> getUserDetailsList() {
        return this.userDetailsList;
    }

    public static class WriteUserCarbonRequestUserDetailsList extends TeaModel {
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

        public static WriteUserCarbonRequestUserDetailsList build(java.util.Map<String, ?> map) throws Exception {
            WriteUserCarbonRequestUserDetailsList self = new WriteUserCarbonRequestUserDetailsList();
            return TeaModel.build(map, self);
        }

        public WriteUserCarbonRequestUserDetailsList setActionEndTime(String actionEndTime) {
            this.actionEndTime = actionEndTime;
            return this;
        }
        public String getActionEndTime() {
            return this.actionEndTime;
        }

        public WriteUserCarbonRequestUserDetailsList setActionId(String actionId) {
            this.actionId = actionId;
            return this;
        }
        public String getActionId() {
            return this.actionId;
        }

        public WriteUserCarbonRequestUserDetailsList setActionStartTime(String actionStartTime) {
            this.actionStartTime = actionStartTime;
            return this;
        }
        public String getActionStartTime() {
            return this.actionStartTime;
        }

        public WriteUserCarbonRequestUserDetailsList setActionType(String actionType) {
            this.actionType = actionType;
            return this;
        }
        public String getActionType() {
            return this.actionType;
        }

        public WriteUserCarbonRequestUserDetailsList setCarbonAmount(String carbonAmount) {
            this.carbonAmount = carbonAmount;
            return this;
        }
        public String getCarbonAmount() {
            return this.carbonAmount;
        }

        public WriteUserCarbonRequestUserDetailsList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public WriteUserCarbonRequestUserDetailsList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public WriteUserCarbonRequestUserDetailsList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public WriteUserCarbonRequestUserDetailsList setVersion(Integer version) {
            this.version = version;
            return this;
        }
        public Integer getVersion() {
            return this.version;
        }

    }

}
