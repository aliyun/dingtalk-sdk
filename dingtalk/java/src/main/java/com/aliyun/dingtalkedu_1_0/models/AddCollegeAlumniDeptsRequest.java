// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddCollegeAlumniDeptsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("depts")
    public java.util.List<AddCollegeAlumniDeptsRequestDepts> depts;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operator")
    public String operator;

    public static AddCollegeAlumniDeptsRequest build(java.util.Map<String, ?> map) throws Exception {
        AddCollegeAlumniDeptsRequest self = new AddCollegeAlumniDeptsRequest();
        return TeaModel.build(map, self);
    }

    public AddCollegeAlumniDeptsRequest setDepts(java.util.List<AddCollegeAlumniDeptsRequestDepts> depts) {
        this.depts = depts;
        return this;
    }
    public java.util.List<AddCollegeAlumniDeptsRequestDepts> getDepts() {
        return this.depts;
    }

    public AddCollegeAlumniDeptsRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public static class AddCollegeAlumniDeptsRequestDepts extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("superId")
        public Long superId;

        public static AddCollegeAlumniDeptsRequestDepts build(java.util.Map<String, ?> map) throws Exception {
            AddCollegeAlumniDeptsRequestDepts self = new AddCollegeAlumniDeptsRequestDepts();
            return TeaModel.build(map, self);
        }

        public AddCollegeAlumniDeptsRequestDepts setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public AddCollegeAlumniDeptsRequestDepts setSuperId(Long superId) {
            this.superId = superId;
            return this;
        }
        public Long getSuperId() {
            return this.superId;
        }

    }

}
