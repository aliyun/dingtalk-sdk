<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\UpdateTriggerRequest\triggerInfo;
use AlibabaCloud\Tea\Model;

class UpdateTriggerRequest extends Model
{
    /**
     * @var triggerInfo[]
     */
    public $triggerInfo;
    protected $_name = [
        'triggerInfo' => 'triggerInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->triggerInfo) {
            $res['triggerInfo'] = [];
            if (null !== $this->triggerInfo && \is_array($this->triggerInfo)) {
                $n = 0;
                foreach ($this->triggerInfo as $item) {
                    $res['triggerInfo'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateTriggerRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['triggerInfo'])) {
            if (!empty($map['triggerInfo'])) {
                $model->triggerInfo = [];
                $n                  = 0;
                foreach ($map['triggerInfo'] as $item) {
                    $model->triggerInfo[$n++] = null !== $item ? triggerInfo::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
