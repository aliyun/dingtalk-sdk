// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class GetCandidateByPhoneNumberRequest extends TeaModel {
    @NameInMap("bizCode")
    public String bizCode;

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
