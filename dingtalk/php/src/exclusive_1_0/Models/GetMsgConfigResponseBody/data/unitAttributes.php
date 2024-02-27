<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgConfigResponseBody\data;

use AlibabaCloud\Tea\Model;

class unitAttributes extends Model
{
    /**
     * @var int
     */
    public $unitId;
    protected $_name = [
        'unitId' => 'unitId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->unitId) {
            $res['unitId'] = $this->unitId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return unitAttributes
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['unitId'])) {
            $model->unitId = $map['unitId'];
        }

        return $model;
    }
}
