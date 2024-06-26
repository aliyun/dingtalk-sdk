// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class SyncDataRequest extends TeaModel {
    @NameInMap("appId")
    public String appId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("triggerDataList")
    public java.util.List<SyncDataRequestTriggerDataList> triggerDataList;

    public static SyncDataRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncDataRequest self = new SyncDataRequest();
        return TeaModel.build(map, self);
    }

    public SyncDataRequest setAppId(String appId) {
        this.appId = appId;
        return this;
    }
    public String getAppId() {
        return this.appId;
    }

    public SyncDataRequest setTriggerDataList(java.util.List<SyncDataRequestTriggerDataList> triggerDataList) {
        this.triggerDataList = triggerDataList;
        return this;
    }
    public java.util.List<SyncDataRequestTriggerDataList> getTriggerDataList() {
        return this.triggerDataList;
    }

    public static class SyncDataRequestTriggerDataList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("action")
        public String action;

        @NameInMap("customTriggerId")
        public String customTriggerId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("dataGmtCreate")
        public Long dataGmtCreate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("dataGmtModified")
        public Long dataGmtModified;

        /**
         * <strong>if can be null:</strong>
         * <p>true</p>
         */
        @NameInMap("integrationObject")
        public String integrationObject;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("jsonData")
        public String jsonData;

        @NameInMap("triggerCondition")
        public String triggerCondition;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("triggerId")
        public String triggerId;

        public static SyncDataRequestTriggerDataList build(java.util.Map<String, ?> map) throws Exception {
            SyncDataRequestTriggerDataList self = new SyncDataRequestTriggerDataList();
            return TeaModel.build(map, self);
        }

        public SyncDataRequestTriggerDataList setAction(String action) {
            this.action = action;
            return this;
        }
        public String getAction() {
            return this.action;
        }

        public SyncDataRequestTriggerDataList setCustomTriggerId(String customTriggerId) {
            this.customTriggerId = customTriggerId;
            return this;
        }
        public String getCustomTriggerId() {
            return this.customTriggerId;
        }

        public SyncDataRequestTriggerDataList setDataGmtCreate(Long dataGmtCreate) {
            this.dataGmtCreate = dataGmtCreate;
            return this;
        }
        public Long getDataGmtCreate() {
            return this.dataGmtCreate;
        }

        public SyncDataRequestTriggerDataList setDataGmtModified(Long dataGmtModified) {
            this.dataGmtModified = dataGmtModified;
            return this;
        }
        public Long getDataGmtModified() {
            return this.dataGmtModified;
        }

        public SyncDataRequestTriggerDataList setIntegrationObject(String integrationObject) {
            this.integrationObject = integrationObject;
            return this;
        }
        public String getIntegrationObject() {
            return this.integrationObject;
        }

        public SyncDataRequestTriggerDataList setJsonData(String jsonData) {
            this.jsonData = jsonData;
            return this;
        }
        public String getJsonData() {
            return this.jsonData;
        }

        public SyncDataRequestTriggerDataList setTriggerCondition(String triggerCondition) {
            this.triggerCondition = triggerCondition;
            return this;
        }
        public String getTriggerCondition() {
            return this.triggerCondition;
        }

        public SyncDataRequestTriggerDataList setTriggerId(String triggerId) {
            this.triggerId = triggerId;
            return this;
        }
        public String getTriggerId() {
            return this.triggerId;
        }

    }

}
