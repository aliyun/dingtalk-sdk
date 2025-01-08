// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EduGetFileSpaceResponseBody extends TeaModel {
    @NameInMap("result")
    public EduGetFileSpaceResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static EduGetFileSpaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EduGetFileSpaceResponseBody self = new EduGetFileSpaceResponseBody();
        return TeaModel.build(map, self);
    }

    public EduGetFileSpaceResponseBody setResult(EduGetFileSpaceResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public EduGetFileSpaceResponseBodyResult getResult() {
        return this.result;
    }

    public EduGetFileSpaceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class EduGetFileSpaceResponseBodyResult extends TeaModel {
        @NameInMap("folderId")
        public String folderId;

        @NameInMap("spaceId")
        public String spaceId;

        public static EduGetFileSpaceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            EduGetFileSpaceResponseBodyResult self = new EduGetFileSpaceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public EduGetFileSpaceResponseBodyResult setFolderId(String folderId) {
            this.folderId = folderId;
            return this;
        }
        public String getFolderId() {
            return this.folderId;
        }

        public EduGetFileSpaceResponseBodyResult setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

}
