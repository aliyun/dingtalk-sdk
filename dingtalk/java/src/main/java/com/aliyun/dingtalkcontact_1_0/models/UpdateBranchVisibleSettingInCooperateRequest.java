// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateBranchVisibleSettingInCooperateRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<UpdateBranchVisibleSettingInCooperateRequestBody> body;

    public static UpdateBranchVisibleSettingInCooperateRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateBranchVisibleSettingInCooperateRequest self = new UpdateBranchVisibleSettingInCooperateRequest();
        return TeaModel.build(map, self);
    }

    public UpdateBranchVisibleSettingInCooperateRequest setBody(java.util.List<UpdateBranchVisibleSettingInCooperateRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<UpdateBranchVisibleSettingInCooperateRequestBody> getBody() {
        return this.body;
    }

    public static class UpdateBranchVisibleSettingInCooperateRequestBody extends TeaModel {
        // 分支的企业ID
        @NameInMap("branchCorpId")
        public String branchCorpId;

        // 设置可见性类型 0 ：在主干通讯录隐藏分支(其它分支包含主组织都看不到,额外设置可以看到) 1 ： 仅可见分支所在部门(只能看到自己企业加入的成员，额外设置可以看到其它成员)
        @NameInMap("type")
        public Long type;

        // 是否开启 true：开启，false：关闭
        @NameInMap("open")
        public Boolean open;

        // 设置例外的加入合作空间/关联组织的分支企业CorpId列表
        @NameInMap("visibleBranchCorpIds")
        public java.util.List<String> visibleBranchCorpIds;

        // 设置例外的部门ID列表
        @NameInMap("visibleDeptIds")
        public java.util.List<Long> visibleDeptIds;

        public static UpdateBranchVisibleSettingInCooperateRequestBody build(java.util.Map<String, ?> map) throws Exception {
            UpdateBranchVisibleSettingInCooperateRequestBody self = new UpdateBranchVisibleSettingInCooperateRequestBody();
            return TeaModel.build(map, self);
        }

        public UpdateBranchVisibleSettingInCooperateRequestBody setBranchCorpId(String branchCorpId) {
            this.branchCorpId = branchCorpId;
            return this;
        }
        public String getBranchCorpId() {
            return this.branchCorpId;
        }

        public UpdateBranchVisibleSettingInCooperateRequestBody setType(Long type) {
            this.type = type;
            return this;
        }
        public Long getType() {
            return this.type;
        }

        public UpdateBranchVisibleSettingInCooperateRequestBody setOpen(Boolean open) {
            this.open = open;
            return this;
        }
        public Boolean getOpen() {
            return this.open;
        }

        public UpdateBranchVisibleSettingInCooperateRequestBody setVisibleBranchCorpIds(java.util.List<String> visibleBranchCorpIds) {
            this.visibleBranchCorpIds = visibleBranchCorpIds;
            return this;
        }
        public java.util.List<String> getVisibleBranchCorpIds() {
            return this.visibleBranchCorpIds;
        }

        public UpdateBranchVisibleSettingInCooperateRequestBody setVisibleDeptIds(java.util.List<Long> visibleDeptIds) {
            this.visibleDeptIds = visibleDeptIds;
            return this;
        }
        public java.util.List<Long> getVisibleDeptIds() {
            return this.visibleDeptIds;
        }

    }

}
