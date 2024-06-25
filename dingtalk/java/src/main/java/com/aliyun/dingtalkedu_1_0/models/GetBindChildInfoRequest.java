// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetBindChildInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding95eef8003c9ca8ca24f2f5cc6abecb85</p>
     */
    @NameInMap("schoolCorpId")
    public String schoolCorpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>3000000000307711730</p>
     */
    @NameInMap("studentUserId")
    public String studentUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>X5y5kd8XiiqiScCl4Qlfy5GgiEiE</p>
     */
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
