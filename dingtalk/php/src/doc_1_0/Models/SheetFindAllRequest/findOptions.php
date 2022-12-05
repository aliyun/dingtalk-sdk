<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SheetFindAllRequest;

use AlibabaCloud\Tea\Model;

class findOptions extends Model
{
    /**
     * @var bool
     */
    public $includeHidden;

    /**
     * @description 匹配大小写
     *
     * @var bool
     */
    public $matchCase;

    /**
     * @description 匹配整个单元格
     *
     * @var bool
     */
    public $matchEntireCell;

    /**
     * @description 在公式内搜索
     *
     * @var bool
     */
    public $matchFormulaText;

    /**
     * @var string
     */
    public $scope;

    /**
     * @var bool
     */
    public $unionCells;

    /**
     * @description text是正则表达式
     *
     * @var bool
     */
    public $useRegExp;
    protected $_name = [
        'includeHidden'    => 'includeHidden',
        'matchCase'        => 'matchCase',
        'matchEntireCell'  => 'matchEntireCell',
        'matchFormulaText' => 'matchFormulaText',
        'scope'            => 'scope',
        'unionCells'       => 'unionCells',
        'useRegExp'        => 'useRegExp',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->includeHidden) {
            $res['includeHidden'] = $this->includeHidden;
        }
        if (null !== $this->matchCase) {
            $res['matchCase'] = $this->matchCase;
        }
        if (null !== $this->matchEntireCell) {
            $res['matchEntireCell'] = $this->matchEntireCell;
        }
        if (null !== $this->matchFormulaText) {
            $res['matchFormulaText'] = $this->matchFormulaText;
        }
        if (null !== $this->scope) {
            $res['scope'] = $this->scope;
        }
        if (null !== $this->unionCells) {
            $res['unionCells'] = $this->unionCells;
        }
        if (null !== $this->useRegExp) {
            $res['useRegExp'] = $this->useRegExp;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return findOptions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['includeHidden'])) {
            $model->includeHidden = $map['includeHidden'];
        }
        if (isset($map['matchCase'])) {
            $model->matchCase = $map['matchCase'];
        }
        if (isset($map['matchEntireCell'])) {
            $model->matchEntireCell = $map['matchEntireCell'];
        }
        if (isset($map['matchFormulaText'])) {
            $model->matchFormulaText = $map['matchFormulaText'];
        }
        if (isset($map['scope'])) {
            $model->scope = $map['scope'];
        }
        if (isset($map['unionCells'])) {
            $model->unionCells = $map['unionCells'];
        }
        if (isset($map['useRegExp'])) {
            $model->useRegExp = $map['useRegExp'];
        }

        return $model;
    }
}
