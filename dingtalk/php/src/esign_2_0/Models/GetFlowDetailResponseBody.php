<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetFlowDetailResponseBody\logs;
use AlibabaCloud\Tea\Model;

class GetFlowDetailResponseBody extends Model
{
    /**
     * @var string
     */
    public $businessScene;

    /**
     * @var float
     */
    public $flowStatus;

    /**
     * @var string
     */
    public $initiatorAuthorizedName;

    /**
     * @var string
     */
    public $initiatorName;

    /**
     * @var logs[]
     */
    public $logs;
    protected $_name = [
        'businessScene'           => 'businessScene',
        'flowStatus'              => 'flowStatus',
        'initiatorAuthorizedName' => 'initiatorAuthorizedName',
        'initiatorName'           => 'initiatorName',
        'logs'                    => 'logs',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->businessScene) {
            $res['businessScene'] = $this->businessScene;
        }
        if (null !== $this->flowStatus) {
            $res['flowStatus'] = $this->flowStatus;
        }
        if (null !== $this->initiatorAuthorizedName) {
            $res['initiatorAuthorizedName'] = $this->initiatorAuthorizedName;
        }
        if (null !== $this->initiatorName) {
            $res['initiatorName'] = $this->initiatorName;
        }
        if (null !== $this->logs) {
            $res['logs'] = [];
            if (null !== $this->logs && \is_array($this->logs)) {
                $n = 0;
                foreach ($this->logs as $item) {
                    $res['logs'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFlowDetailResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['businessScene'])) {
            $model->businessScene = $map['businessScene'];
        }
        if (isset($map['flowStatus'])) {
            $model->flowStatus = $map['flowStatus'];
        }
        if (isset($map['initiatorAuthorizedName'])) {
            $model->initiatorAuthorizedName = $map['initiatorAuthorizedName'];
        }
        if (isset($map['initiatorName'])) {
            $model->initiatorName = $map['initiatorName'];
        }
        if (isset($map['logs'])) {
            if (!empty($map['logs'])) {
                $model->logs = [];
                $n           = 0;
                foreach ($map['logs'] as $item) {
                    $model->logs[$n++] = null !== $item ? logs::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
