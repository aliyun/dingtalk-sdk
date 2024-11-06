// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumUpdateProcessInstanceVariablesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>manager432</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <strong>example:</strong>
     * <p>PROC-EF6YJL35P2-SCKICSB7P750S0YISYKV3-xxxx-1</p>
     */
    @NameInMap("processCode")
    public String processCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>processInstanceId-1</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    /**
     * <strong>example:</strong>
     * <p>processInstanceId-1</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("variables")
    public java.util.List<PremiumUpdateProcessInstanceVariablesRequestVariables> variables;

    public static PremiumUpdateProcessInstanceVariablesRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumUpdateProcessInstanceVariablesRequest self = new PremiumUpdateProcessInstanceVariablesRequest();
        return TeaModel.build(map, self);
    }

    public PremiumUpdateProcessInstanceVariablesRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public PremiumUpdateProcessInstanceVariablesRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public PremiumUpdateProcessInstanceVariablesRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public PremiumUpdateProcessInstanceVariablesRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public PremiumUpdateProcessInstanceVariablesRequest setVariables(java.util.List<PremiumUpdateProcessInstanceVariablesRequestVariables> variables) {
        this.variables = variables;
        return this;
    }
    public java.util.List<PremiumUpdateProcessInstanceVariablesRequestVariables> getVariables() {
        return this.variables;
    }

    public static class PremiumUpdateProcessInstanceVariablesRequestVariables extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>Phone</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        /**
         * <strong>example:</strong>
         * <p>总个数:1</p>
         */
        @NameInMap("extValue")
        public String extValue;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>PhoneField_IZI2LP8QF6O0</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>123xxxxxxxx</p>
         */
        @NameInMap("value")
        public String value;

        public static PremiumUpdateProcessInstanceVariablesRequestVariables build(java.util.Map<String, ?> map) throws Exception {
            PremiumUpdateProcessInstanceVariablesRequestVariables self = new PremiumUpdateProcessInstanceVariablesRequestVariables();
            return TeaModel.build(map, self);
        }

        public PremiumUpdateProcessInstanceVariablesRequestVariables setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public PremiumUpdateProcessInstanceVariablesRequestVariables setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public PremiumUpdateProcessInstanceVariablesRequestVariables setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public PremiumUpdateProcessInstanceVariablesRequestVariables setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
