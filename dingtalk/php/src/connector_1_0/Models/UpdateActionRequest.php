<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\UpdateActionRequest\actionInfo;
use AlibabaCloud\Tea\Model;

class UpdateActionRequest extends Model
{
    /**
     * @var actionInfo[]
     */
    public $actionInfo;

    /**
     * @var string
     */
    public $integratorFlag;
    protected $_name = [
        'actionInfo'     => 'actionInfo',
        'integratorFlag' => 'integratorFlag',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionInfo) {
            $res['actionInfo'] = [];
            if (null !== $this->actionInfo && \is_array($this->actionInfo)) {
                $n = 0;
                foreach ($this->actionInfo as $item) {
                    $res['actionInfo'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->integratorFlag) {
            $res['integratorFlag'] = $this->integratorFlag;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateActionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionInfo'])) {
            if (!empty($map['actionInfo'])) {
                $model->actionInfo = [];
                $n                 = 0;
                foreach ($map['actionInfo'] as $item) {
                    $model->actionInfo[$n++] = null !== $item ? actionInfo::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['integratorFlag'])) {
            $model->integratorFlag = $map['integratorFlag'];
        }

        return $model;
    }
}
