// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetBindChildInfoRequest extends TeaModel {
    @NameInMap("schoolCorpId")
    public String schoolCorpId;

    @NameInMap("studentUserId")
    public String studentUserId;

    @NameInMap("unionId")
    public String unionId;

    public static GetBindChildInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBindChildInfoRequest self = new GetBindChildInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetBindChildInfoRequest setSchoolCorpId(String schoolCorpId) {
        this.schoolCorpId = schoolCorpId;
        return this;
    }
    public String getSchoolCorpId() {
        return this.schoolCorpId;
    }

    public GetBindChildInfoRequest setStudentUserId(String studentUserId) {
        this.studentUserId = studentUserId;
        return this;
    }
    public String getStudentUserId() {
        return this.studentUserId;
    }

    public GetBindChildInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
