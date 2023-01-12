<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class SetColumnsVisibilityRequest extends Model
{
    /**
     * @description 要显示、隐藏的第一列的位置，从0开始。
     *
     * @var int
     */
    public $column;

    /**
     * @description 要显示、隐藏的列的数量。
     *
     * @var int
     */
    public $columnCount;

    /**
     * @description 列可见性
     * hidden: 隐藏
     * @var string
     */
    public $visibility;

    /**
     * @description 操作人id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'column'      => 'column',
        'columnCount' => 'columnCount',
        'visibility'  => 'visibility',
        'operatorId'  => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->column) {
            $res['column'] = $this->column;
        }
        if (null !== $this->columnCount) {
            $res['columnCount'] = $this->columnCount;
        }
        if (null !== $this->visibility) {
            $res['visibility'] = $this->visibility;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetColumnsVisibilityRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['column'])) {
            $model->column = $map['column'];
        }
        if (isset($map['columnCount'])) {
            $model->columnCount = $map['columnCount'];
        }
        if (isset($map['visibility'])) {
            $model->visibility = $map['visibility'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
