// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetShareRoleMembersResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public java.util.List<GetShareRoleMembersResponseBodyResult> result;

    public static GetShareRoleMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetShareRoleMembersResponseBody self = new GetShareRoleMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public GetShareRoleMembersResponseBody setResult(java.util.List<GetShareRoleMembersResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetShareRoleMembersResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetShareRoleMembersResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("memberUserIdListInTrunkOrg")
        public java.util.List<String> memberUserIdListInTrunkOrg;

        public static GetShareRoleMembersResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetShareRoleMembersResponseBodyResult self = new GetShareRoleMembersResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetShareRoleMembersResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetShareRoleMembersResponseBodyResult setMemberUserIdListInTrunkOrg(java.util.List<String> memberUserIdListInTrunkOrg) {
            this.memberUserIdListInTrunkOrg = memberUserIdListInTrunkOrg;
            return this;
        }
        public java.util.List<String> getMemberUserIdListInTrunkOrg() {
            return this.memberUserIdListInTrunkOrg;
        }

    }

}
