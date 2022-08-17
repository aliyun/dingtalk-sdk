<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QuerySubscribeStatusResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QuerySubscribeStatusResponseBody\result\subscribeStatusDTOS;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 订阅详情列表
     *
     * @var subscribeStatusDTOS[]
     */
    public $subscribeStatusDTOS;
    protected $_name = [
        'subscribeStatusDTOS' => 'subscribeStatusDTOS',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->subscribeStatusDTOS) {
            $res['subscribeStatusDTOS'] = [];
            if (null !== $this->subscribeStatusDTOS && \is_array($this->subscribeStatusDTOS)) {
                $n = 0;
                foreach ($this->subscribeStatusDTOS as $item) {
                    $res['subscribeStatusDTOS'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['subscribeStatusDTOS'])) {
            if (!empty($map['subscribeStatusDTOS'])) {
                $model->subscribeStatusDTOS = [];
                $n                          = 0;
                foreach ($map['subscribeStatusDTOS'] as $item) {
                    $model->subscribeStatusDTOS[$n++] = null !== $item ? subscribeStatusDTOS::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
