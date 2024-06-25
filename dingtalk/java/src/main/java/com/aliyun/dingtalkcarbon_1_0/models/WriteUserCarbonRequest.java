// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteUserCarbonRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
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
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-11-26 10:09:37</p>
         */
        @NameInMap("actionEndTime")
        public String actionEndTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>12320211126</p>
         */
        @NameInMap("actionId")
        public String actionId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-11-26 10:09:37</p>
         */
        @NameInMap("actionStartTime")
        public String actionStartTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>VIDEO</p>
         */
        @NameInMap("actionType")
        public String actionType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>3.21</p>
         */
        @NameInMap("carbonAmount")
        public String carbonAmount;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>ding12344</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>111</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
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
