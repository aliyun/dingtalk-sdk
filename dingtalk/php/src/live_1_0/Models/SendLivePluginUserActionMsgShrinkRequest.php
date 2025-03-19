<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendLivePluginUserActionMsgShrinkRequest extends Model
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
    public $pluginEffectsMessageShrink;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $pluginId;
    protected $_name = [
        'liveId' => 'liveId',
        'pluginEffectsMessageShrink' => 'pluginEffectsMessage',
        'pluginId' => 'pluginId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->liveId) {
            $res['liveId'] = $this->liveId;
        }
        if (null !== $this->pluginEffectsMessageShrink) {
            $res['pluginEffectsMessage'] = $this->pluginEffectsMessageShrink;
        }
        if (null !== $this->pluginId) {
            $res['pluginId'] = $this->pluginId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendLivePluginUserActionMsgShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['liveId'])) {
            $model->liveId = $map['liveId'];
        }
        if (isset($map['pluginEffectsMessage'])) {
            $model->pluginEffectsMessageShrink = $map['pluginEffectsMessage'];
        }
        if (isset($map['pluginId'])) {
            $model->pluginId = $map['pluginId'];
        }

        return $model;
    }
}
