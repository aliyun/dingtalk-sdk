// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListAuditLogResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<ListAuditLogResponseBodyList> list;

    public static ListAuditLogResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListAuditLogResponseBody self = new ListAuditLogResponseBody();
        return TeaModel.build(map, self);
    }

    public ListAuditLogResponseBody setList(java.util.List<ListAuditLogResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<ListAuditLogResponseBodyList> getList() {
        return this.list;
    }

    public static class ListAuditLogResponseBodyListDocMemberList extends TeaModel {
        @NameInMap("memberName")
        public String memberName;

        @NameInMap("memberType")
        public Integer memberType;

        @NameInMap("memberTypeView")
        public String memberTypeView;

        @NameInMap("permissionRole")
        public Long permissionRole;

        @NameInMap("permissionRoleView")
        public String permissionRoleView;

        public static ListAuditLogResponseBodyListDocMemberList build(java.util.Map<String, ?> map) throws Exception {
            ListAuditLogResponseBodyListDocMemberList self = new ListAuditLogResponseBodyListDocMemberList();
            return TeaModel.build(map, self);
        }

        public ListAuditLogResponseBodyListDocMemberList setMemberName(String memberName) {
            this.memberName = memberName;
            return this;
        }
        public String getMemberName() {
            return this.memberName;
        }

        public ListAuditLogResponseBodyListDocMemberList setMemberType(Integer memberType) {
            this.memberType = memberType;
            return this;
        }
        public Integer getMemberType() {
            return this.memberType;
        }

        public ListAuditLogResponseBodyListDocMemberList setMemberTypeView(String memberTypeView) {
            this.memberTypeView = memberTypeView;
            return this;
        }
        public String getMemberTypeView() {
            return this.memberTypeView;
        }

        public ListAuditLogResponseBodyListDocMemberList setPermissionRole(Long permissionRole) {
            this.permissionRole = permissionRole;
            return this;
        }
        public Long getPermissionRole() {
            return this.permissionRole;
        }

        public ListAuditLogResponseBodyListDocMemberList setPermissionRoleView(String permissionRoleView) {
            this.permissionRoleView = permissionRoleView;
            return this;
        }
        public String getPermissionRoleView() {
            return this.permissionRoleView;
        }

    }

    public static class ListAuditLogResponseBodyListDocReceiverList extends TeaModel {
        @NameInMap("receiverName")
        public String receiverName;

        @NameInMap("receiverType")
        public Integer receiverType;

        @NameInMap("receiverTypeView")
        public String receiverTypeView;

        public static ListAuditLogResponseBodyListDocReceiverList build(java.util.Map<String, ?> map) throws Exception {
            ListAuditLogResponseBodyListDocReceiverList self = new ListAuditLogResponseBodyListDocReceiverList();
            return TeaModel.build(map, self);
        }

        public ListAuditLogResponseBodyListDocReceiverList setReceiverName(String receiverName) {
            this.receiverName = receiverName;
            return this;
        }
        public String getReceiverName() {
            return this.receiverName;
        }

        public ListAuditLogResponseBodyListDocReceiverList setReceiverType(Integer receiverType) {
            this.receiverType = receiverType;
            return this;
        }
        public Integer getReceiverType() {
            return this.receiverType;
        }

        public ListAuditLogResponseBodyListDocReceiverList setReceiverTypeView(String receiverTypeView) {
            this.receiverTypeView = receiverTypeView;
            return this;
        }
        public String getReceiverTypeView() {
            return this.receiverTypeView;
        }

    }

    public static class ListAuditLogResponseBodyList extends TeaModel {
        @NameInMap("action")
        public Integer action;

        @NameInMap("actionView")
        public String actionView;

        @NameInMap("bizId")
        public String bizId;

        @NameInMap("docMemberList")
        public java.util.List<ListAuditLogResponseBodyListDocMemberList> docMemberList;

        @NameInMap("docMobileUrl")
        public String docMobileUrl;

        @NameInMap("docPcUrl")
        public String docPcUrl;

        @NameInMap("docReceiverList")
        public java.util.List<ListAuditLogResponseBodyListDocReceiverList> docReceiverList;

        @NameInMap("gmtCreate")
        public Long gmtCreate;

        @NameInMap("gmtModified")
        public Long gmtModified;

        @NameInMap("ipAddress")
        public String ipAddress;

        @NameInMap("operateModule")
        public Long operateModule;

        @NameInMap("operateModuleView")
        public String operateModuleView;

        @NameInMap("operatorName")
        public String operatorName;

        @NameInMap("orgName")
        public String orgName;

        @NameInMap("platform")
        public Integer platform;

        @NameInMap("platformView")
        public String platformView;

        @NameInMap("realName")
        public String realName;

        @NameInMap("receiverName")
        public String receiverName;

        @NameInMap("receiverType")
        public Integer receiverType;

        @NameInMap("receiverTypeView")
        public String receiverTypeView;

        @NameInMap("resource")
        public String resource;

        @NameInMap("resourceExtension")
        public String resourceExtension;

        @NameInMap("resourceSize")
        public Long resourceSize;

        @NameInMap("status")
        public Integer status;

        @NameInMap("targetSpaceId")
        public Long targetSpaceId;

        @NameInMap("userId")
        public String userId;

        @NameInMap("workSpaceId")
        public Long workSpaceId;

        @NameInMap("workSpaceMobileUrl")
        public String workSpaceMobileUrl;

        @NameInMap("workSpaceName")
        public String workSpaceName;

        @NameInMap("workSpacePcUrl")
        public String workSpacePcUrl;

        public static ListAuditLogResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            ListAuditLogResponseBodyList self = new ListAuditLogResponseBodyList();
            return TeaModel.build(map, self);
        }

        public ListAuditLogResponseBodyList setAction(Integer action) {
            this.action = action;
            return this;
        }
        public Integer getAction() {
            return this.action;
        }

        public ListAuditLogResponseBodyList setActionView(String actionView) {
            this.actionView = actionView;
            return this;
        }
        public String getActionView() {
            return this.actionView;
        }

        public ListAuditLogResponseBodyList setBizId(String bizId) {
            this.bizId = bizId;
            return this;
        }
        public String getBizId() {
            return this.bizId;
        }

        public ListAuditLogResponseBodyList setDocMemberList(java.util.List<ListAuditLogResponseBodyListDocMemberList> docMemberList) {
            this.docMemberList = docMemberList;
            return this;
        }
        public java.util.List<ListAuditLogResponseBodyListDocMemberList> getDocMemberList() {
            return this.docMemberList;
        }

        public ListAuditLogResponseBodyList setDocMobileUrl(String docMobileUrl) {
            this.docMobileUrl = docMobileUrl;
            return this;
        }
        public String getDocMobileUrl() {
            return this.docMobileUrl;
        }

        public ListAuditLogResponseBodyList setDocPcUrl(String docPcUrl) {
            this.docPcUrl = docPcUrl;
            return this;
        }
        public String getDocPcUrl() {
            return this.docPcUrl;
        }

        public ListAuditLogResponseBodyList setDocReceiverList(java.util.List<ListAuditLogResponseBodyListDocReceiverList> docReceiverList) {
            this.docReceiverList = docReceiverList;
            return this;
        }
        public java.util.List<ListAuditLogResponseBodyListDocReceiverList> getDocReceiverList() {
            return this.docReceiverList;
        }

        public ListAuditLogResponseBodyList setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public ListAuditLogResponseBodyList setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public ListAuditLogResponseBodyList setIpAddress(String ipAddress) {
            this.ipAddress = ipAddress;
            return this;
        }
        public String getIpAddress() {
            return this.ipAddress;
        }

        public ListAuditLogResponseBodyList setOperateModule(Long operateModule) {
            this.operateModule = operateModule;
            return this;
        }
        public Long getOperateModule() {
            return this.operateModule;
        }

        public ListAuditLogResponseBodyList setOperateModuleView(String operateModuleView) {
            this.operateModuleView = operateModuleView;
            return this;
        }
        public String getOperateModuleView() {
            return this.operateModuleView;
        }

        public ListAuditLogResponseBodyList setOperatorName(String operatorName) {
            this.operatorName = operatorName;
            return this;
        }
        public String getOperatorName() {
            return this.operatorName;
        }

        public ListAuditLogResponseBodyList setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

        public ListAuditLogResponseBodyList setPlatform(Integer platform) {
            this.platform = platform;
            return this;
        }
        public Integer getPlatform() {
            return this.platform;
        }

        public ListAuditLogResponseBodyList setPlatformView(String platformView) {
            this.platformView = platformView;
            return this;
        }
        public String getPlatformView() {
            return this.platformView;
        }

        public ListAuditLogResponseBodyList setRealName(String realName) {
            this.realName = realName;
            return this;
        }
        public String getRealName() {
            return this.realName;
        }

        public ListAuditLogResponseBodyList setReceiverName(String receiverName) {
            this.receiverName = receiverName;
            return this;
        }
        public String getReceiverName() {
            return this.receiverName;
        }

        public ListAuditLogResponseBodyList setReceiverType(Integer receiverType) {
            this.receiverType = receiverType;
            return this;
        }
        public Integer getReceiverType() {
            return this.receiverType;
        }

        public ListAuditLogResponseBodyList setReceiverTypeView(String receiverTypeView) {
            this.receiverTypeView = receiverTypeView;
            return this;
        }
        public String getReceiverTypeView() {
            return this.receiverTypeView;
        }

        public ListAuditLogResponseBodyList setResource(String resource) {
            this.resource = resource;
            return this;
        }
        public String getResource() {
            return this.resource;
        }

        public ListAuditLogResponseBodyList setResourceExtension(String resourceExtension) {
            this.resourceExtension = resourceExtension;
            return this;
        }
        public String getResourceExtension() {
            return this.resourceExtension;
        }

        public ListAuditLogResponseBodyList setResourceSize(Long resourceSize) {
            this.resourceSize = resourceSize;
            return this;
        }
        public Long getResourceSize() {
            return this.resourceSize;
        }

        public ListAuditLogResponseBodyList setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public ListAuditLogResponseBodyList setTargetSpaceId(Long targetSpaceId) {
            this.targetSpaceId = targetSpaceId;
            return this;
        }
        public Long getTargetSpaceId() {
            return this.targetSpaceId;
        }

        public ListAuditLogResponseBodyList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public ListAuditLogResponseBodyList setWorkSpaceId(Long workSpaceId) {
            this.workSpaceId = workSpaceId;
            return this;
        }
        public Long getWorkSpaceId() {
            return this.workSpaceId;
        }

        public ListAuditLogResponseBodyList setWorkSpaceMobileUrl(String workSpaceMobileUrl) {
            this.workSpaceMobileUrl = workSpaceMobileUrl;
            return this;
        }
        public String getWorkSpaceMobileUrl() {
            return this.workSpaceMobileUrl;
        }

        public ListAuditLogResponseBodyList setWorkSpaceName(String workSpaceName) {
            this.workSpaceName = workSpaceName;
            return this;
        }
        public String getWorkSpaceName() {
            return this.workSpaceName;
        }

        public ListAuditLogResponseBodyList setWorkSpacePcUrl(String workSpacePcUrl) {
            this.workSpacePcUrl = workSpacePcUrl;
            return this;
        }
        public String getWorkSpacePcUrl() {
            return this.workSpacePcUrl;
        }

    }

}
