<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPrivateStoreCapacityUsageResponseBody extends Model
{
    /**
     * @var int
     */
    public $usedSize;
    protected $_name = [
        'usedSize' => 'usedSize',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->usedSize) {
            $res['usedSize'] = $this->usedSize;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPrivateStoreCapacityUsageResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['usedSize'])) {
            $model->usedSize = $map['usedSize'];
        }

        return $model;
    }
}
