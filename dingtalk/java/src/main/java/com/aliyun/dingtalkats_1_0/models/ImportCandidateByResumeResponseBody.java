// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class ImportCandidateByResumeResponseBody extends TeaModel {
    @NameInMap("candidateId")
    public String candidateId;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("name")
    public String name;

    public static ImportCandidateByResumeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ImportCandidateByResumeResponseBody self = new ImportCandidateByResumeResponseBody();
        return TeaModel.build(map, self);
    }

    public ImportCandidateByResumeResponseBody setCandidateId(String candidateId) {
        this.candidateId = candidateId;
        return this;
    }
    public String getCandidateId() {
        return this.candidateId;
    }

    public ImportCandidateByResumeResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public ImportCandidateByResumeResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

}
