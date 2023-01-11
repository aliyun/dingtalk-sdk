// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class GetCandidateByPhoneNumberRequest extends TeaModel {
    /**
     * <p>业务标识</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>候选人手机号</p>
     */
    @NameInMap("phoneNumber")
    public String phoneNumber;

    public static GetCandidateByPhoneNumberRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCandidateByPhoneNumberRequest self = new GetCandidateByPhoneNumberRequest();
        return TeaModel.build(map, self);
    }

    public GetCandidateByPhoneNumberRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public GetCandidateByPhoneNumberRequest setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
        return this;
    }
    public String getPhoneNumber() {
        return this.phoneNumber;
    }

}
