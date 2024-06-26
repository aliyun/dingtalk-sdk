// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPartnerTypeByParentIdResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
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
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1234</p>
         */
        @NameInMap("labelId")
        public String labelId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>目前无意义</p>
         */
        @NameInMap("typeId")
        public Float typeId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>经销商</p>
         */
        @NameInMap("typeName")
        public String typeName;

        public static GetPartnerTypeByParentIdResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetPartnerTypeByParentIdResponseBodyData self = new GetPartnerTypeByParentIdResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetPartnerTypeByParentIdResponseBodyData setLabelId(String labelId) {
            this.labelId = labelId;
            return this;
        }
        public String getLabelId() {
            return this.labelId;
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
