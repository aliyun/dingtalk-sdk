// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveStorageFunctionSwitchRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>15800000000</p>
     */
    @NameInMap("functionList")
    public java.util.List<SaveStorageFunctionSwitchRequestFunctionList> functionList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingxxxxxx</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static SaveStorageFunctionSwitchRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveStorageFunctionSwitchRequest self = new SaveStorageFunctionSwitchRequest();
        return TeaModel.build(map, self);
    }

    public SaveStorageFunctionSwitchRequest setFunctionList(java.util.List<SaveStorageFunctionSwitchRequestFunctionList> functionList) {
        this.functionList = functionList;
        return this;
    }
    public java.util.List<SaveStorageFunctionSwitchRequestFunctionList> getFunctionList() {
        return this.functionList;
    }

    public SaveStorageFunctionSwitchRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

    public static class SaveStorageFunctionSwitchRequestFunctionList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("functionKey")
        public String functionKey;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("functionValue")
        public String functionValue;

        public static SaveStorageFunctionSwitchRequestFunctionList build(java.util.Map<String, ?> map) throws Exception {
            SaveStorageFunctionSwitchRequestFunctionList self = new SaveStorageFunctionSwitchRequestFunctionList();
            return TeaModel.build(map, self);
        }

        public SaveStorageFunctionSwitchRequestFunctionList setFunctionKey(String functionKey) {
            this.functionKey = functionKey;
            return this;
        }
        public String getFunctionKey() {
            return this.functionKey;
        }

        public SaveStorageFunctionSwitchRequestFunctionList setFunctionValue(String functionValue) {
            this.functionValue = functionValue;
            return this;
        }
        public String getFunctionValue() {
            return this.functionValue;
        }

    }

}
