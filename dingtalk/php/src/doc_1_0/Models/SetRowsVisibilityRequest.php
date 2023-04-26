<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class SetRowsVisibilityRequest extends Model
{
    /**
     * @example row
     *
     * @var int
     */
    public $row;

    /**
     * @example row_count
     *
     * @var int
     */
    public $rowCount;

    /**
     * @example visible
     *
     * @var string
     */
    public $visibility;

    /**
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'row'        => 'row',
        'rowCount'   => 'rowCount',
        'visibility' => 'visibility',
        'operatorId' => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->row) {
            $res['row'] = $this->row;
        }
        if (null !== $this->rowCount) {
            $res['rowCount'] = $this->rowCount;
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
     * @return SetRowsVisibilityRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['row'])) {
            $model->row = $map['row'];
        }
        if (isset($map['rowCount'])) {
            $model->rowCount = $map['rowCount'];
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
