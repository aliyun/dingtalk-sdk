// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class SyncDataRequest extends TeaModel {
    @NameInMap("triggerDataList")
    public java.util.List<SyncDataRequestTriggerDataList> triggerDataList;

    public static SyncDataRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncDataRequest self = new SyncDataRequest();
        return TeaModel.build(map, self);
    }

    public SyncDataRequest setTriggerDataList(java.util.List<SyncDataRequestTriggerDataList> triggerDataList) {
        this.triggerDataList = triggerDataList;
        return this;
    }
    public java.util.List<SyncDataRequestTriggerDataList> getTriggerDataList() {
        return this.triggerDataList;
    }

    public static class SyncDataRequestTriggerDataList extends TeaModel {
        @NameInMap("triggerId")
        public String triggerId;

        @NameInMap("customTriggerId")
        public String customTriggerId;

        @NameInMap("jsonData")
        public String jsonData;

        @NameInMap("dataGmtCreate")
        public Long dataGmtCreate;

        @NameInMap("dataGmtModified")
        public Long dataGmtModified;

        @NameInMap("action")
        public String action;

        public static SyncDataRequestTriggerDataList build(java.util.Map<String, ?> map) throws Exception {
            SyncDataRequestTriggerDataList self = new SyncDataRequestTriggerDataList();
            return TeaModel.build(map, self);
        }

        public SyncDataRequestTriggerDataList setTriggerId(String triggerId) {
            this.triggerId = triggerId;
            return this;
        }
        public String getTriggerId() {
            return this.triggerId;
        }

        public SyncDataRequestTriggerDataList setCustomTriggerId(String customTriggerId) {
            this.customTriggerId = customTriggerId;
            return this;
        }
        public String getCustomTriggerId() {
            return this.customTriggerId;
        }

        public SyncDataRequestTriggerDataList setJsonData(String jsonData) {
            this.jsonData = jsonData;
            return this;
        }
        public String getJsonData() {
            return this.jsonData;
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

        public SyncDataRequestTriggerDataList setAction(String action) {
            this.action = action;
            return this;
        }
        public String getAction() {
            return this.action;
        }

    }

}
