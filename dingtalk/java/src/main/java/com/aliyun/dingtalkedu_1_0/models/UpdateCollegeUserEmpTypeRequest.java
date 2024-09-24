// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCollegeUserEmpTypeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>college_student</p>
     */
    @NameInMap("empType")
    public String empType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>zhangsan666</p>
     */
    @NameInMap("userid")
    public String userid;

    public static UpdateCollegeUserEmpTypeRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateCollegeUserEmpTypeRequest self = new UpdateCollegeUserEmpTypeRequest();
        return TeaModel.build(map, self);
    }

    public UpdateCollegeUserEmpTypeRequest setEmpType(String empType) {
        this.empType = empType;
        return this;
    }
    public String getEmpType() {
        return this.empType;
    }

    public UpdateCollegeUserEmpTypeRequest setUserid(String userid) {
        this.userid = userid;
        return this;
    }
    public String getUserid() {
        return this.userid;
    }

}
