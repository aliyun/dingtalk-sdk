// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkamdp_1_0.models;

import com.aliyun.tea.*;

public class AmdpEmployeeDataPushRequest extends TeaModel {
    @NameInMap("param")
    public java.util.List<AmdpEmployeeDataPushRequestParam> param;

    public static AmdpEmployeeDataPushRequest build(java.util.Map<String, ?> map) throws Exception {
        AmdpEmployeeDataPushRequest self = new AmdpEmployeeDataPushRequest();
        return TeaModel.build(map, self);
    }

    public AmdpEmployeeDataPushRequest setParam(java.util.List<AmdpEmployeeDataPushRequestParam> param) {
        this.param = param;
        return this;
    }
    public java.util.List<AmdpEmployeeDataPushRequestParam> getParam() {
        return this.param;
    }

    public static class AmdpEmployeeDataPushRequestParam extends TeaModel {
        @NameInMap("avatar")
        public String avatar;

        @NameInMap("isDelete")
        public String isDelete;

        @NameInMap("name")
        public String name;

        @NameInMap("unionId")
        public String unionId;

        @NameInMap("userId")
        public String userId;

        @NameInMap("workNo")
        public String workNo;

        public static AmdpEmployeeDataPushRequestParam build(java.util.Map<String, ?> map) throws Exception {
            AmdpEmployeeDataPushRequestParam self = new AmdpEmployeeDataPushRequestParam();
            return TeaModel.build(map, self);
        }

        public AmdpEmployeeDataPushRequestParam setAvatar(String avatar) {
            this.avatar = avatar;
            return this;
        }
        public String getAvatar() {
            return this.avatar;
        }

        public AmdpEmployeeDataPushRequestParam setIsDelete(String isDelete) {
            this.isDelete = isDelete;
            return this;
        }
        public String getIsDelete() {
            return this.isDelete;
        }

        public AmdpEmployeeDataPushRequestParam setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public AmdpEmployeeDataPushRequestParam setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public AmdpEmployeeDataPushRequestParam setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public AmdpEmployeeDataPushRequestParam setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
