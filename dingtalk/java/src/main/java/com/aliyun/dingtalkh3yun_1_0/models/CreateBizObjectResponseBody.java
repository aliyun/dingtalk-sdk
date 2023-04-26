// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class CreateBizObjectResponseBody extends TeaModel {
    @NameInMap("code")
    public String code;

    @NameInMap("data")
    public CreateBizObjectResponseBodyData data;

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
        @NameInMap("bizObjectId")
        public String bizObjectId;

        @NameInMap("formUsageType")
        public String formUsageType;

        @NameInMap("processInstanceId")
        public String processInstanceId;

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
