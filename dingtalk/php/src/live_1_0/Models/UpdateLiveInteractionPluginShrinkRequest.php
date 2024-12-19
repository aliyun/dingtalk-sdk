<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateLiveInteractionPluginShrinkRequest extends Model
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
     * @var string
     */
    public $pluginInfoShrink;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'liveId'           => 'liveId',
        'pluginId'         => 'pluginId',
        'pluginInfoShrink' => 'pluginInfo',
        'unionId'          => 'unionId',
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
        if (null !== $this->pluginInfoShrink) {
            $res['pluginInfo'] = $this->pluginInfoShrink;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateLiveInteractionPluginShrinkRequest
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
            $model->pluginInfoShrink = $map['pluginInfo'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
