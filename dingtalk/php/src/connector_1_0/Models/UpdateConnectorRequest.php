<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\UpdateConnectorRequest\connectorInfo;
use AlibabaCloud\Tea\Model;

class UpdateConnectorRequest extends Model
{
    /**
     * @var connectorInfo[]
     */
    public $connectorInfo;

    /**
     * @var string
     */
    public $integratorFlag;
    protected $_name = [
        'connectorInfo'  => 'connectorInfo',
        'integratorFlag' => 'integratorFlag',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->connectorInfo) {
            $res['connectorInfo'] = [];
            if (null !== $this->connectorInfo && \is_array($this->connectorInfo)) {
                $n = 0;
                foreach ($this->connectorInfo as $item) {
                    $res['connectorInfo'][$n++] = null !== $item ? $item->toMap() : $item;
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
     * @return UpdateConnectorRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['connectorInfo'])) {
            if (!empty($map['connectorInfo'])) {
                $model->connectorInfo = [];
                $n                    = 0;
                foreach ($map['connectorInfo'] as $item) {
                    $model->connectorInfo[$n++] = null !== $item ? connectorInfo::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['integratorFlag'])) {
            $model->integratorFlag = $map['integratorFlag'];
        }

        return $model;
    }
}
