// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class CreateConnectorResponseBody extends TeaModel {
    @NameInMap("item")
    public java.util.List<CreateConnectorResponseBodyItem> item;

    public static CreateConnectorResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateConnectorResponseBody self = new CreateConnectorResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateConnectorResponseBody setItem(java.util.List<CreateConnectorResponseBodyItem> item) {
        this.item = item;
        return this;
    }
    public java.util.List<CreateConnectorResponseBodyItem> getItem() {
        return this.item;
    }

    public static class CreateConnectorResponseBodyItem extends TeaModel {
        @NameInMap("dingConnectorId")
        public String dingConnectorId;

        @NameInMap("integratorConnectorId")
        public String integratorConnectorId;

        @NameInMap("subErrCode")
        public String subErrCode;

        @NameInMap("subErrMsg")
        public String subErrMsg;

        @NameInMap("success")
        public Boolean success;

        public static CreateConnectorResponseBodyItem build(java.util.Map<String, ?> map) throws Exception {
            CreateConnectorResponseBodyItem self = new CreateConnectorResponseBodyItem();
            return TeaModel.build(map, self);
        }

        public CreateConnectorResponseBodyItem setDingConnectorId(String dingConnectorId) {
            this.dingConnectorId = dingConnectorId;
            return this;
        }
        public String getDingConnectorId() {
            return this.dingConnectorId;
        }

        public CreateConnectorResponseBodyItem setIntegratorConnectorId(String integratorConnectorId) {
            this.integratorConnectorId = integratorConnectorId;
            return this;
        }
        public String getIntegratorConnectorId() {
            return this.integratorConnectorId;
        }

        public CreateConnectorResponseBodyItem setSubErrCode(String subErrCode) {
            this.subErrCode = subErrCode;
            return this;
        }
        public String getSubErrCode() {
            return this.subErrCode;
        }

        public CreateConnectorResponseBodyItem setSubErrMsg(String subErrMsg) {
            this.subErrMsg = subErrMsg;
            return this;
        }
        public String getSubErrMsg() {
            return this.subErrMsg;
        }

        public CreateConnectorResponseBodyItem setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
