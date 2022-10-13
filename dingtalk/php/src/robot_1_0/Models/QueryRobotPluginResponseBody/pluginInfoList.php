<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\QueryRobotPluginResponseBody;

use AlibabaCloud\Tea\Model;

class pluginInfoList extends Model
{
    /**
     * @description 快捷入口的图标id
     *
     * @var string
     */
    public $icon;

    /**
     * @description 手机端快捷入口跳转链接
     *
     * @var string
     */
    public $mobileUrl;

    /**
     * @description 快捷入口的名称
     *
     * @var string
     */
    public $name;

    /**
     * @description pc端会话快捷入口跳转链接
     *
     * @var string
     */
    public $pcUrl;
    protected $_name = [
        'icon'      => 'icon',
        'mobileUrl' => 'mobileUrl',
        'name'      => 'name',
        'pcUrl'     => 'pcUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->mobileUrl) {
            $res['mobileUrl'] = $this->mobileUrl;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->pcUrl) {
            $res['pcUrl'] = $this->pcUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return pluginInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['mobileUrl'])) {
            $model->mobileUrl = $map['mobileUrl'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['pcUrl'])) {
            $model->pcUrl = $map['pcUrl'];
        }

        return $model;
    }
}
