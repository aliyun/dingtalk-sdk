// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryCollegeContactUserDetailRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>12122294</p>
     */
    @NameInMap("jobNumber")
    public String jobNumber;

    /**
     * <strong>example:</strong>
     * <p>zh_CN</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <strong>example:</strong>
     * <p>zhangsan666</p>
     */
    @NameInMap("userid")
    public String userid;

    public static QueryCollegeContactUserDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCollegeContactUserDetailRequest self = new QueryCollegeContactUserDetailRequest();
        return TeaModel.build(map, self);
    }

    public QueryCollegeContactUserDetailRequest setJobNumber(String jobNumber) {
        this.jobNumber = jobNumber;
        return this;
    }
    public String getJobNumber() {
        return this.jobNumber;
    }

    public QueryCollegeContactUserDetailRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public QueryCollegeContactUserDetailRequest setUserid(String userid) {
        this.userid = userid;
        return this;
    }
    public String getUserid() {
        return this.userid;
    }

}
