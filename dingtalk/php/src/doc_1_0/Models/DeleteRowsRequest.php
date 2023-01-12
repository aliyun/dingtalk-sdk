<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteRowsRequest extends Model
{
    /**
     * @description 要删除的第一行的位置，从0开始。
     *
     * @var int
     */
    public $row;

    /**
     * @description 要删除的行的数量。
     *
     * @var int
     */
    public $rowCount;

    /**
     * @description 操作人id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'row'        => 'row',
        'rowCount'   => 'rowCount',
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
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteRowsRequest
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
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
