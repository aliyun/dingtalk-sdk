// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeListDeptManagerResponseBody extends TeaModel {
    /**
     * <p>负责人信息列表</p>
     */
    @NameInMap("managerInfoSimpleList")
    public java.util.List<CollegeListDeptManagerResponseBodyManagerInfoSimpleList> managerInfoSimpleList;

    /**
     * <p>数据总条目数</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static CollegeListDeptManagerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeListDeptManagerResponseBody self = new CollegeListDeptManagerResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeListDeptManagerResponseBody setManagerInfoSimpleList(java.util.List<CollegeListDeptManagerResponseBodyManagerInfoSimpleList> managerInfoSimpleList) {
        this.managerInfoSimpleList = managerInfoSimpleList;
        return this;
    }
    public java.util.List<CollegeListDeptManagerResponseBodyManagerInfoSimpleList> getManagerInfoSimpleList() {
        return this.managerInfoSimpleList;
    }

    public CollegeListDeptManagerResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class CollegeListDeptManagerResponseBodyManagerInfoSimpleList extends TeaModel {
        /**
         * <p>账号是否激活</p>
         */
        @NameInMap("isActive")
        public Boolean isActive;

        /**
         * <p>负责人姓名</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>userId</p>
         */
        @NameInMap("userId")
        public String userId;

        public static CollegeListDeptManagerResponseBodyManagerInfoSimpleList build(java.util.Map<String, ?> map) throws Exception {
            CollegeListDeptManagerResponseBodyManagerInfoSimpleList self = new CollegeListDeptManagerResponseBodyManagerInfoSimpleList();
            return TeaModel.build(map, self);
        }

        public CollegeListDeptManagerResponseBodyManagerInfoSimpleList setIsActive(Boolean isActive) {
            this.isActive = isActive;
            return this;
        }
        public Boolean getIsActive() {
            return this.isActive;
        }

        public CollegeListDeptManagerResponseBodyManagerInfoSimpleList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CollegeListDeptManagerResponseBodyManagerInfoSimpleList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
