// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetEduUserIdentityResponseBody extends TeaModel {
    // 返回数据
    @NameInMap("data")
    public GetEduUserIdentityResponseBodyData data;

    // 是否查询成功
    @NameInMap("success")
    public Boolean success;

    public static GetEduUserIdentityResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetEduUserIdentityResponseBody self = new GetEduUserIdentityResponseBody();
        return TeaModel.build(map, self);
    }

    public GetEduUserIdentityResponseBody setData(GetEduUserIdentityResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetEduUserIdentityResponseBodyData getData() {
        return this.data;
    }

    public GetEduUserIdentityResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetEduUserIdentityResponseBodyData extends TeaModel {
        // 是否符合家长活动规则
        @NameInMap("matchGuardianRule")
        public Boolean matchGuardianRule;

        // 是否符合教师活动规则
        @NameInMap("matchTeacherRule")
        public Boolean matchTeacherRule;

        // 用户unionId
        @NameInMap("unionId")
        public String unionId;

        public static GetEduUserIdentityResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetEduUserIdentityResponseBodyData self = new GetEduUserIdentityResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetEduUserIdentityResponseBodyData setMatchGuardianRule(Boolean matchGuardianRule) {
            this.matchGuardianRule = matchGuardianRule;
            return this;
        }
        public Boolean getMatchGuardianRule() {
            return this.matchGuardianRule;
        }

        public GetEduUserIdentityResponseBodyData setMatchTeacherRule(Boolean matchTeacherRule) {
            this.matchTeacherRule = matchTeacherRule;
            return this;
        }
        public Boolean getMatchTeacherRule() {
            return this.matchTeacherRule;
        }

        public GetEduUserIdentityResponseBodyData setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
