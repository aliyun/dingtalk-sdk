// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllDepartmentResponseBody extends TeaModel {
    // 科室列表
    @NameInMap("content")
    public java.util.List<QueryAllDepartmentResponseBodyContent> content;

    // 当前页码
    @NameInMap("currentPage")
    public Integer currentPage;

    // 数据总量
    @NameInMap("totalCount")
    public Long totalCount;

    // 总页数
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
        // 租户CorpID
        @NameInMap("corpId")
        public String corpId;

        // 部门code
        @NameInMap("deptCode")
        public String deptCode;

        // 科室名称，同name
        @NameInMap("deptName")
        public String deptName;

        // 排序
        @NameInMap("deptOrder")
        public Long deptOrder;

        // 部门状态：0-正常，1-删除
        @NameInMap("deptStatus")
        public Integer deptStatus;

        // 部门类型：1-科室，2-医疗组
        @NameInMap("deptType")
        public Integer deptType;

        // 创建时间
        @NameInMap("gmtCreateStr")
        public String gmtCreateStr;

        // 修改时间
        @NameInMap("gmtModifiedStr")
        public String gmtModifiedStr;

        // 科室ID
        @NameInMap("id")
        public Long id;

        // 科室名称，同deptName
        @NameInMap("name")
        public String name;

        // 父部门code（与dept_code来源保持一致）
        @NameInMap("parentDeptCode")
        public String parentDeptCode;

        // 备注
        @NameInMap("remark")
        public String remark;

        // 病区id列表
        @NameInMap("wardIdList")
        public java.util.List<Long> wardIdList;

        public static QueryAllDepartmentResponseBodyContentDeptAndExtDepartment build(java.util.Map<String, ?> map) throws Exception {
            QueryAllDepartmentResponseBodyContentDeptAndExtDepartment self = new QueryAllDepartmentResponseBodyContentDeptAndExtDepartment();
            return TeaModel.build(map, self);
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtDepartment setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
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
        // 租户CorpID
        @NameInMap("corpId")
        public String corpId;

        // 部门code
        @NameInMap("deptCode")
        public String deptCode;

        // 科室扩展字段描述
        @NameInMap("deptExtendDisplayName")
        public String deptExtendDisplayName;

        // 科室扩展字段key
        @NameInMap("deptExtendKey")
        public String deptExtendKey;

        // 科室扩展字段value
        @NameInMap("deptExtendValue")
        public String deptExtendValue;

        // 创建时间
        @NameInMap("gmtCreateStr")
        public String gmtCreateStr;

        // 修改时间
        @NameInMap("gmtModifiedStr")
        public String gmtModifiedStr;

        // 扩展信息id
        @NameInMap("id")
        public Long id;

        // 0-有效 ，1-无效
        @NameInMap("status")
        public Integer status;

        public static QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos build(java.util.Map<String, ?> map) throws Exception {
            QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos self = new QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos();
            return TeaModel.build(map, self);
        }

        public QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
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
        // 科室详情
        @NameInMap("department")
        public QueryAllDepartmentResponseBodyContentDeptAndExtDepartment department;

        // 科室扩展信息列表
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
        // 租户CorpID
        @NameInMap("corpId")
        public String corpId;

        // 部门code
        @NameInMap("deptCode")
        public String deptCode;

        // 医疗组扩展字段描述
        @NameInMap("deptExtendDisplayName")
        public String deptExtendDisplayName;

        // 医疗组扩展字段key
        @NameInMap("deptExtendKey")
        public String deptExtendKey;

        // 医疗组扩展字段value
        @NameInMap("deptExtendValue")
        public String deptExtendValue;

        // 创建时间
        @NameInMap("gmtCreateStr")
        public String gmtCreateStr;

        // 修改时间
        @NameInMap("gmtModifiedStr")
        public String gmtModifiedStr;

        // 扩展信息id
        @NameInMap("id")
        public Long id;

        // 0-有效 ，1-无效
        @NameInMap("status")
        public Integer status;

        public static QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos build(java.util.Map<String, ?> map) throws Exception {
            QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos self = new QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos();
            return TeaModel.build(map, self);
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
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
        // 用户工号
        @NameInMap("jobNumber")
        public String jobNumber;

        // 姓名
        @NameInMap("name")
        public String name;

        // 用户ID
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
        // 租户CorpID
        @NameInMap("corpId")
        public String corpId;

        // 科室ID，同parentDeptCode，这里保留是做兼容，原来定义成Long不太好改成了String了
        @NameInMap("deptId")
        public Long deptId;

        // 部门状态：0-正常，1-删除
        @NameInMap("deptStatus")
        public Integer deptStatus;

        // 创建时间
        @NameInMap("gmtCreateStr")
        public String gmtCreateStr;

        // 修改时间
        @NameInMap("gmtModifiedStr")
        public String gmtModifiedStr;

        // 医疗组ID
        @NameInMap("id")
        public Long id;

        // 医疗组组长信息
        @NameInMap("leader")
        public QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader leader;

        // 医疗组名称
        @NameInMap("name")
        public String name;

        // 父级组织id，这里医疗组的父级就是科室
        @NameInMap("parentDeptCode")
        public String parentDeptCode;

        // 备注
        @NameInMap("remark")
        public String remark;

        public static QueryAllDepartmentResponseBodyContentGroupAndExtListGroup build(java.util.Map<String, ?> map) throws Exception {
            QueryAllDepartmentResponseBodyContentGroupAndExtListGroup self = new QueryAllDepartmentResponseBodyContentGroupAndExtListGroup();
            return TeaModel.build(map, self);
        }

        public QueryAllDepartmentResponseBodyContentGroupAndExtListGroup setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
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
        // 医疗组扩展信息列表
        @NameInMap("extendInfos")
        public java.util.List<QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos> extendInfos;

        // 医疗组详细信息
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
        // 科室详情
        @NameInMap("deptAndExt")
        public QueryAllDepartmentResponseBodyContentDeptAndExt deptAndExt;

        // 医疗组列表
        @NameInMap("groupAndExtList")
        public java.util.List<QueryAllDepartmentResponseBodyContentGroupAndExtList> groupAndExtList;

        // 科室ID
        @NameInMap("id")
        public Long id;

        // 科室名称
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
