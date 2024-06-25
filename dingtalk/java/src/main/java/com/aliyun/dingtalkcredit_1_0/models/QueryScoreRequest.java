// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcredit_1_0.models;

import com.aliyun.tea.*;

public class QueryScoreRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>MD5</p>
     */
    @NameInMap("encryption")
    public String encryption;

    /**
     * <strong>example:</strong>
     * <p>a0fbf479272cd38c220fbf726678d8d6</p>
     */
    @NameInMap("fullName")
    public String fullName;

    /**
     * <strong>example:</strong>
     * <p>b04a604cf00e64136b386e83444245c3</p>
     */
    @NameInMap("idCardCode")
    public String idCardCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>e10adc3949ba59abbe56e057f20f883e</p>
     */
    @NameInMap("mobile")
    public String mobile;

    /**
     * <strong>example:</strong>
     * <p>aca03c931768ea4b0244531aca9a19ee</p>
     */
    @NameInMap("orgName")
    public String orgName;

    /**
     * <strong>example:</strong>
     * <p>a57d7bf49b6e44180b21b1fea80eec0a</p>
     */
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
