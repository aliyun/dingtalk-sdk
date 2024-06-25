// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllDoctorsResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<QueryAllDoctorsResponseBodyContent> content;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("currentPage")
    public Integer currentPage;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>32</p>
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1758</p>
         */
        @NameInMap("assessGroupId")
        public String assessGroupId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>张三组</p>
         */
        @NameInMap("assessGroupName")
        public String assessGroupName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1312312321</p>
         */
        @NameInMap("deptCode")
        public String deptCode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>3</p>
         */
        @NameInMap("deptType")
        public String deptType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-06-08 21:57:10</p>
         */
        @NameInMap("gmtCreateStr")
        public String gmtCreateStr;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-06-08 21:57:10</p>
         */
        @NameInMap("gmtModifiedStr")
        public String gmtModifiedStr;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>123345</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0001</p>
         */
        @NameInMap("jobNum")
        public String jobNum;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("status")
        public Integer status;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>u0398812938821</p>
         */
        @NameInMap("uid")
        public String uid;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>aaa12312312</p>
         */
        @NameInMap("userCode")
        public String userCode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
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
