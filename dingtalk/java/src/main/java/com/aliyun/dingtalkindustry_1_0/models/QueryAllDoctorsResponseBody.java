// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllDoctorsResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<QueryAllDoctorsResponseBodyContent> content;

    @NameInMap("currentPage")
    public Integer currentPage;

    @NameInMap("totalCount")
    public Long totalCount;

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
        @NameInMap("assessGroupId")
        public String assessGroupId;

        @NameInMap("assessGroupName")
        public String assessGroupName;

        @NameInMap("deptCode")
        public String deptCode;

        @NameInMap("deptType")
        public String deptType;

        @NameInMap("gmtCreateStr")
        public String gmtCreateStr;

        @NameInMap("gmtModifiedStr")
        public String gmtModifiedStr;

        @NameInMap("id")
        public Long id;

        @NameInMap("jobNum")
        public String jobNum;

        @NameInMap("status")
        public Integer status;

        @NameInMap("uid")
        public String uid;

        @NameInMap("userCode")
        public String userCode;

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
