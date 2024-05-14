// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateBranchVisibleSettingInCooperateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
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
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("branchCorpId")
        public String branchCorpId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("open")
        public Boolean open;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("type")
        public Long type;

        @NameInMap("visibleBranchCorpIds")
        public java.util.List<String> visibleBranchCorpIds;

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

        public UpdateBranchVisibleSettingInCooperateRequestBody setOpen(Boolean open) {
            this.open = open;
            return this;
        }
        public Boolean getOpen() {
            return this.open;
        }

        public UpdateBranchVisibleSettingInCooperateRequestBody setType(Long type) {
            this.type = type;
            return this;
        }
        public Long getType() {
            return this.type;
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
