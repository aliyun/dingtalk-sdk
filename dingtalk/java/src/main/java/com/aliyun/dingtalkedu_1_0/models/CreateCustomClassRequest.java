// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomClassRequest extends TeaModel {
    /**
     * <p>班级信息</p>
     */
    @NameInMap("customClass")
    public CreateCustomClassRequestCustomClass customClass;

    /**
     * <p>钉钉企业管理员工ID</p>
     */
    @NameInMap("operator")
    public String operator;

    /**
     * <p>上级部门ID</p>
     */
    @NameInMap("superId")
    public Long superId;

    public static CreateCustomClassRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomClassRequest self = new CreateCustomClassRequest();
        return TeaModel.build(map, self);
    }

    public CreateCustomClassRequest setCustomClass(CreateCustomClassRequestCustomClass customClass) {
        this.customClass = customClass;
        return this;
    }
    public CreateCustomClassRequestCustomClass getCustomClass() {
        return this.customClass;
    }

    public CreateCustomClassRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public CreateCustomClassRequest setSuperId(Long superId) {
        this.superId = superId;
        return this;
    }
    public Long getSuperId() {
        return this.superId;
    }

    public static class CreateCustomClassRequestCustomClass extends TeaModel {
        /**
         * <p>班级名称</p>
         */
        @NameInMap("name")
        public String name;

        public static CreateCustomClassRequestCustomClass build(java.util.Map<String, ?> map) throws Exception {
            CreateCustomClassRequestCustomClass self = new CreateCustomClassRequestCustomClass();
            return TeaModel.build(map, self);
        }

        public CreateCustomClassRequestCustomClass setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
