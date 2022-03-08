<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetOfficialAccountRobotInfoResponseBody extends Model
{
    /**
     * @description 机器人id
     *
     * @var int
     */
    public $appId;

    /**
     * @description 机器人简介
     *
     * @var string
     */
    public $brief;

    /**
     * @description 机器人描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 机器人icon
     *
     * @var string
     */
    public $icon;

    /**
     * @description 机器人名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 机器人预览图
     *
     * @var string
     */
    public $previewMediaUrl;
    protected $_name = [
        'appId'           => 'appId',
        'brief'           => 'brief',
        'description'     => 'description',
        'icon'            => 'icon',
        'name'            => 'name',
        'previewMediaUrl' => 'previewMediaUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->brief) {
            $res['brief'] = $this->brief;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->previewMediaUrl) {
            $res['previewMediaUrl'] = $this->previewMediaUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOfficialAccountRobotInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['brief'])) {
            $model->brief = $map['brief'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['previewMediaUrl'])) {
            $model->previewMediaUrl = $map['previewMediaUrl'];
        }

        return $model;
    }
}
