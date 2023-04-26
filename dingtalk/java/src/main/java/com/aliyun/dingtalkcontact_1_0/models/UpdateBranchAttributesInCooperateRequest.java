// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateBranchAttributesInCooperateRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<UpdateBranchAttributesInCooperateRequestBody> body;

    public static UpdateBranchAttributesInCooperateRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateBranchAttributesInCooperateRequest self = new UpdateBranchAttributesInCooperateRequest();
        return TeaModel.build(map, self);
    }

    public UpdateBranchAttributesInCooperateRequest setBody(java.util.List<UpdateBranchAttributesInCooperateRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<UpdateBranchAttributesInCooperateRequestBody> getBody() {
        return this.body;
    }

    public static class UpdateBranchAttributesInCooperateRequestBody extends TeaModel {
        @NameInMap("branchCorpId")
        public String branchCorpId;

        @NameInMap("linkDeptId")
        public Long linkDeptId;

        @NameInMap("unionRootName")
        public String unionRootName;

        public static UpdateBranchAttributesInCooperateRequestBody build(java.util.Map<String, ?> map) throws Exception {
            UpdateBranchAttributesInCooperateRequestBody self = new UpdateBranchAttributesInCooperateRequestBody();
            return TeaModel.build(map, self);
        }

        public UpdateBranchAttributesInCooperateRequestBody setBranchCorpId(String branchCorpId) {
            this.branchCorpId = branchCorpId;
            return this;
        }
        public String getBranchCorpId() {
            return this.branchCorpId;
        }

        public UpdateBranchAttributesInCooperateRequestBody setLinkDeptId(Long linkDeptId) {
            this.linkDeptId = linkDeptId;
            return this;
        }
        public Long getLinkDeptId() {
            return this.linkDeptId;
        }

        public UpdateBranchAttributesInCooperateRequestBody setUnionRootName(String unionRootName) {
            this.unionRootName = unionRootName;
            return this;
        }
        public String getUnionRootName() {
            return this.unionRootName;
        }

    }

}
