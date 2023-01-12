<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class InsertColumnsBeforeRequest extends Model
{
    /**
     * @description 要插入列的位置，从0开始。
     *
     * @var int
     */
    public $column;

    /**
     * @description 要插入列的数量。
     *
     * @var int
     */
    public $columnCount;

    /**
     * @description 操作人id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'column'      => 'column',
        'columnCount' => 'columnCount',
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
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InsertColumnsBeforeRequest
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
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
