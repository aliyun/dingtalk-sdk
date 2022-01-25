// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class CreateActionResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("item")
    public java.util.List<CreateActionResponseBodyItem> item;

    public static CreateActionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateActionResponseBody self = new CreateActionResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateActionResponseBody setItem(java.util.List<CreateActionResponseBodyItem> item) {
        this.item = item;
        return this;
    }
    public java.util.List<CreateActionResponseBodyItem> getItem() {
        return this.item;
    }

    public static class CreateActionResponseBodyItem extends TeaModel {
        // 连接平台执行事件id
        @NameInMap("dingActionId")
        public String dingActionId;

        // 连接平台连接器id
        @NameInMap("dingConnectorId")
        public String dingConnectorId;

        // 服务商的执行事件id
        @NameInMap("integratorActionId")
        public String integratorActionId;

        // 服务商的连接器Id
        @NameInMap("integratorConnectorId")
        public String integratorConnectorId;

        // 错误码
        @NameInMap("subErrCode")
        public String subErrCode;

        // 错误信息
        @NameInMap("subErrMsg")
        public String subErrMsg;

        // 是否执行成功
        @NameInMap("success")
        public String success;

        public static CreateActionResponseBodyItem build(java.util.Map<String, ?> map) throws Exception {
            CreateActionResponseBodyItem self = new CreateActionResponseBodyItem();
            return TeaModel.build(map, self);
        }

        public CreateActionResponseBodyItem setDingActionId(String dingActionId) {
            this.dingActionId = dingActionId;
            return this;
        }
        public String getDingActionId() {
            return this.dingActionId;
        }

        public CreateActionResponseBodyItem setDingConnectorId(String dingConnectorId) {
            this.dingConnectorId = dingConnectorId;
            return this;
        }
        public String getDingConnectorId() {
            return this.dingConnectorId;
        }

        public CreateActionResponseBodyItem setIntegratorActionId(String integratorActionId) {
            this.integratorActionId = integratorActionId;
            return this;
        }
        public String getIntegratorActionId() {
            return this.integratorActionId;
        }

        public CreateActionResponseBodyItem setIntegratorConnectorId(String integratorConnectorId) {
            this.integratorConnectorId = integratorConnectorId;
            return this;
        }
        public String getIntegratorConnectorId() {
            return this.integratorConnectorId;
        }

        public CreateActionResponseBodyItem setSubErrCode(String subErrCode) {
            this.subErrCode = subErrCode;
            return this;
        }
        public String getSubErrCode() {
            return this.subErrCode;
        }

        public CreateActionResponseBodyItem setSubErrMsg(String subErrMsg) {
            this.subErrMsg = subErrMsg;
            return this;
        }
        public String getSubErrMsg() {
            return this.subErrMsg;
        }

        public CreateActionResponseBodyItem setSuccess(String success) {
            this.success = success;
            return this;
        }
        public String getSuccess() {
            return this.success;
        }

    }

}
