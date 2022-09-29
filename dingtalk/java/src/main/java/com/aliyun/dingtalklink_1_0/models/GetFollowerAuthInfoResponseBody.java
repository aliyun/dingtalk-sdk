// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class GetFollowerAuthInfoResponseBody extends TeaModel {
    // 响应结果
    @NameInMap("result")
    public GetFollowerAuthInfoResponseBodyResult result;

    public static GetFollowerAuthInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFollowerAuthInfoResponseBody self = new GetFollowerAuthInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFollowerAuthInfoResponseBody setResult(GetFollowerAuthInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetFollowerAuthInfoResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetFollowerAuthInfoResponseBodyResultAuthInfoMainCorp extends TeaModel {
        // 是否授权主组织信息。
        // 当且仅当此值为true时返回用户主组织信息。
        @NameInMap("authorized")
        public Boolean authorized;

        // 主组织名
        @NameInMap("corpName")
        public String corpName;

        public static GetFollowerAuthInfoResponseBodyResultAuthInfoMainCorp build(java.util.Map<String, ?> map) throws Exception {
            GetFollowerAuthInfoResponseBodyResultAuthInfoMainCorp self = new GetFollowerAuthInfoResponseBodyResultAuthInfoMainCorp();
            return TeaModel.build(map, self);
        }

        public GetFollowerAuthInfoResponseBodyResultAuthInfoMainCorp setAuthorized(Boolean authorized) {
            this.authorized = authorized;
            return this;
        }
        public Boolean getAuthorized() {
            return this.authorized;
        }

        public GetFollowerAuthInfoResponseBodyResultAuthInfoMainCorp setCorpName(String corpName) {
            this.corpName = corpName;
            return this;
        }
        public String getCorpName() {
            return this.corpName;
        }

    }

    public static class GetFollowerAuthInfoResponseBodyResultAuthInfoMobile extends TeaModel {
        // 用户是否授权手机号码信息。
        // 当且仅当此值为true时返回手机号码信息。
        @NameInMap("authorized")
        public Boolean authorized;

        // 手机号码
        @NameInMap("mobile")
        public String mobile;

        // 地区码
        @NameInMap("stateCode")
        public String stateCode;

        public static GetFollowerAuthInfoResponseBodyResultAuthInfoMobile build(java.util.Map<String, ?> map) throws Exception {
            GetFollowerAuthInfoResponseBodyResultAuthInfoMobile self = new GetFollowerAuthInfoResponseBodyResultAuthInfoMobile();
            return TeaModel.build(map, self);
        }

        public GetFollowerAuthInfoResponseBodyResultAuthInfoMobile setAuthorized(Boolean authorized) {
            this.authorized = authorized;
            return this;
        }
        public Boolean getAuthorized() {
            return this.authorized;
        }

        public GetFollowerAuthInfoResponseBodyResultAuthInfoMobile setMobile(String mobile) {
            this.mobile = mobile;
            return this;
        }
        public String getMobile() {
            return this.mobile;
        }

        public GetFollowerAuthInfoResponseBodyResultAuthInfoMobile setStateCode(String stateCode) {
            this.stateCode = stateCode;
            return this;
        }
        public String getStateCode() {
            return this.stateCode;
        }

    }

    public static class GetFollowerAuthInfoResponseBodyResultAuthInfo extends TeaModel {
        // 用户主组织信息
        // 需要用户授权给应用后返回此信息。
        @NameInMap("mainCorp")
        public GetFollowerAuthInfoResponseBodyResultAuthInfoMainCorp mainCorp;

        // 手机号码授权详情。
        // 需要用户授权给应用后返回此信息。
        @NameInMap("mobile")
        public GetFollowerAuthInfoResponseBodyResultAuthInfoMobile mobile;

        public static GetFollowerAuthInfoResponseBodyResultAuthInfo build(java.util.Map<String, ?> map) throws Exception {
            GetFollowerAuthInfoResponseBodyResultAuthInfo self = new GetFollowerAuthInfoResponseBodyResultAuthInfo();
            return TeaModel.build(map, self);
        }

        public GetFollowerAuthInfoResponseBodyResultAuthInfo setMainCorp(GetFollowerAuthInfoResponseBodyResultAuthInfoMainCorp mainCorp) {
            this.mainCorp = mainCorp;
            return this;
        }
        public GetFollowerAuthInfoResponseBodyResultAuthInfoMainCorp getMainCorp() {
            return this.mainCorp;
        }

        public GetFollowerAuthInfoResponseBodyResultAuthInfo setMobile(GetFollowerAuthInfoResponseBodyResultAuthInfoMobile mobile) {
            this.mobile = mobile;
            return this;
        }
        public GetFollowerAuthInfoResponseBodyResultAuthInfoMobile getMobile() {
            return this.mobile;
        }

    }

    public static class GetFollowerAuthInfoResponseBodyResult extends TeaModel {
        // 授权详情
        @NameInMap("authInfo")
        public GetFollowerAuthInfoResponseBodyResultAuthInfo authInfo;

        public static GetFollowerAuthInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetFollowerAuthInfoResponseBodyResult self = new GetFollowerAuthInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetFollowerAuthInfoResponseBodyResult setAuthInfo(GetFollowerAuthInfoResponseBodyResultAuthInfo authInfo) {
            this.authInfo = authInfo;
            return this;
        }
        public GetFollowerAuthInfoResponseBodyResultAuthInfo getAuthInfo() {
            return this.authInfo;
        }

    }

}