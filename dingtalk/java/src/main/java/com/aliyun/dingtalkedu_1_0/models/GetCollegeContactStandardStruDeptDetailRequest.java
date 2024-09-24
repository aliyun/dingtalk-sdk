// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetCollegeContactStandardStruDeptDetailRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>zh_CN</p>
     */
    @NameInMap("language")
    public String language;

    public static GetCollegeContactStandardStruDeptDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCollegeContactStandardStruDeptDetailRequest self = new GetCollegeContactStandardStruDeptDetailRequest();
        return TeaModel.build(map, self);
    }

    public GetCollegeContactStandardStruDeptDetailRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

}
