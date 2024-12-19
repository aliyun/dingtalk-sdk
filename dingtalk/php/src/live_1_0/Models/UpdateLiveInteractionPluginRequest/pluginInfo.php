<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\UpdateLiveInteractionPluginRequest;

use AlibabaCloud\Tea\Model;

class pluginInfo extends Model
{
    /**
     * @var string
     */
    public $anchorJumpUrl;

    /**
     * @var string
     */
    public $pluginIconUrl;

    /**
     * @var string
     */
    public $pluginName;

    /**
     * @var string
     */
    public $pluginNameEn;

    /**
     * @var string
     */
    public $viewerJumpUrl;
    protected $_name = [
        'anchorJumpUrl' => 'anchorJumpUrl',
        'pluginIconUrl' => 'pluginIconUrl',
        'pluginName'    => 'pluginName',
        'pluginNameEn'  => 'pluginNameEn',
        'viewerJumpUrl' => 'viewerJumpUrl',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return pluginInfo
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

        return $model;
    }
}
