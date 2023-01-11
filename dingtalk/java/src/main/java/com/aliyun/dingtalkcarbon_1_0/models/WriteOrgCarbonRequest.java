// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteOrgCarbonRequest extends TeaModel {
    /**
     * <p>入参集</p>
     */
    @NameInMap("orgDetailsList")
    public java.util.List<WriteOrgCarbonRequestOrgDetailsList> orgDetailsList;

    public static WriteOrgCarbonRequest build(java.util.Map<String, ?> map) throws Exception {
        WriteOrgCarbonRequest self = new WriteOrgCarbonRequest();
        return TeaModel.build(map, self);
    }

    public WriteOrgCarbonRequest setOrgDetailsList(java.util.List<WriteOrgCarbonRequestOrgDetailsList> orgDetailsList) {
        this.orgDetailsList = orgDetailsList;
        return this;
    }
    public java.util.List<WriteOrgCarbonRequestOrgDetailsList> getOrgDetailsList() {
        return this.orgDetailsList;
    }

    public static class WriteOrgCarbonRequestOrgDetailsList extends TeaModel {
        /**
         * <p>系统唯一id，生成格式：userId+日期20211126</p>
         */
        @NameInMap("actionId")
        public String actionId;

        /**
         * <p>行为发生时间</p>
         */
        @NameInMap("actionTime")
        public String actionTime;

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
         * <p>版本，默认为1</p>
         */
        @NameInMap("version")
        public Integer version;

        public static WriteOrgCarbonRequestOrgDetailsList build(java.util.Map<String, ?> map) throws Exception {
            WriteOrgCarbonRequestOrgDetailsList self = new WriteOrgCarbonRequestOrgDetailsList();
            return TeaModel.build(map, self);
        }

        public WriteOrgCarbonRequestOrgDetailsList setActionId(String actionId) {
            this.actionId = actionId;
            return this;
        }
        public String getActionId() {
            return this.actionId;
        }

        public WriteOrgCarbonRequestOrgDetailsList setActionTime(String actionTime) {
            this.actionTime = actionTime;
            return this;
        }
        public String getActionTime() {
            return this.actionTime;
        }

        public WriteOrgCarbonRequestOrgDetailsList setActionType(String actionType) {
            this.actionType = actionType;
            return this;
        }
        public String getActionType() {
            return this.actionType;
        }

        public WriteOrgCarbonRequestOrgDetailsList setCarbonAmount(String carbonAmount) {
            this.carbonAmount = carbonAmount;
            return this;
        }
        public String getCarbonAmount() {
            return this.carbonAmount;
        }

        public WriteOrgCarbonRequestOrgDetailsList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public WriteOrgCarbonRequestOrgDetailsList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public WriteOrgCarbonRequestOrgDetailsList setVersion(Integer version) {
            this.version = version;
            return this;
        }
        public Integer getVersion() {
            return this.version;
        }

    }

}
