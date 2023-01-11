// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateCustomfieldValueResponseBody extends TeaModel {
    /**
     * <p>返回对象</p>
     */
    @NameInMap("result")
    public UpdateCustomfieldValueResponseBodyResult result;

    public static UpdateCustomfieldValueResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateCustomfieldValueResponseBody self = new UpdateCustomfieldValueResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateCustomfieldValueResponseBody setResult(UpdateCustomfieldValueResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateCustomfieldValueResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateCustomfieldValueResponseBodyResultCustomfieldsValue extends TeaModel {
        /**
         * <p>自定义字段显示值</p>
         */
        @NameInMap("title")
        public String title;

        public static UpdateCustomfieldValueResponseBodyResultCustomfieldsValue build(java.util.Map<String, ?> map) throws Exception {
            UpdateCustomfieldValueResponseBodyResultCustomfieldsValue self = new UpdateCustomfieldValueResponseBodyResultCustomfieldsValue();
            return TeaModel.build(map, self);
        }

        public UpdateCustomfieldValueResponseBodyResultCustomfieldsValue setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class UpdateCustomfieldValueResponseBodyResultCustomfields extends TeaModel {
        /**
         * <p>自定义字段id</p>
         */
        @NameInMap("customfieldId")
        public String customfieldId;

        /**
         * <p>自定义字段值对象</p>
         */
        @NameInMap("value")
        public java.util.List<UpdateCustomfieldValueResponseBodyResultCustomfieldsValue> value;

        public static UpdateCustomfieldValueResponseBodyResultCustomfields build(java.util.Map<String, ?> map) throws Exception {
            UpdateCustomfieldValueResponseBodyResultCustomfields self = new UpdateCustomfieldValueResponseBodyResultCustomfields();
            return TeaModel.build(map, self);
        }

        public UpdateCustomfieldValueResponseBodyResultCustomfields setCustomfieldId(String customfieldId) {
            this.customfieldId = customfieldId;
            return this;
        }
        public String getCustomfieldId() {
            return this.customfieldId;
        }

        public UpdateCustomfieldValueResponseBodyResultCustomfields setValue(java.util.List<UpdateCustomfieldValueResponseBodyResultCustomfieldsValue> value) {
            this.value = value;
            return this;
        }
        public java.util.List<UpdateCustomfieldValueResponseBodyResultCustomfieldsValue> getValue() {
            return this.value;
        }

    }

    public static class UpdateCustomfieldValueResponseBodyResult extends TeaModel {
        /**
         * <p>自定义字段数组</p>
         */
        @NameInMap("customfields")
        public java.util.List<UpdateCustomfieldValueResponseBodyResultCustomfields> customfields;

        public static UpdateCustomfieldValueResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateCustomfieldValueResponseBodyResult self = new UpdateCustomfieldValueResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateCustomfieldValueResponseBodyResult setCustomfields(java.util.List<UpdateCustomfieldValueResponseBodyResultCustomfields> customfields) {
            this.customfields = customfields;
            return this;
        }
        public java.util.List<UpdateCustomfieldValueResponseBodyResultCustomfields> getCustomfields() {
            return this.customfields;
        }

    }

}
