// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomClassRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("customClass")
    public CreateCustomClassRequestCustomClass customClass;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operator")
    public String operator;

    /**
     * <p>This parameter is required.</p>
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
         * <p>This parameter is required.</p>
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
