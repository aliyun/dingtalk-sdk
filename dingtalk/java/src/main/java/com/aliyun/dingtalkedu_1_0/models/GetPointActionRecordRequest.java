// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetPointActionRecordRequest extends TeaModel {
    @NameInMap("body")
    public GetPointActionRecordRequestBody body;

    public static GetPointActionRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPointActionRecordRequest self = new GetPointActionRecordRequest();
        return TeaModel.build(map, self);
    }

    public GetPointActionRecordRequest setBody(GetPointActionRecordRequestBody body) {
        this.body = body;
        return this;
    }
    public GetPointActionRecordRequestBody getBody() {
        return this.body;
    }

    public static class GetPointActionRecordRequestBody extends TeaModel {
        @NameInMap("bizId")
        public String bizId;

        @NameInMap("ownerId")
        public String ownerId;

        @NameInMap("pointType")
        public String pointType;

        public static GetPointActionRecordRequestBody build(java.util.Map<String, ?> map) throws Exception {
            GetPointActionRecordRequestBody self = new GetPointActionRecordRequestBody();
            return TeaModel.build(map, self);
        }

        public GetPointActionRecordRequestBody setBizId(String bizId) {
            this.bizId = bizId;
            return this;
        }
        public String getBizId() {
            return this.bizId;
        }

        public GetPointActionRecordRequestBody setOwnerId(String ownerId) {
            this.ownerId = ownerId;
            return this;
        }
        public String getOwnerId() {
            return this.ownerId;
        }

        public GetPointActionRecordRequestBody setPointType(String pointType) {
            this.pointType = pointType;
            return this;
        }
        public String getPointType() {
            return this.pointType;
        }

    }

}
