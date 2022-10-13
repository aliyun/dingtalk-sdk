<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\SetRobotPluginRequest\pluginInfoList;
use AlibabaCloud\Tea\Model;

class SetRobotPluginRequest extends Model
{
    /**
     * @var pluginInfoList[]
     */
    public $pluginInfoList;

    /**
     * @description 钉钉开放平台后台机器人的robotCode
     *
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'pluginInfoList' => 'pluginInfoList',
        'robotCode'      => 'robotCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pluginInfoList) {
            $res['pluginInfoList'] = [];
            if (null !== $this->pluginInfoList && \is_array($this->pluginInfoList)) {
                $n = 0;
                foreach ($this->pluginInfoList as $item) {
                    $res['pluginInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetRobotPluginRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pluginInfoList'])) {
            if (!empty($map['pluginInfoList'])) {
                $model->pluginInfoList = [];
                $n                     = 0;
                foreach ($map['pluginInfoList'] as $item) {
                    $model->pluginInfoList[$n++] = null !== $item ? pluginInfoList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}
