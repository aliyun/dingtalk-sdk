// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class CreateTriggerResponseBody extends TeaModel {
    /**
     * <p>Id of the request</p>
     */
    @NameInMap("item")
    public java.util.List<CreateTriggerResponseBodyItem> item;

    public static CreateTriggerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateTriggerResponseBody self = new CreateTriggerResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateTriggerResponseBody setItem(java.util.List<CreateTriggerResponseBodyItem> item) {
        this.item = item;
        return this;
    }
    public java.util.List<CreateTriggerResponseBodyItem> getItem() {
        return this.item;
    }

    public static class CreateTriggerResponseBodyItem extends TeaModel {
        /**
         * <p>连接平台连接器id</p>
         */
        @NameInMap("dingConnectorId")
        public String dingConnectorId;

        /**
         * <p>连接平台触发事件id</p>
         */
        @NameInMap("dingTriggerId")
        public String dingTriggerId;

        /**
         * <p>服务商的连接器Id</p>
         */
        @NameInMap("integratorConnectorId")
        public String integratorConnectorId;

        /**
         * <p>服务商的触发事件id</p>
         */
        @NameInMap("integratorTriggerId")
        public String integratorTriggerId;

        /**
         * <p>错误码</p>
         */
        @NameInMap("subErrCode")
        public String subErrCode;

        /**
         * <p>错误信息</p>
         */
        @NameInMap("subErrMsg")
        public String subErrMsg;

        /**
         * <p>是否成功</p>
         */
        @NameInMap("success")
        public Boolean success;

        public static CreateTriggerResponseBodyItem build(java.util.Map<String, ?> map) throws Exception {
            CreateTriggerResponseBodyItem self = new CreateTriggerResponseBodyItem();
            return TeaModel.build(map, self);
        }

        public CreateTriggerResponseBodyItem setDingConnectorId(String dingConnectorId) {
            this.dingConnectorId = dingConnectorId;
            return this;
        }
        public String getDingConnectorId() {
            return this.dingConnectorId;
        }

        public CreateTriggerResponseBodyItem setDingTriggerId(String dingTriggerId) {
            this.dingTriggerId = dingTriggerId;
            return this;
        }
        public String getDingTriggerId() {
            return this.dingTriggerId;
        }

        public CreateTriggerResponseBodyItem setIntegratorConnectorId(String integratorConnectorId) {
            this.integratorConnectorId = integratorConnectorId;
            return this;
        }
        public String getIntegratorConnectorId() {
            return this.integratorConnectorId;
        }

        public CreateTriggerResponseBodyItem setIntegratorTriggerId(String integratorTriggerId) {
            this.integratorTriggerId = integratorTriggerId;
            return this;
        }
        public String getIntegratorTriggerId() {
            return this.integratorTriggerId;
        }

        public CreateTriggerResponseBodyItem setSubErrCode(String subErrCode) {
            this.subErrCode = subErrCode;
            return this;
        }
        public String getSubErrCode() {
            return this.subErrCode;
        }

        public CreateTriggerResponseBodyItem setSubErrMsg(String subErrMsg) {
            this.subErrMsg = subErrMsg;
            return this;
        }
        public String getSubErrMsg() {
            return this.subErrMsg;
        }

        public CreateTriggerResponseBodyItem setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
