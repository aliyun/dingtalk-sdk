// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetBranchAuthDataRequest extends TeaModel {
    @NameInMap("body")
    public java.util.Map<String, String> body;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dinglkj123hj25jk54j2</p>
     */
    @NameInMap("branchCorpId")
    public String branchCorpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>eduStuCnt</p>
     */
    @NameInMap("code")
    public String code;

    public static GetBranchAuthDataRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBranchAuthDataRequest self = new GetBranchAuthDataRequest();
        return TeaModel.build(map, self);
    }

    public GetBranchAuthDataRequest setBody(java.util.Map<String, String> body) {
        this.body = body;
        return this;
    }
    public java.util.Map<String, String> getBody() {
        return this.body;
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

}
