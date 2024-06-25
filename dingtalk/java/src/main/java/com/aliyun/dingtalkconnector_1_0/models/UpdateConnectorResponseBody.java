// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class UpdateConnectorResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("item")
    public java.util.List<UpdateConnectorResponseBodyItem> item;

    public static UpdateConnectorResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateConnectorResponseBody self = new UpdateConnectorResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateConnectorResponseBody setItem(java.util.List<UpdateConnectorResponseBodyItem> item) {
        this.item = item;
        return this;
    }
    public java.util.List<UpdateConnectorResponseBodyItem> getItem() {
        return this.item;
    }

    public static class UpdateConnectorResponseBodyItem extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>G-CONN-101921B15FE0212B4AF70</p>
         */
        @NameInMap("dingConnectorId")
        public String dingConnectorId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("integratorConnectorId")
        public String integratorConnectorId;

        @NameInMap("subErrCode")
        public String subErrCode;

        @NameInMap("subErrMsg")
        public String subErrMsg;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("success")
        public Boolean success;

        public static UpdateConnectorResponseBodyItem build(java.util.Map<String, ?> map) throws Exception {
            UpdateConnectorResponseBodyItem self = new UpdateConnectorResponseBodyItem();
            return TeaModel.build(map, self);
        }

        public UpdateConnectorResponseBodyItem setDingConnectorId(String dingConnectorId) {
            this.dingConnectorId = dingConnectorId;
            return this;
        }
        public String getDingConnectorId() {
            return this.dingConnectorId;
        }

        public UpdateConnectorResponseBodyItem setIntegratorConnectorId(String integratorConnectorId) {
            this.integratorConnectorId = integratorConnectorId;
            return this;
        }
        public String getIntegratorConnectorId() {
            return this.integratorConnectorId;
        }

        public UpdateConnectorResponseBodyItem setSubErrCode(String subErrCode) {
            this.subErrCode = subErrCode;
            return this;
        }
        public String getSubErrCode() {
            return this.subErrCode;
        }

        public UpdateConnectorResponseBodyItem setSubErrMsg(String subErrMsg) {
            this.subErrMsg = subErrMsg;
            return this;
        }
        public String getSubErrMsg() {
            return this.subErrMsg;
        }

        public UpdateConnectorResponseBodyItem setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
