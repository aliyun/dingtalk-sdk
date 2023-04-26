// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class UpdateTriggerResponseBody extends TeaModel {
    @NameInMap("item")
    public java.util.List<UpdateTriggerResponseBodyItem> item;

    public static UpdateTriggerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateTriggerResponseBody self = new UpdateTriggerResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateTriggerResponseBody setItem(java.util.List<UpdateTriggerResponseBodyItem> item) {
        this.item = item;
        return this;
    }
    public java.util.List<UpdateTriggerResponseBodyItem> getItem() {
        return this.item;
    }

    public static class UpdateTriggerResponseBodyItem extends TeaModel {
        @NameInMap("dingConnectorId")
        public String dingConnectorId;

        @NameInMap("dingTriggerId")
        public String dingTriggerId;

        @NameInMap("integratorConnectorId")
        public String integratorConnectorId;

        @NameInMap("integratorTriggerId")
        public String integratorTriggerId;

        @NameInMap("subErrCode")
        public String subErrCode;

        @NameInMap("subErrMsg")
        public String subErrMsg;

        @NameInMap("success")
        public Boolean success;

        public static UpdateTriggerResponseBodyItem build(java.util.Map<String, ?> map) throws Exception {
            UpdateTriggerResponseBodyItem self = new UpdateTriggerResponseBodyItem();
            return TeaModel.build(map, self);
        }

        public UpdateTriggerResponseBodyItem setDingConnectorId(String dingConnectorId) {
            this.dingConnectorId = dingConnectorId;
            return this;
        }
        public String getDingConnectorId() {
            return this.dingConnectorId;
        }

        public UpdateTriggerResponseBodyItem setDingTriggerId(String dingTriggerId) {
            this.dingTriggerId = dingTriggerId;
            return this;
        }
        public String getDingTriggerId() {
            return this.dingTriggerId;
        }

        public UpdateTriggerResponseBodyItem setIntegratorConnectorId(String integratorConnectorId) {
            this.integratorConnectorId = integratorConnectorId;
            return this;
        }
        public String getIntegratorConnectorId() {
            return this.integratorConnectorId;
        }

        public UpdateTriggerResponseBodyItem setIntegratorTriggerId(String integratorTriggerId) {
            this.integratorTriggerId = integratorTriggerId;
            return this;
        }
        public String getIntegratorTriggerId() {
            return this.integratorTriggerId;
        }

        public UpdateTriggerResponseBodyItem setSubErrCode(String subErrCode) {
            this.subErrCode = subErrCode;
            return this;
        }
        public String getSubErrCode() {
            return this.subErrCode;
        }

        public UpdateTriggerResponseBodyItem setSubErrMsg(String subErrMsg) {
            this.subErrMsg = subErrMsg;
            return this;
        }
        public String getSubErrMsg() {
            return this.subErrMsg;
        }

        public UpdateTriggerResponseBodyItem setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
