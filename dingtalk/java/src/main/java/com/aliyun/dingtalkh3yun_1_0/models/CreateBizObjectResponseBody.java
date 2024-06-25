// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class CreateBizObjectResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>success</p>
     */
    @NameInMap("code")
    public String code;

    @NameInMap("data")
    public CreateBizObjectResponseBodyData data;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>Code</p>
     */
    @NameInMap("message")
    public String message;

    public static CreateBizObjectResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateBizObjectResponseBody self = new CreateBizObjectResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateBizObjectResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public CreateBizObjectResponseBody setData(CreateBizObjectResponseBodyData data) {
        this.data = data;
        return this;
    }
    public CreateBizObjectResponseBodyData getData() {
        return this.data;
    }

    public CreateBizObjectResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class CreateBizObjectResponseBodyData extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>50599800-af82-487e-9386-0a7278cab69f</p>
         */
        @NameInMap("bizObjectId")
        public String bizObjectId;

        /**
         * <strong>example:</strong>
         * <p>DataList</p>
         */
        @NameInMap("formUsageType")
        public String formUsageType;

        /**
         * <strong>example:</strong>
         * <p>3b5451bc-9fd3-4d0c-ba47-191f8bff95ab</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        /**
         * <strong>example:</strong>
         * <p>D0001839bbbbe346bbf496498bb76c44c7eb972</p>
         */
        @NameInMap("schemaCode")
        public String schemaCode;

        public static CreateBizObjectResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            CreateBizObjectResponseBodyData self = new CreateBizObjectResponseBodyData();
            return TeaModel.build(map, self);
        }

        public CreateBizObjectResponseBodyData setBizObjectId(String bizObjectId) {
            this.bizObjectId = bizObjectId;
            return this;
        }
        public String getBizObjectId() {
            return this.bizObjectId;
        }

        public CreateBizObjectResponseBodyData setFormUsageType(String formUsageType) {
            this.formUsageType = formUsageType;
            return this;
        }
        public String getFormUsageType() {
            return this.formUsageType;
        }

        public CreateBizObjectResponseBodyData setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public CreateBizObjectResponseBodyData setSchemaCode(String schemaCode) {
            this.schemaCode = schemaCode;
            return this;
        }
        public String getSchemaCode() {
            return this.schemaCode;
        }

    }

}
