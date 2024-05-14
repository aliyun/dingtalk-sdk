// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SheetFindAllRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("findOptions")
    public SheetFindAllRequestFindOptions findOptions;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("text")
    public String text;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("select")
    public String select;

    public static SheetFindAllRequest build(java.util.Map<String, ?> map) throws Exception {
        SheetFindAllRequest self = new SheetFindAllRequest();
        return TeaModel.build(map, self);
    }

    public SheetFindAllRequest setFindOptions(SheetFindAllRequestFindOptions findOptions) {
        this.findOptions = findOptions;
        return this;
    }
    public SheetFindAllRequestFindOptions getFindOptions() {
        return this.findOptions;
    }

    public SheetFindAllRequest setText(String text) {
        this.text = text;
        return this;
    }
    public String getText() {
        return this.text;
    }

    public SheetFindAllRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public SheetFindAllRequest setSelect(String select) {
        this.select = select;
        return this;
    }
    public String getSelect() {
        return this.select;
    }

    public static class SheetFindAllRequestFindOptions extends TeaModel {
        @NameInMap("includeHidden")
        public Boolean includeHidden;

        @NameInMap("matchCase")
        public Boolean matchCase;

        @NameInMap("matchEntireCell")
        public Boolean matchEntireCell;

        @NameInMap("matchFormulaText")
        public Boolean matchFormulaText;

        @NameInMap("scope")
        public String scope;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unionCells")
        public Boolean unionCells;

        @NameInMap("useRegExp")
        public Boolean useRegExp;

        public static SheetFindAllRequestFindOptions build(java.util.Map<String, ?> map) throws Exception {
            SheetFindAllRequestFindOptions self = new SheetFindAllRequestFindOptions();
            return TeaModel.build(map, self);
        }

        public SheetFindAllRequestFindOptions setIncludeHidden(Boolean includeHidden) {
            this.includeHidden = includeHidden;
            return this;
        }
        public Boolean getIncludeHidden() {
            return this.includeHidden;
        }

        public SheetFindAllRequestFindOptions setMatchCase(Boolean matchCase) {
            this.matchCase = matchCase;
            return this;
        }
        public Boolean getMatchCase() {
            return this.matchCase;
        }

        public SheetFindAllRequestFindOptions setMatchEntireCell(Boolean matchEntireCell) {
            this.matchEntireCell = matchEntireCell;
            return this;
        }
        public Boolean getMatchEntireCell() {
            return this.matchEntireCell;
        }

        public SheetFindAllRequestFindOptions setMatchFormulaText(Boolean matchFormulaText) {
            this.matchFormulaText = matchFormulaText;
            return this;
        }
        public Boolean getMatchFormulaText() {
            return this.matchFormulaText;
        }

        public SheetFindAllRequestFindOptions setScope(String scope) {
            this.scope = scope;
            return this;
        }
        public String getScope() {
            return this.scope;
        }

        public SheetFindAllRequestFindOptions setUnionCells(Boolean unionCells) {
            this.unionCells = unionCells;
            return this;
        }
        public Boolean getUnionCells() {
            return this.unionCells;
        }

        public SheetFindAllRequestFindOptions setUseRegExp(Boolean useRegExp) {
            this.useRegExp = useRegExp;
            return this;
        }
        public Boolean getUseRegExp() {
            return this.useRegExp;
        }

    }

}
