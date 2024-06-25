// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomDeptRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("customDept")
    public CreateCustomDeptRequestCustomDept customDept;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>12345</p>
     */
    @NameInMap("operator")
    public String operator;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1233</p>
     */
    @NameInMap("superId")
    public Long superId;

    public static CreateCustomDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomDeptRequest self = new CreateCustomDeptRequest();
        return TeaModel.build(map, self);
    }

    public CreateCustomDeptRequest setCustomDept(CreateCustomDeptRequestCustomDept customDept) {
        this.customDept = customDept;
        return this;
    }
    public CreateCustomDeptRequestCustomDept getCustomDept() {
        return this.customDept;
    }

    public CreateCustomDeptRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public CreateCustomDeptRequest setSuperId(Long superId) {
        this.superId = superId;
        return this;
    }
    public Long getSuperId() {
        return this.superId;
    }

    public static class CreateCustomDeptRequestCustomDept extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>紫金港校区</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>custom_dept</p>
         */
        @NameInMap("type")
        public String type;

        public static CreateCustomDeptRequestCustomDept build(java.util.Map<String, ?> map) throws Exception {
            CreateCustomDeptRequestCustomDept self = new CreateCustomDeptRequestCustomDept();
            return TeaModel.build(map, self);
        }

        public CreateCustomDeptRequestCustomDept setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateCustomDeptRequestCustomDept setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
