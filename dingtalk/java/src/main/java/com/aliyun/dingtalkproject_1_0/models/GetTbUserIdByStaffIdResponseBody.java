// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetTbUserIdByStaffIdResponseBody extends TeaModel {
    @NameInMap("result")
    public GetTbUserIdByStaffIdResponseBodyResult result;

    public static GetTbUserIdByStaffIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTbUserIdByStaffIdResponseBody self = new GetTbUserIdByStaffIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTbUserIdByStaffIdResponseBody setResult(GetTbUserIdByStaffIdResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetTbUserIdByStaffIdResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetTbUserIdByStaffIdResponseBodyResult extends TeaModel {
        @NameInMap("tbUserId")
        public String tbUserId;

        public static GetTbUserIdByStaffIdResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetTbUserIdByStaffIdResponseBodyResult self = new GetTbUserIdByStaffIdResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetTbUserIdByStaffIdResponseBodyResult setTbUserId(String tbUserId) {
            this.tbUserId = tbUserId;
            return this;
        }
        public String getTbUserId() {
            return this.tbUserId;
        }

    }

}
