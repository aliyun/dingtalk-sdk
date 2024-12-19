<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\UpdateLiveInteractionPluginRequest\pluginInfo;
use AlibabaCloud\Tea\Model;

class UpdateLiveInteractionPluginRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $liveId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $pluginId;

    /**
     * @description This parameter is required.
     *
     * @var pluginInfo
     */
    public $pluginInfo;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'liveId'     => 'liveId',
        'pluginId'   => 'pluginId',
        'pluginInfo' => 'pluginInfo',
        'unionId'    => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->liveId) {
            $res['liveId'] = $this->liveId;
        }
        if (null !== $this->pluginId) {
            $res['pluginId'] = $this->pluginId;
        }
        if (null !== $this->pluginInfo) {
            $res['pluginInfo'] = null !== $this->pluginInfo ? $this->pluginInfo->toMap() : null;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateLiveInteractionPluginRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['liveId'])) {
            $model->liveId = $map['liveId'];
        }
        if (isset($map['pluginId'])) {
            $model->pluginId = $map['pluginId'];
        }
        if (isset($map['pluginInfo'])) {
            $model->pluginInfo = pluginInfo::fromMap($map['pluginInfo']);
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
