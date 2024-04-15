// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkamdp_1_0.models;

import com.aliyun.tea.*;

public class AmdpJobPositionDataPushRequest extends TeaModel {
    @NameInMap("param")
    public java.util.List<AmdpJobPositionDataPushRequestParam> param;

    public static AmdpJobPositionDataPushRequest build(java.util.Map<String, ?> map) throws Exception {
        AmdpJobPositionDataPushRequest self = new AmdpJobPositionDataPushRequest();
        return TeaModel.build(map, self);
    }

    public AmdpJobPositionDataPushRequest setParam(java.util.List<AmdpJobPositionDataPushRequestParam> param) {
        this.param = param;
        return this;
    }
    public java.util.List<AmdpJobPositionDataPushRequestParam> getParam() {
        return this.param;
    }

    public static class AmdpJobPositionDataPushRequestParam extends TeaModel {
        @NameInMap("deptId")
        public String deptId;

        @NameInMap("deptLeader")
        public String deptLeader;

        @NameInMap("isDelete")
        public String isDelete;

        @NameInMap("orderNumber")
        public String orderNumber;

        @NameInMap("userId")
        public String userId;

        public static AmdpJobPositionDataPushRequestParam build(java.util.Map<String, ?> map) throws Exception {
            AmdpJobPositionDataPushRequestParam self = new AmdpJobPositionDataPushRequestParam();
            return TeaModel.build(map, self);
        }

        public AmdpJobPositionDataPushRequestParam setDeptId(String deptId) {
            this.deptId = deptId;
            return this;
        }
        public String getDeptId() {
            return this.deptId;
        }

        public AmdpJobPositionDataPushRequestParam setDeptLeader(String deptLeader) {
            this.deptLeader = deptLeader;
            return this;
        }
        public String getDeptLeader() {
            return this.deptLeader;
        }

        public AmdpJobPositionDataPushRequestParam setIsDelete(String isDelete) {
            this.isDelete = isDelete;
            return this;
        }
        public String getIsDelete() {
            return this.isDelete;
        }

        public AmdpJobPositionDataPushRequestParam setOrderNumber(String orderNumber) {
            this.orderNumber = orderNumber;
            return this;
        }
        public String getOrderNumber() {
            return this.orderNumber;
        }

        public AmdpJobPositionDataPushRequestParam setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
