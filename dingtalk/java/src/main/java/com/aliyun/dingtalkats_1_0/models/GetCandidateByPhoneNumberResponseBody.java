// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class GetCandidateByPhoneNumberResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxx</p>
     */
    @NameInMap("candidateId")
    public String candidateId;

    /**
     * <strong>example:</strong>
     * <p>张三</p>
     */
    @NameInMap("name")
    public String name;

    public static GetCandidateByPhoneNumberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCandidateByPhoneNumberResponseBody self = new GetCandidateByPhoneNumberResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCandidateByPhoneNumberResponseBody setCandidateId(String candidateId) {
        this.candidateId = candidateId;
        return this;
    }
    public String getCandidateId() {
        return this.candidateId;
    }

    public GetCandidateByPhoneNumberResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

}
