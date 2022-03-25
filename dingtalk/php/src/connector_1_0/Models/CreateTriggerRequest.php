<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateTriggerRequest\triggerInfo;
use AlibabaCloud\Tea\Model;

class CreateTriggerRequest extends Model
{
    /**
     * @var string
     */
    public $integratorFlag;

    /**
     * @var triggerInfo[]
     */
    public $triggerInfo;
    protected $_name = [
        'integratorFlag' => 'integratorFlag',
        'triggerInfo'    => 'triggerInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->integratorFlag) {
            $res['integratorFlag'] = $this->integratorFlag;
        }
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
     * @return CreateTriggerRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['integratorFlag'])) {
            $model->integratorFlag = $map['integratorFlag'];
        }
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
