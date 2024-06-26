// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class EsignQueryGrantInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public EsignQueryGrantInfoResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static EsignQueryGrantInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EsignQueryGrantInfoResponseBody self = new EsignQueryGrantInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public EsignQueryGrantInfoResponseBody setResult(EsignQueryGrantInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public EsignQueryGrantInfoResponseBodyResult getResult() {
        return this.result;
    }

    public EsignQueryGrantInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class EsignQueryGrantInfoResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>何一兵</p>
         */
        @NameInMap("legalPerson")
        public String legalPerson;

        /**
         * <strong>example:</strong>
         * <p>18667021101</p>
         */
        @NameInMap("mobilePhoneNumber")
        public String mobilePhoneNumber;

        /**
         * <strong>example:</strong>
         * <p>杭州天谷信息科技有限公司</p>
         */
        @NameInMap("orgName")
        public String orgName;

        /**
         * <strong>example:</strong>
         * <p>86</p>
         */
        @NameInMap("stateCode")
        public String stateCode;

        /**
         * <strong>example:</strong>
         * <p>913301087458306077</p>
         */
        @NameInMap("unifiedSocialCredit")
        public String unifiedSocialCredit;

        /**
         * <strong>example:</strong>
         * <p>某人名</p>
         */
        @NameInMap("userName")
        public String userName;

        public static EsignQueryGrantInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            EsignQueryGrantInfoResponseBodyResult self = new EsignQueryGrantInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public EsignQueryGrantInfoResponseBodyResult setLegalPerson(String legalPerson) {
            this.legalPerson = legalPerson;
            return this;
        }
        public String getLegalPerson() {
            return this.legalPerson;
        }

        public EsignQueryGrantInfoResponseBodyResult setMobilePhoneNumber(String mobilePhoneNumber) {
            this.mobilePhoneNumber = mobilePhoneNumber;
            return this;
        }
        public String getMobilePhoneNumber() {
            return this.mobilePhoneNumber;
        }

        public EsignQueryGrantInfoResponseBodyResult setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

        public EsignQueryGrantInfoResponseBodyResult setStateCode(String stateCode) {
            this.stateCode = stateCode;
            return this;
        }
        public String getStateCode() {
            return this.stateCode;
        }

        public EsignQueryGrantInfoResponseBodyResult setUnifiedSocialCredit(String unifiedSocialCredit) {
            this.unifiedSocialCredit = unifiedSocialCredit;
            return this;
        }
        public String getUnifiedSocialCredit() {
            return this.unifiedSocialCredit;
        }

        public EsignQueryGrantInfoResponseBodyResult setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

}
