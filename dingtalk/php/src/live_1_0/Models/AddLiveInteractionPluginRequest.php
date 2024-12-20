<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddLiveInteractionPluginRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $anchorJumpUrl;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $pluginIconUrl;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $pluginName;

    /**
     * @var string
     */
    public $pluginNameEn;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $viewerJumpUrl;

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
    public $unionId;
    protected $_name = [
        'anchorJumpUrl' => 'anchorJumpUrl',
        'pluginIconUrl' => 'pluginIconUrl',
        'pluginName'    => 'pluginName',
        'pluginNameEn'  => 'pluginNameEn',
        'viewerJumpUrl' => 'viewerJumpUrl',
        'liveId'        => 'liveId',
        'unionId'       => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->anchorJumpUrl) {
            $res['anchorJumpUrl'] = $this->anchorJumpUrl;
        }
        if (null !== $this->pluginIconUrl) {
            $res['pluginIconUrl'] = $this->pluginIconUrl;
        }
        if (null !== $this->pluginName) {
            $res['pluginName'] = $this->pluginName;
        }
        if (null !== $this->pluginNameEn) {
            $res['pluginNameEn'] = $this->pluginNameEn;
        }
        if (null !== $this->viewerJumpUrl) {
            $res['viewerJumpUrl'] = $this->viewerJumpUrl;
        }
        if (null !== $this->liveId) {
            $res['liveId'] = $this->liveId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddLiveInteractionPluginRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['anchorJumpUrl'])) {
            $model->anchorJumpUrl = $map['anchorJumpUrl'];
        }
        if (isset($map['pluginIconUrl'])) {
            $model->pluginIconUrl = $map['pluginIconUrl'];
        }
        if (isset($map['pluginName'])) {
            $model->pluginName = $map['pluginName'];
        }
        if (isset($map['pluginNameEn'])) {
            $model->pluginNameEn = $map['pluginNameEn'];
        }
        if (isset($map['viewerJumpUrl'])) {
            $model->viewerJumpUrl = $map['viewerJumpUrl'];
        }
        if (isset($map['liveId'])) {
            $model->liveId = $map['liveId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
