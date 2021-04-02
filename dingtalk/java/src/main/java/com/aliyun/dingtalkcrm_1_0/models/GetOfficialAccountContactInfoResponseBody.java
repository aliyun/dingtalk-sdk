// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountContactInfoResponseBody extends TeaModel {
    // 联系人主企业名称
    @NameInMap("corpName")
    public String corpName;

    // 手机号
    @NameInMap("mobile")
    public String mobile;

    // 手机号国家码
    @NameInMap("stateCode")
    public String stateCode;

    public static GetOfficialAccountContactInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOfficialAccountContactInfoResponseBody self = new GetOfficialAccountContactInfoResponseBody();
        return TeaModel.build(map, self);
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

}
