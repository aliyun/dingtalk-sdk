<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgConfigResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgConfigResponseBody\data\groupAttributes;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgConfigResponseBody\data\msgConfigs;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgConfigResponseBody\data\receiverAttributes;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgConfigResponseBody\data\unitAttributes;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var groupAttributes[]
     */
    public $groupAttributes;

    /**
     * @var msgConfigs
     */
    public $msgConfigs;

    /**
     * @var receiverAttributes[]
     */
    public $receiverAttributes;

    /**
     * @var unitAttributes[]
     */
    public $unitAttributes;
    protected $_name = [
        'groupAttributes'    => 'groupAttributes',
        'msgConfigs'         => 'msgConfigs',
        'receiverAttributes' => 'receiverAttributes',
        'unitAttributes'     => 'unitAttributes',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupAttributes) {
            $res['groupAttributes'] = [];
            if (null !== $this->groupAttributes && \is_array($this->groupAttributes)) {
                $n = 0;
                foreach ($this->groupAttributes as $item) {
                    $res['groupAttributes'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->msgConfigs) {
            $res['msgConfigs'] = null !== $this->msgConfigs ? $this->msgConfigs->toMap() : null;
        }
        if (null !== $this->receiverAttributes) {
            $res['receiverAttributes'] = [];
            if (null !== $this->receiverAttributes && \is_array($this->receiverAttributes)) {
                $n = 0;
                foreach ($this->receiverAttributes as $item) {
                    $res['receiverAttributes'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->unitAttributes) {
            $res['unitAttributes'] = [];
            if (null !== $this->unitAttributes && \is_array($this->unitAttributes)) {
                $n = 0;
                foreach ($this->unitAttributes as $item) {
                    $res['unitAttributes'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupAttributes'])) {
            if (!empty($map['groupAttributes'])) {
                $model->groupAttributes = [];
                $n                      = 0;
                foreach ($map['groupAttributes'] as $item) {
                    $model->groupAttributes[$n++] = null !== $item ? groupAttributes::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['msgConfigs'])) {
            $model->msgConfigs = msgConfigs::fromMap($map['msgConfigs']);
        }
        if (isset($map['receiverAttributes'])) {
            if (!empty($map['receiverAttributes'])) {
                $model->receiverAttributes = [];
                $n                         = 0;
                foreach ($map['receiverAttributes'] as $item) {
                    $model->receiverAttributes[$n++] = null !== $item ? receiverAttributes::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['unitAttributes'])) {
            if (!empty($map['unitAttributes'])) {
                $model->unitAttributes = [];
                $n                     = 0;
                foreach ($map['unitAttributes'] as $item) {
                    $model->unitAttributes[$n++] = null !== $item ? unitAttributes::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
