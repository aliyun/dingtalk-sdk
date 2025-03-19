<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\ConsumePointRequest\body;

use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\ConsumePointRequest\body\consumeDetail\benefit;
use AlibabaCloud\Tea\Model;

class consumeDetail extends Model
{
    /**
     * @var benefit
     */
    public $benefit;

    /**
     * @var string
     */
    public $type;
    protected $_name = [
        'benefit' => 'benefit',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->benefit) {
            $res['benefit'] = null !== $this->benefit ? $this->benefit->toMap() : null;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return consumeDetail
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['benefit'])) {
            $model->benefit = benefit::fromMap($map['benefit']);
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
