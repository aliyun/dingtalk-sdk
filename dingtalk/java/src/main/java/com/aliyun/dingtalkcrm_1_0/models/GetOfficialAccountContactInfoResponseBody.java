// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountContactInfoResponseBody extends TeaModel {
    @NameInMap("authItems")
    public java.util.List<String> authItems;

    @NameInMap("corpName")
    public String corpName;

    @NameInMap("mobile")
    public String mobile;

    @NameInMap("stateCode")
    public String stateCode;

    @NameInMap("unionId")
    public String unionId;

    @NameInMap("userInfos")
    public java.util.List<String> userInfos;

    public static GetOfficialAccountContactInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOfficialAccountContactInfoResponseBody self = new GetOfficialAccountContactInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOfficialAccountContactInfoResponseBody setAuthItems(java.util.List<String> authItems) {
        this.authItems = authItems;
        return this;
    }
    public java.util.List<String> getAuthItems() {
        return this.authItems;
    }

    public GetOfficialAccountContactInfoResponseBody setCorpName(String corpName) {
        this.corpName = corpName;
        return this;
    }
    public String getCorpName() {
        return this.corpName;
    }

    public GetOfficialAccountContactInfoResponseBody setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public GetOfficialAccountContactInfoResponseBody setStateCode(String stateCode) {
        this.stateCode = stateCode;
        return this;
    }
    public String getStateCode() {
        return this.stateCode;
    }

    public GetOfficialAccountContactInfoResponseBody setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public GetOfficialAccountContactInfoResponseBody setUserInfos(java.util.List<String> userInfos) {
        this.userInfos = userInfos;
        return this;
    }
    public java.util.List<String> getUserInfos() {
        return this.userInfos;
    }

}
