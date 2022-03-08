<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateOfficialAccountRobotInfoRequest extends Model
{
    /**
     * @description 机器人头像
     *
     * @var string
     */
    public $avatar;

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

    /**
     * @description 机器人类型参数
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'avatar'          => 'avatar',
        'brief'           => 'brief',
        'description'     => 'description',
        'name'            => 'name',
        'previewMediaUrl' => 'previewMediaUrl',
        'type'            => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->avatar) {
            $res['avatar'] = $this->avatar;
        }
        if (null !== $this->brief) {
            $res['brief'] = $this->brief;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->previewMediaUrl) {
            $res['previewMediaUrl'] = $this->previewMediaUrl;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateOfficialAccountRobotInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatar'])) {
            $model->avatar = $map['avatar'];
        }
        if (isset($map['brief'])) {
            $model->brief = $map['brief'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['previewMediaUrl'])) {
            $model->previewMediaUrl = $map['previewMediaUrl'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
