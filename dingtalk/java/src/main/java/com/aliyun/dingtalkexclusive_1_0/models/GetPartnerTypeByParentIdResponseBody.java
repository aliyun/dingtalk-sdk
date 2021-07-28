// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPartnerTypeByParentIdResponseBody extends TeaModel {
    // 子标签列表
    @NameInMap("data")
    public java.util.List<GetPartnerTypeByParentIdResponseBodyData> data;

    public static GetPartnerTypeByParentIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPartnerTypeByParentIdResponseBody self = new GetPartnerTypeByParentIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPartnerTypeByParentIdResponseBody setData(java.util.List<GetPartnerTypeByParentIdResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetPartnerTypeByParentIdResponseBodyData> getData() {
        return this.data;
    }

    public static class GetPartnerTypeByParentIdResponseBodyData extends TeaModel {
        // 自标签id
        @NameInMap("typeId")
        public Float typeId;

        // 子标签名
        @NameInMap("typeName")
        public String typeName;

        public static GetPartnerTypeByParentIdResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetPartnerTypeByParentIdResponseBodyData self = new GetPartnerTypeByParentIdResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetPartnerTypeByParentIdResponseBodyData setTypeId(Float typeId) {
            this.typeId = typeId;
            return this;
        }
        public Float getTypeId() {
            return this.typeId;
        }

        public GetPartnerTypeByParentIdResponseBodyData setTypeName(String typeName) {
            this.typeName = typeName;
            return this;
        }
        public String getTypeName() {
            return this.typeName;
        }

    }

}
