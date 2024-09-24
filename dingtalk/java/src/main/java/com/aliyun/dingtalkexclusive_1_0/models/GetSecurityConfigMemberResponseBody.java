// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetSecurityConfigMemberResponseBody extends TeaModel {
    @NameInMap("result")
    public GetSecurityConfigMemberResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetSecurityConfigMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSecurityConfigMemberResponseBody self = new GetSecurityConfigMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSecurityConfigMemberResponseBody setResult(GetSecurityConfigMemberResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetSecurityConfigMemberResponseBodyResult getResult() {
        return this.result;
    }

    public GetSecurityConfigMemberResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetSecurityConfigMemberResponseBodyResultUserInfos extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static GetSecurityConfigMemberResponseBodyResultUserInfos build(java.util.Map<String, ?> map) throws Exception {
            GetSecurityConfigMemberResponseBodyResultUserInfos self = new GetSecurityConfigMemberResponseBodyResultUserInfos();
            return TeaModel.build(map, self);
        }

        public GetSecurityConfigMemberResponseBodyResultUserInfos setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetSecurityConfigMemberResponseBodyResultUserInfos setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GetSecurityConfigMemberResponseBodyResult extends TeaModel {
        @NameInMap("hasNext")
        public Boolean hasNext;

        @NameInMap("nextToken")
        public Float nextToken;

        @NameInMap("scopeType")
        public Integer scopeType;

        @NameInMap("userInfos")
        public java.util.List<GetSecurityConfigMemberResponseBodyResultUserInfos> userInfos;

        public static GetSecurityConfigMemberResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetSecurityConfigMemberResponseBodyResult self = new GetSecurityConfigMemberResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetSecurityConfigMemberResponseBodyResult setHasNext(Boolean hasNext) {
            this.hasNext = hasNext;
            return this;
        }
        public Boolean getHasNext() {
            return this.hasNext;
        }

        public GetSecurityConfigMemberResponseBodyResult setNextToken(Float nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public Float getNextToken() {
            return this.nextToken;
        }

        public GetSecurityConfigMemberResponseBodyResult setScopeType(Integer scopeType) {
            this.scopeType = scopeType;
            return this;
        }
        public Integer getScopeType() {
            return this.scopeType;
        }

        public GetSecurityConfigMemberResponseBodyResult setUserInfos(java.util.List<GetSecurityConfigMemberResponseBodyResultUserInfos> userInfos) {
            this.userInfos = userInfos;
            return this;
        }
        public java.util.List<GetSecurityConfigMemberResponseBodyResultUserInfos> getUserInfos() {
            return this.userInfos;
        }

    }

}
