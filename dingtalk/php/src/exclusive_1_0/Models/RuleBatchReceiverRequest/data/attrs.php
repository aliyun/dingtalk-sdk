<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\RuleBatchReceiverRequest\data;

use AlibabaCloud\Tea\Model;

class attrs extends Model
{
    /**
     * @var int[]
     */
    public $listUnitId;
    protected $_name = [
        'listUnitId' => 'listUnitId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->listUnitId) {
            $res['listUnitId'] = $this->listUnitId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return attrs
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['listUnitId'])) {
            if (!empty($map['listUnitId'])) {
                $model->listUnitId = $map['listUnitId'];
            }
        }

        return $model;
    }
}
