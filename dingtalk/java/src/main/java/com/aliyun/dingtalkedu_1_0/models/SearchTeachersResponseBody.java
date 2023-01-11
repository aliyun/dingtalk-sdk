// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SearchTeachersResponseBody extends TeaModel {
    @NameInMap("users")
    public java.util.List<SearchTeachersResponseBodyUsers> users;

    public static SearchTeachersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchTeachersResponseBody self = new SearchTeachersResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchTeachersResponseBody setUsers(java.util.List<SearchTeachersResponseBodyUsers> users) {
        this.users = users;
        return this;
    }
    public java.util.List<SearchTeachersResponseBodyUsers> getUsers() {
        return this.users;
    }

    public static class SearchTeachersResponseBodyUsers extends TeaModel {
        /**
         * <p>所在其中一个班级ID</p>
         */
        @NameInMap("classId")
        public Long classId;

        /**
         * <p>所在其中一个班级名称</p>
         */
        @NameInMap("deptName")
        public String deptName;

        /**
         * <p>名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>用户ID</p>
         */
        @NameInMap("userId")
        public String userId;

        public static SearchTeachersResponseBodyUsers build(java.util.Map<String, ?> map) throws Exception {
            SearchTeachersResponseBodyUsers self = new SearchTeachersResponseBodyUsers();
            return TeaModel.build(map, self);
        }

        public SearchTeachersResponseBodyUsers setClassId(Long classId) {
            this.classId = classId;
            return this;
        }
        public Long getClassId() {
            return this.classId;
        }

        public SearchTeachersResponseBodyUsers setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public SearchTeachersResponseBodyUsers setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchTeachersResponseBodyUsers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
