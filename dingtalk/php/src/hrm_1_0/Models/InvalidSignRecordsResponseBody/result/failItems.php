<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\InvalidSignRecordsResponseBody\result;

use AlibabaCloud\Tea\Model;

class failItems extends Model
{
    /**
     * @example 1234566789
     *
     * @var string
     */
    public $itemId;

    /**
     * @example 电子签状态变更不合法
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'itemId' => 'itemId',
        'type'   => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->itemId) {
            $res['itemId'] = $this->itemId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return failItems
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['itemId'])) {
            $model->itemId = $map['itemId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
