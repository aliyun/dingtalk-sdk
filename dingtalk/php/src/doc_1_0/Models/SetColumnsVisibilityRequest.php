<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class SetColumnsVisibilityRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example column
     *
     * @var int
     */
    public $column;

    /**
     * @description This parameter is required.
     *
     * @example column_count
     *
     * @var int
     */
    public $columnCount;

    /**
     * @description This parameter is required.
     *
     * @example visible
     *
     * @var string
     */
    public $visibility;

    /**
     * @description This parameter is required.
     *
     * @example union_id
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
