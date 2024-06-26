// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class BatchApproveUnionApplyRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<BatchApproveUnionApplyRequestBody> body;

    public static BatchApproveUnionApplyRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchApproveUnionApplyRequest self = new BatchApproveUnionApplyRequest();
        return TeaModel.build(map, self);
    }

    public BatchApproveUnionApplyRequest setBody(java.util.List<BatchApproveUnionApplyRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<BatchApproveUnionApplyRequestBody> getBody() {
        return this.body;
    }

    public static class BatchApproveUnionApplyRequestBody extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>ding1234</p>
         */
        @NameInMap("branchCorpId")
        public String branchCorpId;

        /**
         * <strong>example:</strong>
         * <p>123456</p>
         */
        @NameInMap("linkDeptId")
        public Long linkDeptId;

        /**
         * <strong>example:</strong>
         * <p>测试</p>
         */
        @NameInMap("unionRootName")
        public String unionRootName;

        public static BatchApproveUnionApplyRequestBody build(java.util.Map<String, ?> map) throws Exception {
            BatchApproveUnionApplyRequestBody self = new BatchApproveUnionApplyRequestBody();
            return TeaModel.build(map, self);
        }

        public BatchApproveUnionApplyRequestBody setBranchCorpId(String branchCorpId) {
            this.branchCorpId = branchCorpId;
            return this;
        }
        public String getBranchCorpId() {
            return this.branchCorpId;
        }

        public BatchApproveUnionApplyRequestBody setLinkDeptId(Long linkDeptId) {
            this.linkDeptId = linkDeptId;
            return this;
        }
        public Long getLinkDeptId() {
            return this.linkDeptId;
        }

        public BatchApproveUnionApplyRequestBody setUnionRootName(String unionRootName) {
            this.unionRootName = unionRootName;
            return this;
        }
        public String getUnionRootName() {
            return this.unionRootName;
        }

    }

}
