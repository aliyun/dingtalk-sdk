// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteUserCarbonRequest extends TeaModel {
    // 入参集
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
        // 系统唯一id，生成格式：userId+日期20211126
        @NameInMap("actionId")
        public String actionId;

        // 钉钉用户id
        @NameInMap("userId")
        public String userId;

        // 钉钉组织id
        @NameInMap("corpId")
        public String corpId;

        // 钉钉部门id
        @NameInMap("deptId")
        public Long deptId;

        // 碳能量行为类型，需要联系管理员添加
        @NameInMap("actionType")
        public String actionType;

        // 碳能量数据
        @NameInMap("carbonAmount")
        public String carbonAmount;

        // 行为起始时间
        @NameInMap("actionStartTime")
        public String actionStartTime;

        // 行为结束时间
        @NameInMap("actionEndTime")
        public String actionEndTime;

        // 版本，默认为1
        @NameInMap("version")
        public Integer version;

        public static WriteUserCarbonRequestUserDetailsList build(java.util.Map<String, ?> map) throws Exception {
            WriteUserCarbonRequestUserDetailsList self = new WriteUserCarbonRequestUserDetailsList();
            return TeaModel.build(map, self);
        }

        public WriteUserCarbonRequestUserDetailsList setActionId(String actionId) {
            this.actionId = actionId;
            return this;
        }
        public String getActionId() {
            return this.actionId;
        }

        public WriteUserCarbonRequestUserDetailsList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
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

        public WriteUserCarbonRequestUserDetailsList setActionStartTime(String actionStartTime) {
            this.actionStartTime = actionStartTime;
            return this;
        }
        public String getActionStartTime() {
            return this.actionStartTime;
        }

        public WriteUserCarbonRequestUserDetailsList setActionEndTime(String actionEndTime) {
            this.actionEndTime = actionEndTime;
            return this;
        }
        public String getActionEndTime() {
            return this.actionEndTime;
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
