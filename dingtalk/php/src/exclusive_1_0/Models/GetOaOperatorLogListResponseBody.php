<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOaOperatorLogListResponseBody\data;
use AlibabaCloud\Tea\Model;

class GetOaOperatorLogListResponseBody extends Model
{
    /**
     * @var data[]
     */
    public $data;

    /**
     * @description 当前获取记录数
     *
     * @var int
     */
    public $itemCount;
    protected $_name = [
        'data'      => 'data',
        'itemCount' => 'itemCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->data) {
            $res['data'] = [];
            if (null !== $this->data && \is_array($this->data)) {
                $n = 0;
                foreach ($this->data as $item) {
                    $res['data'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->itemCount) {
            $res['itemCount'] = $this->itemCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOaOperatorLogListResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['data'])) {
            if (!empty($map['data'])) {
                $model->data = [];
                $n           = 0;
                foreach ($map['data'] as $item) {
                    $model->data[$n++] = null !== $item ? data::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['itemCount'])) {
            $model->itemCount = $map['itemCount'];
        }

        return $model;
    }
}
