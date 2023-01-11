// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class SyncDataRequest extends TeaModel {
    /**
     * <p>同步数据的应用id，isv应用传isv应用id，企业自建应用传agentId。</p>
     */
    @NameInMap("appId")
    public String appId;

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
        @NameInMap("action")
        public String action;

        @NameInMap("customTriggerId")
        public String customTriggerId;

        @NameInMap("dataGmtCreate")
        public Long dataGmtCreate;

        @NameInMap("dataGmtModified")
        public Long dataGmtModified;

        @NameInMap("integrationObject")
        public String integrationObject;

        @NameInMap("jsonData")
        public String jsonData;

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

        public SyncDataRequestTriggerDataList setTriggerId(String triggerId) {
            this.triggerId = triggerId;
            return this;
        }
        public String getTriggerId() {
            return this.triggerId;
        }

    }

}
