<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\AssignOrgHoldingToEmpHoldingBatchResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\AssignOrgHoldingToEmpHoldingBatchResponseBody\result\openPointInvokeResultDTOS;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 每个人发放的结果
     *
     * @var openPointInvokeResultDTOS[]
     */
    public $openPointInvokeResultDTOS;
    protected $_name = [
        'openPointInvokeResultDTOS' => 'openPointInvokeResultDTOS',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openPointInvokeResultDTOS) {
            $res['openPointInvokeResultDTOS'] = [];
            if (null !== $this->openPointInvokeResultDTOS && \is_array($this->openPointInvokeResultDTOS)) {
                $n = 0;
                foreach ($this->openPointInvokeResultDTOS as $item) {
                    $res['openPointInvokeResultDTOS'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['openPointInvokeResultDTOS'])) {
            if (!empty($map['openPointInvokeResultDTOS'])) {
                $model->openPointInvokeResultDTOS = [];
                $n                                = 0;
                foreach ($map['openPointInvokeResultDTOS'] as $item) {
                    $model->openPointInvokeResultDTOS[$n++] = null !== $item ? openPointInvokeResultDTOS::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
