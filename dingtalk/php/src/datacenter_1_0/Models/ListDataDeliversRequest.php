<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListDataDeliversRequest extends Model
{
    /**
     * @example RT
     *
     * @var string
     */
    public $dispatchingItemType;
    protected $_name = [
        'dispatchingItemType' => 'dispatchingItemType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dispatchingItemType) {
            $res['dispatchingItemType'] = $this->dispatchingItemType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListDataDeliversRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dispatchingItemType'])) {
            $model->dispatchingItemType = $map['dispatchingItemType'];
        }

        return $model;
    }
}
