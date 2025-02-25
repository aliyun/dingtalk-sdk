// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UpdateSheetRequest extends TeaModel {
    @NameInMap("frozenColumnCount")
    public Long frozenColumnCount;

    @NameInMap("frozenRowCount")
    public Long frozenRowCount;

    /**
     * <strong>example:</strong>
     * <p>sheet_name</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>visible</p>
     */
    @NameInMap("visibility")
    public String visibility;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static UpdateSheetRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateSheetRequest self = new UpdateSheetRequest();
        return TeaModel.build(map, self);
    }

    public UpdateSheetRequest setFrozenColumnCount(Long frozenColumnCount) {
        this.frozenColumnCount = frozenColumnCount;
        return this;
    }
    public Long getFrozenColumnCount() {
        return this.frozenColumnCount;
    }

    public UpdateSheetRequest setFrozenRowCount(Long frozenRowCount) {
        this.frozenRowCount = frozenRowCount;
        return this;
    }
    public Long getFrozenRowCount() {
        return this.frozenRowCount;
    }

    public UpdateSheetRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateSheetRequest setVisibility(String visibility) {
        this.visibility = visibility;
        return this;
    }
    public String getVisibility() {
        return this.visibility;
    }

    public UpdateSheetRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
