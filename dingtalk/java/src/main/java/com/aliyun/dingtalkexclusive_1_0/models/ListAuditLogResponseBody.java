// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListAuditLogResponseBody extends TeaModel {
    // 记录列表
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
        // 成员名称
        @NameInMap("memberName")
        public String memberName;

        // 成员类型
        @NameInMap("memberType")
        public Integer memberType;

        // 成员类型翻译值
        @NameInMap("memberTypeView")
        public String memberTypeView;

        // 权限类型
        @NameInMap("permissionRole")
        public Long permissionRole;

        // 权限类型翻译值
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
        // 成员名称
        @NameInMap("receiverName")
        public String receiverName;

        // 成员类型
        @NameInMap("receiverType")
        public Integer receiverType;

        // 成员类型翻译值
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
        // 操作类型
        @NameInMap("action")
        public Integer action;

        // 操作类型翻译值
        @NameInMap("actionView")
        public String actionView;

        // 文件id
        @NameInMap("bizId")
        public String bizId;

        // 接收成员列表，仅分享文档返回
        @NameInMap("docMemberList")
        public java.util.List<ListAuditLogResponseBodyListDocMemberList> docMemberList;

        // 成员授权列表，仅文档授权返回
        @NameInMap("docReceiverList")
        public java.util.List<ListAuditLogResponseBodyListDocReceiverList> docReceiverList;

        // 记录生成时间，unix时间戳，单位ms
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        // 记录修改时间，unix时间戳，单位ms
        @NameInMap("gmtModified")
        public Long gmtModified;

        // 操作机器ip
        @NameInMap("ipAddress")
        public String ipAddress;

        // 操作来源空间
        @NameInMap("operateModule")
        public Long operateModule;

        // 操作来源翻译值
        @NameInMap("operateModuleView")
        public String operateModuleView;

        // 用户昵称
        @NameInMap("operatorName")
        public String operatorName;

        // 文件所属组织名称
        @NameInMap("orgName")
        public String orgName;

        // 操作端
        @NameInMap("platform")
        public Integer platform;

        // 操作端翻译值
        @NameInMap("platformView")
        public String platformView;

        // 用户姓名
        @NameInMap("realName")
        public String realName;

        // 文件接收方名称
        @NameInMap("receiverName")
        public String receiverName;

        // 文件接收方类型
        @NameInMap("receiverType")
        public Integer receiverType;

        // 文件接收方类型翻译值
        @NameInMap("receiverTypeView")
        public String receiverTypeView;

        // test.docx
        @NameInMap("resource")
        public String resource;

        // 文件类型
        @NameInMap("resourceExtension")
        public String resourceExtension;

        // 文件大小
        @NameInMap("resourceSize")
        public Long resourceSize;

        // 记录状态
        @NameInMap("status")
        public Integer status;

        // 空间id
        @NameInMap("targetSpaceId")
        public Long targetSpaceId;

        // 员工的userId
        @NameInMap("userId")
        public String userId;

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

    }

}
