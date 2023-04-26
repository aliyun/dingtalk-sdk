// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomDeptRequest extends TeaModel {
    @NameInMap("customDept")
    public CreateCustomDeptRequestCustomDept customDept;

    @NameInMap("operator")
    public String operator;

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
        @NameInMap("name")
        public String name;

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
