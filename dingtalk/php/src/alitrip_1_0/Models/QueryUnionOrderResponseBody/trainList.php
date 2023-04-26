<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryUnionOrderResponseBody;

use AlibabaCloud\Tea\Model;

class trainList extends Model
{
    /**
     * @example 231231
     *
     * @var int
     */
    public $trainOrderId;

    /**
     * @example 1
     *
     * @var int
     */
    public $trainOrderstatus;
    protected $_name = [
        'trainOrderId'     => 'trainOrderId',
        'trainOrderstatus' => 'trainOrderstatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->trainOrderId) {
            $res['trainOrderId'] = $this->trainOrderId;
        }
        if (null !== $this->trainOrderstatus) {
            $res['trainOrderstatus'] = $this->trainOrderstatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return trainList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['trainOrderId'])) {
            $model->trainOrderId = $map['trainOrderId'];
        }
        if (isset($map['trainOrderstatus'])) {
            $model->trainOrderstatus = $map['trainOrderstatus'];
        }

        return $model;
    }
}
