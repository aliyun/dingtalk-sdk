// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetBranchAuthDataRequest extends TeaModel {
    // 分支组织corpId
    @NameInMap("branchCorpId")
    public String branchCorpId;

    // 数据编码
    @NameInMap("code")
    public String code;

    // 查询条件
    @NameInMap("body")
    public java.util.Map<String, String> body;

    public static GetBranchAuthDataRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBranchAuthDataRequest self = new GetBranchAuthDataRequest();
        return TeaModel.build(map, self);
    }

    public GetBranchAuthDataRequest setBranchCorpId(String branchCorpId) {
        this.branchCorpId = branchCorpId;
        return this;
    }
    public String getBranchCorpId() {
        return this.branchCorpId;
    }

    public GetBranchAuthDataRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public GetBranchAuthDataRequest setBody(java.util.Map<String, String> body) {
        this.body = body;
        return this;
    }
    public java.util.Map<String, String> getBody() {
        return this.body;
    }

}
