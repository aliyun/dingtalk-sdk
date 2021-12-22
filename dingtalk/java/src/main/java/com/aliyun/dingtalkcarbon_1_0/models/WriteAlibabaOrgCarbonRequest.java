// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteAlibabaOrgCarbonRequest extends TeaModel {
    // 入参集
    @NameInMap("orgDetailsList")
    public java.util.List<WriteAlibabaOrgCarbonRequestOrgDetailsList> orgDetailsList;

    public static WriteAlibabaOrgCarbonRequest build(java.util.Map<String, ?> map) throws Exception {
        WriteAlibabaOrgCarbonRequest self = new WriteAlibabaOrgCarbonRequest();
        return TeaModel.build(map, self);
    }

    public WriteAlibabaOrgCarbonRequest setOrgDetailsList(java.util.List<WriteAlibabaOrgCarbonRequestOrgDetailsList> orgDetailsList) {
        this.orgDetailsList = orgDetailsList;
        return this;
    }
    public java.util.List<WriteAlibabaOrgCarbonRequestOrgDetailsList> getOrgDetailsList() {
        return this.orgDetailsList;
    }

    public static class WriteAlibabaOrgCarbonRequestOrgDetailsList extends TeaModel {
        // 系统唯一id，生成格式：userId+日期20211126
        @NameInMap("actionId")
        public String actionId;

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

        // 行为发生时间
        @NameInMap("actionTime")
        public String actionTime;

        // 版本，默认为1
        @NameInMap("version")
        public Integer version;

        public static WriteAlibabaOrgCarbonRequestOrgDetailsList build(java.util.Map<String, ?> map) throws Exception {
            WriteAlibabaOrgCarbonRequestOrgDetailsList self = new WriteAlibabaOrgCarbonRequestOrgDetailsList();
            return TeaModel.build(map, self);
        }

        public WriteAlibabaOrgCarbonRequestOrgDetailsList setActionId(String actionId) {
            this.actionId = actionId;
            return this;
        }
        public String getActionId() {
            return this.actionId;
        }

        public WriteAlibabaOrgCarbonRequestOrgDetailsList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public WriteAlibabaOrgCarbonRequestOrgDetailsList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public WriteAlibabaOrgCarbonRequestOrgDetailsList setActionType(String actionType) {
            this.actionType = actionType;
            return this;
        }
        public String getActionType() {
            return this.actionType;
        }

        public WriteAlibabaOrgCarbonRequestOrgDetailsList setCarbonAmount(String carbonAmount) {
            this.carbonAmount = carbonAmount;
            return this;
        }
        public String getCarbonAmount() {
            return this.carbonAmount;
        }

        public WriteAlibabaOrgCarbonRequestOrgDetailsList setActionTime(String actionTime) {
            this.actionTime = actionTime;
            return this;
        }
        public String getActionTime() {
            return this.actionTime;
        }

        public WriteAlibabaOrgCarbonRequestOrgDetailsList setVersion(Integer version) {
            this.version = version;
            return this;
        }
        public Integer getVersion() {
            return this.version;
        }

    }

}
