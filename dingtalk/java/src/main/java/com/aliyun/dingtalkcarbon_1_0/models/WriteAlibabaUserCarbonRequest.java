// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteAlibabaUserCarbonRequest extends TeaModel {
    /**
     * <p>入参集</p>
     */
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
        /**
         * <p>行为结束时间</p>
         */
        @NameInMap("actionEndTime")
        public String actionEndTime;

        /**
         * <p>系统唯一id，生成格式：userId+日期20211126</p>
         */
        @NameInMap("actionId")
        public String actionId;

        /**
         * <p>行为起始时间</p>
         */
        @NameInMap("actionStartTime")
        public String actionStartTime;

        /**
         * <p>碳能量行为类型，需要联系管理员添加</p>
         */
        @NameInMap("actionType")
        public String actionType;

        /**
         * <p>碳能量数据</p>
         */
        @NameInMap("carbonAmount")
        public String carbonAmount;

        /**
         * <p>钉钉组织id</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>钉钉部门id</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        /**
         * <p>钉钉用户id</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <p>版本，默认为1</p>
         */
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
