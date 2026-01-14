// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalgo_1_0.models;

import com.aliyun.tea.*;

public class WeiqiaoAluminumSubmitRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{         &quot;sample_1&quot;: {             &quot;Weight&quot;: 102000,             &quot;Al&quot;: 97, &quot;Si&quot;: 0.05, &quot;Fe&quot;: 0.05         },         &quot;sample_2&quot;: {             &quot;Weight&quot;: 102000,             &quot;Al&quot;: 98, &quot;Si&quot;: 0.04, &quot;Fe&quot;: 0.05         }     }</p>
     */
    @NameInMap("current_furnace")
    public Object currentFurnace;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{}</p>
     */
    @NameInMap("dilution_config")
    public Object dilutionConfig;

    @NameInMap("history_furnace")
    public Object historyFurnace;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>[         {             &quot;Name&quot;: &quot;Al-Si-Material&quot;,             &quot;Primary_element&quot;: &quot;Si&quot;,             &quot;Si&quot;: 10.0, &quot;Al&quot;: 90.0         },         {             &quot;Name&quot;: &quot;Al-Fe-Material&quot;,             &quot;Primary_element&quot;: &quot;Fe&quot;,             &quot;Fe&quot;: 10.0, &quot;Al&quot;: 90.0         }     ]</p>
     */
    @NameInMap("raw_materials")
    public Object rawMaterials;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>test_batch_001</p>
     */
    @NameInMap("target")
    public Object target;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{         &quot;Si&quot;: [0.1, 0.2, 0.3],         &quot;Fe&quot;: [0.1, 0.2, 0.3]     }</p>
     */
    @NameInMap("target_ranges")
    public Object targetRanges;

    public static WeiqiaoAluminumSubmitRequest build(java.util.Map<String, ?> map) throws Exception {
        WeiqiaoAluminumSubmitRequest self = new WeiqiaoAluminumSubmitRequest();
        return TeaModel.build(map, self);
    }

    public WeiqiaoAluminumSubmitRequest setCurrentFurnace(Object currentFurnace) {
        this.currentFurnace = currentFurnace;
        return this;
    }
    public Object getCurrentFurnace() {
        return this.currentFurnace;
    }

    public WeiqiaoAluminumSubmitRequest setDilutionConfig(Object dilutionConfig) {
        this.dilutionConfig = dilutionConfig;
        return this;
    }
    public Object getDilutionConfig() {
        return this.dilutionConfig;
    }

    public WeiqiaoAluminumSubmitRequest setHistoryFurnace(Object historyFurnace) {
        this.historyFurnace = historyFurnace;
        return this;
    }
    public Object getHistoryFurnace() {
        return this.historyFurnace;
    }

    public WeiqiaoAluminumSubmitRequest setRawMaterials(Object rawMaterials) {
        this.rawMaterials = rawMaterials;
        return this;
    }
    public Object getRawMaterials() {
        return this.rawMaterials;
    }

    public WeiqiaoAluminumSubmitRequest setTarget(Object target) {
        this.target = target;
        return this;
    }
    public Object getTarget() {
        return this.target;
    }

    public WeiqiaoAluminumSubmitRequest setTargetRanges(Object targetRanges) {
        this.targetRanges = targetRanges;
        return this;
    }
    public Object getTargetRanges() {
        return this.targetRanges;
    }

}
