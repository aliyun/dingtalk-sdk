// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class UpdateActionResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("item")
    public java.util.List<UpdateActionResponseBodyItem> item;

    public static UpdateActionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateActionResponseBody self = new UpdateActionResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateActionResponseBody setItem(java.util.List<UpdateActionResponseBodyItem> item) {
        this.item = item;
        return this;
    }
    public java.util.List<UpdateActionResponseBodyItem> getItem() {
        return this.item;
    }

    public static class UpdateActionResponseBodyItem extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("dingActionId")
        public String dingActionId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("dingConnectorId")
        public String dingConnectorId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("integratorActionId")
        public String integratorActionId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("integratorConnectorId")
        public String integratorConnectorId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("subErrCode")
        public String subErrCode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("subErrMsg")
        public String subErrMsg;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("success")
        public String success;

        public static UpdateActionResponseBodyItem build(java.util.Map<String, ?> map) throws Exception {
            UpdateActionResponseBodyItem self = new UpdateActionResponseBodyItem();
            return TeaModel.build(map, self);
        }

        public UpdateActionResponseBodyItem setDingActionId(String dingActionId) {
            this.dingActionId = dingActionId;
            return this;
        }
        public String getDingActionId() {
            return this.dingActionId;
        }

        public UpdateActionResponseBodyItem setDingConnectorId(String dingConnectorId) {
            this.dingConnectorId = dingConnectorId;
            return this;
        }
        public String getDingConnectorId() {
            return this.dingConnectorId;
        }

        public UpdateActionResponseBodyItem setIntegratorActionId(String integratorActionId) {
            this.integratorActionId = integratorActionId;
            return this;
        }
        public String getIntegratorActionId() {
            return this.integratorActionId;
        }

        public UpdateActionResponseBodyItem setIntegratorConnectorId(String integratorConnectorId) {
            this.integratorConnectorId = integratorConnectorId;
            return this;
        }
        public String getIntegratorConnectorId() {
            return this.integratorConnectorId;
        }

        public UpdateActionResponseBodyItem setSubErrCode(String subErrCode) {
            this.subErrCode = subErrCode;
            return this;
        }
        public String getSubErrCode() {
            return this.subErrCode;
        }

        public UpdateActionResponseBodyItem setSubErrMsg(String subErrMsg) {
            this.subErrMsg = subErrMsg;
            return this;
        }
        public String getSubErrMsg() {
            return this.subErrMsg;
        }

        public UpdateActionResponseBodyItem setSuccess(String success) {
            this.success = success;
            return this;
        }
        public String getSuccess() {
            return this.success;
        }

    }

}
