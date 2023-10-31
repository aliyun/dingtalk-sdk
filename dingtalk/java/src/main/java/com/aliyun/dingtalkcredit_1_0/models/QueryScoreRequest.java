// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcredit_1_0.models;

import com.aliyun.tea.*;

public class QueryScoreRequest extends TeaModel {
    @NameInMap("encryption")
    public String encryption;

    @NameInMap("fullName")
    public String fullName;

    @NameInMap("idCardCode")
    public String idCardCode;

    @NameInMap("mobile")
    public String mobile;

    @NameInMap("orgName")
    public String orgName;

    @NameInMap("uniScCode")
    public String uniScCode;

    public static QueryScoreRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryScoreRequest self = new QueryScoreRequest();
        return TeaModel.build(map, self);
    }

    public QueryScoreRequest setEncryption(String encryption) {
        this.encryption = encryption;
        return this;
    }
    public String getEncryption() {
        return this.encryption;
    }

    public QueryScoreRequest setFullName(String fullName) {
        this.fullName = fullName;
        return this;
    }
    public String getFullName() {
        return this.fullName;
    }

    public QueryScoreRequest setIdCardCode(String idCardCode) {
        this.idCardCode = idCardCode;
        return this;
    }
    public String getIdCardCode() {
        return this.idCardCode;
    }

    public QueryScoreRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public QueryScoreRequest setOrgName(String orgName) {
        this.orgName = orgName;
        return this;
    }
    public String getOrgName() {
        return this.orgName;
    }

    public QueryScoreRequest setUniScCode(String uniScCode) {
        this.uniScCode = uniScCode;
        return this;
    }
    public String getUniScCode() {
        return this.uniScCode;
    }

}
