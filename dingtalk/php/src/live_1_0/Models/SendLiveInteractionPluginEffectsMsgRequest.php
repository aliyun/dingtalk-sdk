<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\SendLiveInteractionPluginEffectsMsgRequest\pluginEffectsMessage;
use AlibabaCloud\Tea\Model;

class SendLiveInteractionPluginEffectsMsgRequest extends Model
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
     * @var pluginEffectsMessage
     */
    public $pluginEffectsMessage;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $pluginId;
    protected $_name = [
        'liveId'               => 'liveId',
        'pluginEffectsMessage' => 'pluginEffectsMessage',
        'pluginId'             => 'pluginId',
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
        if (null !== $this->pluginEffectsMessage) {
            $res['pluginEffectsMessage'] = null !== $this->pluginEffectsMessage ? $this->pluginEffectsMessage->toMap() : null;
        }
        if (null !== $this->pluginId) {
            $res['pluginId'] = $this->pluginId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendLiveInteractionPluginEffectsMsgRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['liveId'])) {
            $model->liveId = $map['liveId'];
        }
        if (isset($map['pluginEffectsMessage'])) {
            $model->pluginEffectsMessage = pluginEffectsMessage::fromMap($map['pluginEffectsMessage']);
        }
        if (isset($map['pluginId'])) {
            $model->pluginId = $map['pluginId'];
        }

        return $model;
    }
}
