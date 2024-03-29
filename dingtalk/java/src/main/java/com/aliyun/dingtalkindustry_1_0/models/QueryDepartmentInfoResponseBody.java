// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryDepartmentInfoResponseBody extends TeaModel {
    @NameInMap("content")
    public QueryDepartmentInfoResponseBodyContent content;

    public static QueryDepartmentInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDepartmentInfoResponseBody self = new QueryDepartmentInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDepartmentInfoResponseBody setContent(QueryDepartmentInfoResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public QueryDepartmentInfoResponseBodyContent getContent() {
        return this.content;
    }

    public static class QueryDepartmentInfoResponseBodyContentDepartment extends TeaModel {
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

        public static QueryDepartmentInfoResponseBodyContentDepartment build(java.util.Map<String, ?> map) throws Exception {
            QueryDepartmentInfoResponseBodyContentDepartment self = new QueryDepartmentInfoResponseBodyContentDepartment();
            return TeaModel.build(map, self);
        }

        public QueryDepartmentInfoResponseBodyContentDepartment setDeptCode(String deptCode) {
            this.deptCode = deptCode;
            return this;
        }
        public String getDeptCode() {
            return this.deptCode;
        }

        public QueryDepartmentInfoResponseBodyContentDepartment setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public QueryDepartmentInfoResponseBodyContentDepartment setDeptOrder(Long deptOrder) {
            this.deptOrder = deptOrder;
            return this;
        }
        public Long getDeptOrder() {
            return this.deptOrder;
        }

        public QueryDepartmentInfoResponseBodyContentDepartment setDeptStatus(Integer deptStatus) {
            this.deptStatus = deptStatus;
            return this;
        }
        public Integer getDeptStatus() {
            return this.deptStatus;
        }

        public QueryDepartmentInfoResponseBodyContentDepartment setDeptType(Integer deptType) {
            this.deptType = deptType;
            return this;
        }
        public Integer getDeptType() {
            return this.deptType;
        }

        public QueryDepartmentInfoResponseBodyContentDepartment setGmtCreateStr(String gmtCreateStr) {
            this.gmtCreateStr = gmtCreateStr;
            return this;
        }
        public String getGmtCreateStr() {
            return this.gmtCreateStr;
        }

        public QueryDepartmentInfoResponseBodyContentDepartment setGmtModifiedStr(String gmtModifiedStr) {
            this.gmtModifiedStr = gmtModifiedStr;
            return this;
        }
        public String getGmtModifiedStr() {
            return this.gmtModifiedStr;
        }

        public QueryDepartmentInfoResponseBodyContentDepartment setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryDepartmentInfoResponseBodyContentDepartment setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryDepartmentInfoResponseBodyContentDepartment setParentDeptCode(String parentDeptCode) {
            this.parentDeptCode = parentDeptCode;
            return this;
        }
        public String getParentDeptCode() {
            return this.parentDeptCode;
        }

        public QueryDepartmentInfoResponseBodyContentDepartment setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public QueryDepartmentInfoResponseBodyContentDepartment setWardIdList(java.util.List<Long> wardIdList) {
            this.wardIdList = wardIdList;
            return this;
        }
        public java.util.List<Long> getWardIdList() {
            return this.wardIdList;
        }

    }

    public static class QueryDepartmentInfoResponseBodyContentExtendInfos extends TeaModel {
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

        public static QueryDepartmentInfoResponseBodyContentExtendInfos build(java.util.Map<String, ?> map) throws Exception {
            QueryDepartmentInfoResponseBodyContentExtendInfos self = new QueryDepartmentInfoResponseBodyContentExtendInfos();
            return TeaModel.build(map, self);
        }

        public QueryDepartmentInfoResponseBodyContentExtendInfos setDeptCode(String deptCode) {
            this.deptCode = deptCode;
            return this;
        }
        public String getDeptCode() {
            return this.deptCode;
        }

        public QueryDepartmentInfoResponseBodyContentExtendInfos setDeptExtendDisplayName(String deptExtendDisplayName) {
            this.deptExtendDisplayName = deptExtendDisplayName;
            return this;
        }
        public String getDeptExtendDisplayName() {
            return this.deptExtendDisplayName;
        }

        public QueryDepartmentInfoResponseBodyContentExtendInfos setDeptExtendKey(String deptExtendKey) {
            this.deptExtendKey = deptExtendKey;
            return this;
        }
        public String getDeptExtendKey() {
            return this.deptExtendKey;
        }

        public QueryDepartmentInfoResponseBodyContentExtendInfos setDeptExtendValue(String deptExtendValue) {
            this.deptExtendValue = deptExtendValue;
            return this;
        }
        public String getDeptExtendValue() {
            return this.deptExtendValue;
        }

        public QueryDepartmentInfoResponseBodyContentExtendInfos setGmtCreateStr(String gmtCreateStr) {
            this.gmtCreateStr = gmtCreateStr;
            return this;
        }
        public String getGmtCreateStr() {
            return this.gmtCreateStr;
        }

        public QueryDepartmentInfoResponseBodyContentExtendInfos setGmtModifiedStr(String gmtModifiedStr) {
            this.gmtModifiedStr = gmtModifiedStr;
            return this;
        }
        public String getGmtModifiedStr() {
            return this.gmtModifiedStr;
        }

        public QueryDepartmentInfoResponseBodyContentExtendInfos setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryDepartmentInfoResponseBodyContentExtendInfos setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

    }

    public static class QueryDepartmentInfoResponseBodyContent extends TeaModel {
        @NameInMap("department")
        public QueryDepartmentInfoResponseBodyContentDepartment department;

        @NameInMap("extendInfos")
        public java.util.List<QueryDepartmentInfoResponseBodyContentExtendInfos> extendInfos;

        public static QueryDepartmentInfoResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryDepartmentInfoResponseBodyContent self = new QueryDepartmentInfoResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryDepartmentInfoResponseBodyContent setDepartment(QueryDepartmentInfoResponseBodyContentDepartment department) {
            this.department = department;
            return this;
        }
        public QueryDepartmentInfoResponseBodyContentDepartment getDepartment() {
            return this.department;
        }

        public QueryDepartmentInfoResponseBodyContent setExtendInfos(java.util.List<QueryDepartmentInfoResponseBodyContentExtendInfos> extendInfos) {
            this.extendInfos = extendInfos;
            return this;
        }
        public java.util.List<QueryDepartmentInfoResponseBodyContentExtendInfos> getExtendInfos() {
            return this.extendInfos;
        }

    }

}
