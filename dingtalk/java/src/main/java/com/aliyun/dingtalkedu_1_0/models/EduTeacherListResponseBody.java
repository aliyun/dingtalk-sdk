// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EduTeacherListResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public EduTeacherListResponseBodyResult result;

    public static EduTeacherListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EduTeacherListResponseBody self = new EduTeacherListResponseBody();
        return TeaModel.build(map, self);
    }

    public EduTeacherListResponseBody setResult(EduTeacherListResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public EduTeacherListResponseBodyResult getResult() {
        return this.result;
    }

    public static class EduTeacherListResponseBodyResultTeacherDetails extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>teacher</p>
         */
        @NameInMap("role")
        public String role;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>人员的unionId。</p>
         */
        @NameInMap("unionId")
        public String unionId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>77621233</p>
         */
        @NameInMap("userId")
        public String userId;

        public static EduTeacherListResponseBodyResultTeacherDetails build(java.util.Map<String, ?> map) throws Exception {
            EduTeacherListResponseBodyResultTeacherDetails self = new EduTeacherListResponseBodyResultTeacherDetails();
            return TeaModel.build(map, self);
        }

        public EduTeacherListResponseBodyResultTeacherDetails setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public EduTeacherListResponseBodyResultTeacherDetails setRole(String role) {
            this.role = role;
            return this;
        }
        public String getRole() {
            return this.role;
        }

        public EduTeacherListResponseBodyResultTeacherDetails setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public EduTeacherListResponseBodyResultTeacherDetails setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class EduTeacherListResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("teacherDetails")
        public java.util.List<EduTeacherListResponseBodyResultTeacherDetails> teacherDetails;

        public static EduTeacherListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            EduTeacherListResponseBodyResult self = new EduTeacherListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public EduTeacherListResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public EduTeacherListResponseBodyResult setTeacherDetails(java.util.List<EduTeacherListResponseBodyResultTeacherDetails> teacherDetails) {
            this.teacherDetails = teacherDetails;
            return this;
        }
        public java.util.List<EduTeacherListResponseBodyResultTeacherDetails> getTeacherDetails() {
            return this.teacherDetails;
        }

    }

}
