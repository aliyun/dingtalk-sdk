<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateRangeProtectionRequest;

use AlibabaCloud\Tea\Model;

class editableSetting extends Model
{
    /**
     * @description 是否可删除列
     *
     * @var bool
     */
    public $deleteColumns;

    /**
     * @description 是否可删除行
     *
     * @var bool
     */
    public $deleteRows;

    /**
     * @description 是否可修改单元格的值
     *
     * @var bool
     */
    public $editCells;

    /**
     * @description 是否可修改单元格样式
     *
     * @var bool
     */
    public $formatCells;

    /**
     * @description 是否可插入列
     *
     * @var bool
     */
    public $insertColumns;

    /**
     * @description 是否可插入行
     *
     * @var bool
     */
    public $insertRows;

    /**
     * @description 是否可显示、隐藏列
     *
     * @var bool
     */
    public $toggleColumnsVisibility;

    /**
     * @description 是否可显示、隐藏行
     *
     * @var bool
     */
    public $toggleRowsVisibility;
    protected $_name = [
        'deleteColumns'           => 'deleteColumns',
        'deleteRows'              => 'deleteRows',
        'editCells'               => 'editCells',
        'formatCells'             => 'formatCells',
        'insertColumns'           => 'insertColumns',
        'insertRows'              => 'insertRows',
        'toggleColumnsVisibility' => 'toggleColumnsVisibility',
        'toggleRowsVisibility'    => 'toggleRowsVisibility',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deleteColumns) {
            $res['deleteColumns'] = $this->deleteColumns;
        }
        if (null !== $this->deleteRows) {
            $res['deleteRows'] = $this->deleteRows;
        }
        if (null !== $this->editCells) {
            $res['editCells'] = $this->editCells;
        }
        if (null !== $this->formatCells) {
            $res['formatCells'] = $this->formatCells;
        }
        if (null !== $this->insertColumns) {
            $res['insertColumns'] = $this->insertColumns;
        }
        if (null !== $this->insertRows) {
            $res['insertRows'] = $this->insertRows;
        }
        if (null !== $this->toggleColumnsVisibility) {
            $res['toggleColumnsVisibility'] = $this->toggleColumnsVisibility;
        }
        if (null !== $this->toggleRowsVisibility) {
            $res['toggleRowsVisibility'] = $this->toggleRowsVisibility;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return editableSetting
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deleteColumns'])) {
            $model->deleteColumns = $map['deleteColumns'];
        }
        if (isset($map['deleteRows'])) {
            $model->deleteRows = $map['deleteRows'];
        }
        if (isset($map['editCells'])) {
            $model->editCells = $map['editCells'];
        }
        if (isset($map['formatCells'])) {
            $model->formatCells = $map['formatCells'];
        }
        if (isset($map['insertColumns'])) {
            $model->insertColumns = $map['insertColumns'];
        }
        if (isset($map['insertRows'])) {
            $model->insertRows = $map['insertRows'];
        }
        if (isset($map['toggleColumnsVisibility'])) {
            $model->toggleColumnsVisibility = $map['toggleColumnsVisibility'];
        }
        if (isset($map['toggleRowsVisibility'])) {
            $model->toggleRowsVisibility = $map['toggleRowsVisibility'];
        }

        return $model;
    }
}
