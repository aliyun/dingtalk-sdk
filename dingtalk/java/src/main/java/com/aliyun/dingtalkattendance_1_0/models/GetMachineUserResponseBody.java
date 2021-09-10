// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetMachineUserResponseBody extends TeaModel {
    // 查询结果
    @NameInMap("result")
    public GetMachineUserResponseBodyResult result;

    public static GetMachineUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMachineUserResponseBody self = new GetMachineUserResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMachineUserResponseBody setResult(GetMachineUserResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetMachineUserResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetMachineUserResponseBodyResultUserList extends TeaModel {
        // 员工id
        @NameInMap("userId")
        public String userId;

        // 员工名称
        @NameInMap("name")
        public String name;

        // 是否有人脸信息
        @NameInMap("hasFace")
        public Boolean hasFace;

        public static GetMachineUserResponseBodyResultUserList build(java.util.Map<String, ?> map) throws Exception {
            GetMachineUserResponseBodyResultUserList self = new GetMachineUserResponseBodyResultUserList();
            return TeaModel.build(map, self);
        }

        public GetMachineUserResponseBodyResultUserList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public GetMachineUserResponseBodyResultUserList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetMachineUserResponseBodyResultUserList setHasFace(Boolean hasFace) {
            this.hasFace = hasFace;
            return this;
        }
        public Boolean getHasFace() {
            return this.hasFace;
        }

    }

    public static class GetMachineUserResponseBodyResult extends TeaModel {
        // 人员列表
        @NameInMap("userList")
        public java.util.List<GetMachineUserResponseBodyResultUserList> userList;

        // 更多
        @NameInMap("hasMore")
        public Boolean hasMore;

        public static GetMachineUserResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetMachineUserResponseBodyResult self = new GetMachineUserResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetMachineUserResponseBodyResult setUserList(java.util.List<GetMachineUserResponseBodyResultUserList> userList) {
            this.userList = userList;
            return this;
        }
        public java.util.List<GetMachineUserResponseBodyResultUserList> getUserList() {
            return this.userList;
        }

        public GetMachineUserResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

    }

}
