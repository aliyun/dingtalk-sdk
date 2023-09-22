// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CreateRuleRequest extends TeaModel {
    @NameInMap("customPlan")
    public CreateRuleRequestCustomPlan customPlan;

    public static CreateRuleRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateRuleRequest self = new CreateRuleRequest();
        return TeaModel.build(map, self);
    }

    public CreateRuleRequest setCustomPlan(CreateRuleRequestCustomPlan customPlan) {
        this.customPlan = customPlan;
        return this;
    }
    public CreateRuleRequestCustomPlan getCustomPlan() {
        return this.customPlan;
    }

    public static class CreateRuleRequestCustomPlan extends TeaModel {
        @NameInMap("currentCategoryList")
        public java.util.List<String> currentCategoryList;

        @NameInMap("deptIds")
        public java.util.List<Long> deptIds;

        @NameInMap("planName")
        public String planName;

        @NameInMap("unSelectCategoryList")
        public java.util.List<String> unSelectCategoryList;

        @NameInMap("userIds")
        public java.util.List<String> userIds;

        public static CreateRuleRequestCustomPlan build(java.util.Map<String, ?> map) throws Exception {
            CreateRuleRequestCustomPlan self = new CreateRuleRequestCustomPlan();
            return TeaModel.build(map, self);
        }

        public CreateRuleRequestCustomPlan setCurrentCategoryList(java.util.List<String> currentCategoryList) {
            this.currentCategoryList = currentCategoryList;
            return this;
        }
        public java.util.List<String> getCurrentCategoryList() {
            return this.currentCategoryList;
        }

        public CreateRuleRequestCustomPlan setDeptIds(java.util.List<Long> deptIds) {
            this.deptIds = deptIds;
            return this;
        }
        public java.util.List<Long> getDeptIds() {
            return this.deptIds;
        }

        public CreateRuleRequestCustomPlan setPlanName(String planName) {
            this.planName = planName;
            return this;
        }
        public String getPlanName() {
            return this.planName;
        }

        public CreateRuleRequestCustomPlan setUnSelectCategoryList(java.util.List<String> unSelectCategoryList) {
            this.unSelectCategoryList = unSelectCategoryList;
            return this;
        }
        public java.util.List<String> getUnSelectCategoryList() {
            return this.unSelectCategoryList;
        }

        public CreateRuleRequestCustomPlan setUserIds(java.util.List<String> userIds) {
            this.userIds = userIds;
            return this;
        }
        public java.util.List<String> getUserIds() {
            return this.userIds;
        }

    }

}
