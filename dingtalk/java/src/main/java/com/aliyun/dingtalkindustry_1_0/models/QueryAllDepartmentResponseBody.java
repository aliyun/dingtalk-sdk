// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllDepartmentResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<QueryAllDepartmentResponseBodyContent> content;

    @NameInMap("currentPage")
    public Integer currentPage;

    @NameInMap("totalCount")
    public Long totalCount;

    @NameInMap("totalPages")
    public Integer totalPages;

    public static QueryAllDepartmentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAllDepartmentResponseBody self = new QueryAllDepartmentResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAllDepartmentResponseBody setContent(java.util.List<QueryAllDepartmentResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryAllDepartmentResponseBodyContent> getContent() {
        return this.content;
    }

    public QueryAllDepartmentResponseBody setCurrentPage(Integer currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Integer getCurrentPage() {
        return this.currentPage;
    }

    public QueryAllDepartmentResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public QueryAllDepartmentResponseBody setTotalPages(Integer totalPages) {
        this.totalPages = totalPages;
        return this;
    }
    public Integer getTotalPages() {
        return this.totalPages;
    }

    public static class QueryAllDepartmentResponseBodyContentDeptAndExtDepartment extends TeaModel {
        @NameInMap("deptCode")
        public String deptCode;

        @NameInMap("deptName")
        public String deptName;

        @NameInMap("deptOrder")
        public Long deptOrder;

        @NameInMap("deptStatus")
        public Integer deptStatus;

        @NameInMap("deptType")
        public Integer deptType;

        @NameInMap("gmtCreateStr")
        public String gmtCreateStr;

        @NameInMap("gmtModifiedStr")
        public String gmtModifiedStr;

        @NameInMap("id")
        public Long id;

        @NameInMap("name")
        public String name;

        @NameInMap("parentDeptCode")
        public String parentDeptCode;

        @NameInMap("remark")
        public String remark;

        @NameInMap("wardIdList")
        public java.util.List<Long> wardIdList;

        public static QueryAllDepartmentResponseBodyContentDeptAndExtDepartment build(java.util.Map<String, ?> map) throws Exception {
            QueryAllDepartmentResponseBodyContentDeptAndExtDepartment self = new QueryAllDepartmentResponseBodyContentDeptAndExtDepartment();
            return TeaModel.build(map, self);
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtDepartment setDeptCode(String deptCode) {
            this.deptCode = deptCode;
            return this;
        }
        public String getDeptCode() {
            return this.deptCode;
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtDepartment setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtDepartment setDeptOrder(Long deptOrder) {
            this.deptOrder = deptOrder;
            return this;
        }
        public Long getDeptOrder() {
            return this.deptOrder;
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtDepartment setDeptStatus(Integer deptStatus) {
            this.deptStatus = deptStatus;
            return this;
        }
        public Integer getDeptStatus() {
            return this.deptStatus;
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtDepartment setDeptType(Integer deptType) {
            this.deptType = deptType;
            return this;
        }
        public Integer getDeptType() {
            return this.deptType;
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtDepartment setGmtCreateStr(String gmtCreateStr) {
            this.gmtCreateStr = gmtCreateStr;
            return this;
        }
        public String getGmtCreateStr() {
            return this.gmtCreateStr;
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtDepartment setGmtModifiedStr(String gmtModifiedStr) {
            this.gmtModifiedStr = gmtModifiedStr;
            return this;
        }
        public String getGmtModifiedStr() {
            return this.gmtModifiedStr;
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtDepartment setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtDepartment setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtDepartment setParentDeptCode(String parentDeptCode) {
            this.parentDeptCode = parentDeptCode;
            return this;
        }
        public String getParentDeptCode() {
            return this.parentDeptCode;
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtDepartment setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtDepartment setWardIdList(java.util.List<Long> wardIdList) {
            this.wardIdList = wardIdList;
            return this;
        }
        public java.util.List<Long> getWardIdList() {
            return this.wardIdList;
        }

    }

    public static class QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos extends TeaModel {
        @NameInMap("deptCode")
        public String deptCode;

        @NameInMap("deptExtendDisplayName")
        public String deptExtendDisplayName;

        @NameInMap("deptExtendKey")
        public String deptExtendKey;

        @NameInMap("deptExtendValue")
        public String deptExtendValue;

        @NameInMap("gmtCreateStr")
        public String gmtCreateStr;

        @NameInMap("gmtModifiedStr")
        public String gmtModifiedStr;

        @NameInMap("id")
        public Long id;

        @NameInMap("status")
        public Integer status;

        public static QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos build(java.util.Map<String, ?> map) throws Exception {
            QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos self = new QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos();
            return TeaModel.build(map, self);
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos setDeptCode(String deptCode) {
            this.deptCode = deptCode;
            return this;
        }
        public String getDeptCode() {
            return this.deptCode;
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos setDeptExtendDisplayName(String deptExtendDisplayName) {
            this.deptExtendDisplayName = deptExtendDisplayName;
            return this;
        }
        public String getDeptExtendDisplayName() {
            return this.deptExtendDisplayName;
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos setDeptExtendKey(String deptExtendKey) {
            this.deptExtendKey = deptExtendKey;
            return this;
        }
        public String getDeptExtendKey() {
            return this.deptExtendKey;
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos setDeptExtendValue(String deptExtendValue) {
            this.deptExtendValue = deptExtendValue;
            return this;
        }
        public String getDeptExtendValue() {
            return this.deptExtendValue;
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos setGmtCreateStr(String gmtCreateStr) {
            this.gmtCreateStr = gmtCreateStr;
            return this;
        }
        public String getGmtCreateStr() {
            return this.gmtCreateStr;
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos setGmtModifiedStr(String gmtModifiedStr) {
            this.gmtModifiedStr = gmtModifiedStr;
            return this;
        }
        public String getGmtModifiedStr() {
            return this.gmtModifiedStr;
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

    }

    public static class QueryAllDepartmentResponseBodyContentDeptAndExt extends TeaModel {
        @NameInMap("department")
        public QueryAllDepartmentResponseBodyContentDeptAndExtDepartment department;

        @NameInMap("extendInfos")
        public java.util.List<QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos> extendInfos;

        public static QueryAllDepartmentResponseBodyContentDeptAndExt build(java.util.Map<String, ?> map) throws Exception {
            QueryAllDepartmentResponseBodyContentDeptAndExt self = new QueryAllDepartmentResponseBodyContentDeptAndExt();
            return TeaModel.build(map, self);
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExt setDepartment(QueryAllDepartmentResponseBodyContentDeptAndExtDepartment department) {
            this.department = department;
            return this;
        }
        public QueryAllDepartmentResponseBodyContentDeptAndExtDepartment getDepartment() {
            return this.department;
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExt setExtendInfos(java.util.List<QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos> extendInfos) {
            this.extendInfos = extendInfos;
            return this;
        }
        public java.util.List<QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos> getExtendInfos() {
            return this.extendInfos;
        }

    }

    public static class QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos extends TeaModel {
        @NameInMap("deptCode")
        public String deptCode;

        @NameInMap("deptExtendDisplayName")
        public String deptExtendDisplayName;

        @NameInMap("deptExtendKey")
        public String deptExtendKey;

        @NameInMap("deptExtendValue")
        public String deptExtendValue;

        @NameInMap("gmtCreateStr")
        public String gmtCreateStr;

        @NameInMap("gmtModifiedStr")
        public String gmtModifiedStr;

        @NameInMap("id")
        public Long id;

        @NameInMap("status")
        public Integer status;

        public static QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos build(java.util.Map<String, ?> map) throws Exception {
            QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos self = new QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos();
            return TeaModel.build(map, self);
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos setDeptCode(String deptCode) {
            this.deptCode = deptCode;
            return this;
        }
        public String getDeptCode() {
            return this.deptCode;
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos setDeptExtendDisplayName(String deptExtendDisplayName) {
            this.deptExtendDisplayName = deptExtendDisplayName;
            return this;
        }
        public String getDeptExtendDisplayName() {
            return this.deptExtendDisplayName;
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos setDeptExtendKey(String deptExtendKey) {
            this.deptExtendKey = deptExtendKey;
            return this;
        }
        public String getDeptExtendKey() {
            return this.deptExtendKey;
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos setDeptExtendValue(String deptExtendValue) {
            this.deptExtendValue = deptExtendValue;
            return this;
        }
        public String getDeptExtendValue() {
            return this.deptExtendValue;
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos setGmtCreateStr(String gmtCreateStr) {
            this.gmtCreateStr = gmtCreateStr;
            return this;
        }
        public String getGmtCreateStr() {
            return this.gmtCreateStr;
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos setGmtModifiedStr(String gmtModifiedStr) {
            this.gmtModifiedStr = gmtModifiedStr;
            return this;
        }
        public String getGmtModifiedStr() {
            return this.gmtModifiedStr;
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

    }

    public static class QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader extends TeaModel {
        @NameInMap("jobNumber")
        public String jobNumber;

        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader build(java.util.Map<String, ?> map) throws Exception {
            QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader self = new QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader();
            return TeaModel.build(map, self);
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader setJobNumber(String jobNumber) {
            this.jobNumber = jobNumber;
            return this;
        }
        public String getJobNumber() {
            return this.jobNumber;
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryAllDepartmentResponseBodyContentGroupAndExtListGroup extends TeaModel {
        @NameInMap("deptId")
        public Long deptId;

        @NameInMap("deptStatus")
        public Integer deptStatus;

        @NameInMap("gmtCreateStr")
        public String gmtCreateStr;

        @NameInMap("gmtModifiedStr")
        public String gmtModifiedStr;

        @NameInMap("id")
        public Long id;

        @NameInMap("leader")
        public QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader leader;

        @NameInMap("name")
        public String name;

        @NameInMap("parentDeptCode")
        public String parentDeptCode;

        @NameInMap("remark")
        public String remark;

        public static QueryAllDepartmentResponseBodyContentGroupAndExtListGroup build(java.util.Map<String, ?> map) throws Exception {
            QueryAllDepartmentResponseBodyContentGroupAndExtListGroup self = new QueryAllDepartmentResponseBodyContentGroupAndExtListGroup();
            return TeaModel.build(map, self);
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListGroup setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListGroup setDeptStatus(Integer deptStatus) {
            this.deptStatus = deptStatus;
            return this;
        }
        public Integer getDeptStatus() {
            return this.deptStatus;
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListGroup setGmtCreateStr(String gmtCreateStr) {
            this.gmtCreateStr = gmtCreateStr;
            return this;
        }
        public String getGmtCreateStr() {
            return this.gmtCreateStr;
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListGroup setGmtModifiedStr(String gmtModifiedStr) {
            this.gmtModifiedStr = gmtModifiedStr;
            return this;
        }
        public String getGmtModifiedStr() {
            return this.gmtModifiedStr;
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListGroup setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListGroup setLeader(QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader leader) {
            this.leader = leader;
            return this;
        }
        public QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader getLeader() {
            return this.leader;
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListGroup setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListGroup setParentDeptCode(String parentDeptCode) {
            this.parentDeptCode = parentDeptCode;
            return this;
        }
        public String getParentDeptCode() {
            return this.parentDeptCode;
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListGroup setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

    }

    public static class QueryAllDepartmentResponseBodyContentGroupAndExtList extends TeaModel {
        @NameInMap("extendInfos")
        public java.util.List<QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos> extendInfos;

        @NameInMap("group")
        public QueryAllDepartmentResponseBodyContentGroupAndExtListGroup group;

        public static QueryAllDepartmentResponseBodyContentGroupAndExtList build(java.util.Map<String, ?> map) throws Exception {
            QueryAllDepartmentResponseBodyContentGroupAndExtList self = new QueryAllDepartmentResponseBodyContentGroupAndExtList();
            return TeaModel.build(map, self);
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtList setExtendInfos(java.util.List<QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos> extendInfos) {
            this.extendInfos = extendInfos;
            return this;
        }
        public java.util.List<QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos> getExtendInfos() {
            return this.extendInfos;
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtList setGroup(QueryAllDepartmentResponseBodyContentGroupAndExtListGroup group) {
            this.group = group;
            return this;
        }
        public QueryAllDepartmentResponseBodyContentGroupAndExtListGroup getGroup() {
            return this.group;
        }

    }

    public static class QueryAllDepartmentResponseBodyContent extends TeaModel {
        @NameInMap("deptAndExt")
        public QueryAllDepartmentResponseBodyContentDeptAndExt deptAndExt;

        @NameInMap("groupAndExtList")
        public java.util.List<QueryAllDepartmentResponseBodyContentGroupAndExtList> groupAndExtList;

        @NameInMap("id")
        public Long id;

        @NameInMap("name")
        public String name;

        public static QueryAllDepartmentResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryAllDepartmentResponseBodyContent self = new QueryAllDepartmentResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryAllDepartmentResponseBodyContent setDeptAndExt(QueryAllDepartmentResponseBodyContentDeptAndExt deptAndExt) {
            this.deptAndExt = deptAndExt;
            return this;
        }
        public QueryAllDepartmentResponseBodyContentDeptAndExt getDeptAndExt() {
            return this.deptAndExt;
        }

        public QueryAllDepartmentResponseBodyContent setGroupAndExtList(java.util.List<QueryAllDepartmentResponseBodyContentGroupAndExtList> groupAndExtList) {
            this.groupAndExtList = groupAndExtList;
            return this;
        }
        public java.util.List<QueryAllDepartmentResponseBodyContentGroupAndExtList> getGroupAndExtList() {
            return this.groupAndExtList;
        }

        public QueryAllDepartmentResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryAllDepartmentResponseBodyContent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
