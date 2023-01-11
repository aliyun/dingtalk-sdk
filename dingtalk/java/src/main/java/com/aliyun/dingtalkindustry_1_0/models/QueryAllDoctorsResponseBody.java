// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllDoctorsResponseBody extends TeaModel {
    /**
     * <p>人员列表</p>
     */
    @NameInMap("content")
    public java.util.List<QueryAllDoctorsResponseBodyContent> content;

    /**
     * <p>当前页码</p>
     */
    @NameInMap("currentPage")
    public Integer currentPage;

    /**
     * <p>数据总量</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    /**
     * <p>总页数</p>
     */
    @NameInMap("totalPages")
    public Integer totalPages;

    public static QueryAllDoctorsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAllDoctorsResponseBody self = new QueryAllDoctorsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAllDoctorsResponseBody setContent(java.util.List<QueryAllDoctorsResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryAllDoctorsResponseBodyContent> getContent() {
        return this.content;
    }

    public QueryAllDoctorsResponseBody setCurrentPage(Integer currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Integer getCurrentPage() {
        return this.currentPage;
    }

    public QueryAllDoctorsResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public QueryAllDoctorsResponseBody setTotalPages(Integer totalPages) {
        this.totalPages = totalPages;
        return this;
    }
    public Integer getTotalPages() {
        return this.totalPages;
    }

    public static class QueryAllDoctorsResponseBodyContent extends TeaModel {
        /**
         * <p>考核医疗组id</p>
         */
        @NameInMap("assessGroupId")
        public String assessGroupId;

        /**
         * <p>考核医疗组名称</p>
         */
        @NameInMap("assessGroupName")
        public String assessGroupName;

        /**
         * <p>关联的部门id</p>
         */
        @NameInMap("deptCode")
        public String deptCode;

        /**
         * <p>科室医疗组标识</p>
         */
        @NameInMap("deptType")
        public String deptType;

        /**
         * <p>用户创建时间</p>
         */
        @NameInMap("gmtCreateStr")
        public String gmtCreateStr;

        /**
         * <p>用户最后修改时间</p>
         */
        @NameInMap("gmtModifiedStr")
        public String gmtModifiedStr;

        /**
         * <p>用户id</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <p>工号</p>
         */
        @NameInMap("jobNum")
        public String jobNum;

        /**
         * <p>状态0-有效，1-删除</p>
         */
        @NameInMap("status")
        public Integer status;

        /**
         * <p>租户下staffId</p>
         */
        @NameInMap("uid")
        public String uid;

        /**
         * <p>租户内staffId</p>
         */
        @NameInMap("userCode")
        public String userCode;

        /**
         * <p>用户名称</p>
         */
        @NameInMap("userName")
        public String userName;

        public static QueryAllDoctorsResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryAllDoctorsResponseBodyContent self = new QueryAllDoctorsResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryAllDoctorsResponseBodyContent setAssessGroupId(String assessGroupId) {
            this.assessGroupId = assessGroupId;
            return this;
        }
        public String getAssessGroupId() {
            return this.assessGroupId;
        }

        public QueryAllDoctorsResponseBodyContent setAssessGroupName(String assessGroupName) {
            this.assessGroupName = assessGroupName;
            return this;
        }
        public String getAssessGroupName() {
            return this.assessGroupName;
        }

        public QueryAllDoctorsResponseBodyContent setDeptCode(String deptCode) {
            this.deptCode = deptCode;
            return this;
        }
        public String getDeptCode() {
            return this.deptCode;
        }

        public QueryAllDoctorsResponseBodyContent setDeptType(String deptType) {
            this.deptType = deptType;
            return this;
        }
        public String getDeptType() {
            return this.deptType;
        }

        public QueryAllDoctorsResponseBodyContent setGmtCreateStr(String gmtCreateStr) {
            this.gmtCreateStr = gmtCreateStr;
            return this;
        }
        public String getGmtCreateStr() {
            return this.gmtCreateStr;
        }

        public QueryAllDoctorsResponseBodyContent setGmtModifiedStr(String gmtModifiedStr) {
            this.gmtModifiedStr = gmtModifiedStr;
            return this;
        }
        public String getGmtModifiedStr() {
            return this.gmtModifiedStr;
        }

        public QueryAllDoctorsResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryAllDoctorsResponseBodyContent setJobNum(String jobNum) {
            this.jobNum = jobNum;
            return this;
        }
        public String getJobNum() {
            return this.jobNum;
        }

        public QueryAllDoctorsResponseBodyContent setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public QueryAllDoctorsResponseBodyContent setUid(String uid) {
            this.uid = uid;
            return this;
        }
        public String getUid() {
            return this.uid;
        }

        public QueryAllDoctorsResponseBodyContent setUserCode(String userCode) {
            this.userCode = userCode;
            return this;
        }
        public String getUserCode() {
            return this.userCode;
        }

        public QueryAllDoctorsResponseBodyContent setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

}
