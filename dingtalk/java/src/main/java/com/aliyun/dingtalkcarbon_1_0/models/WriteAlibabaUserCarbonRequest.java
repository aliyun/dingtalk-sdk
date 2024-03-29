// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteAlibabaUserCarbonRequest extends TeaModel {
    @NameInMap("userDetailsList")
    public java.util.List<WriteAlibabaUserCarbonRequestUserDetailsList> userDetailsList;

    public static WriteAlibabaUserCarbonRequest build(java.util.Map<String, ?> map) throws Exception {
        WriteAlibabaUserCarbonRequest self = new WriteAlibabaUserCarbonRequest();
        return TeaModel.build(map, self);
    }

    public WriteAlibabaUserCarbonRequest setUserDetailsList(java.util.List<WriteAlibabaUserCarbonRequestUserDetailsList> userDetailsList) {
        this.userDetailsList = userDetailsList;
        return this;
    }
    public java.util.List<WriteAlibabaUserCarbonRequestUserDetailsList> getUserDetailsList() {
        return this.userDetailsList;
    }

    public static class WriteAlibabaUserCarbonRequestUserDetailsList extends TeaModel {
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

        public static WriteAlibabaUserCarbonRequestUserDetailsList build(java.util.Map<String, ?> map) throws Exception {
            WriteAlibabaUserCarbonRequestUserDetailsList self = new WriteAlibabaUserCarbonRequestUserDetailsList();
            return TeaModel.build(map, self);
        }

        public WriteAlibabaUserCarbonRequestUserDetailsList setActionEndTime(String actionEndTime) {
            this.actionEndTime = actionEndTime;
            return this;
        }
        public String getActionEndTime() {
            return this.actionEndTime;
        }

        public WriteAlibabaUserCarbonRequestUserDetailsList setActionId(String actionId) {
            this.actionId = actionId;
            return this;
        }
        public String getActionId() {
            return this.actionId;
        }

        public WriteAlibabaUserCarbonRequestUserDetailsList setActionStartTime(String actionStartTime) {
            this.actionStartTime = actionStartTime;
            return this;
        }
        public String getActionStartTime() {
            return this.actionStartTime;
        }

        public WriteAlibabaUserCarbonRequestUserDetailsList setActionType(String actionType) {
            this.actionType = actionType;
            return this;
        }
        public String getActionType() {
            return this.actionType;
        }

        public WriteAlibabaUserCarbonRequestUserDetailsList setCarbonAmount(String carbonAmount) {
            this.carbonAmount = carbonAmount;
            return this;
        }
        public String getCarbonAmount() {
            return this.carbonAmount;
        }

        public WriteAlibabaUserCarbonRequestUserDetailsList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public WriteAlibabaUserCarbonRequestUserDetailsList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public WriteAlibabaUserCarbonRequestUserDetailsList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public WriteAlibabaUserCarbonRequestUserDetailsList setVersion(Integer version) {
            this.version = version;
            return this;
        }
        public Integer getVersion() {
            return this.version;
        }

    }

}
