// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteAlibabaOrgCarbonRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
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
        @NameInMap("actionTime")
        public String actionTime;

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
         * <p>1</p>
         */
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

        public WriteAlibabaOrgCarbonRequestOrgDetailsList setActionTime(String actionTime) {
            this.actionTime = actionTime;
            return this;
        }
        public String getActionTime() {
            return this.actionTime;
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

        public WriteAlibabaOrgCarbonRequestOrgDetailsList setVersion(Integer version) {
            this.version = version;
            return this;
        }
        public Integer getVersion() {
            return this.version;
        }

    }

}
