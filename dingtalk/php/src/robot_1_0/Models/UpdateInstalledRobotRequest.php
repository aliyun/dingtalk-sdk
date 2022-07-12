<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateInstalledRobotRequest extends Model
{
    /**
     * @description 机器人的简要描述。
     *
     * @var string
     */
    public $brief;

    /**
     * @description 机器人的详细描述。
     *
     * @var string
     */
    public $description;

    /**
     * @description 机器人图标的mediaId。
     *
     * @var string
     */
    public $icon;

    /**
     * @description 机器人的名称。
     *
     * @var string
     */
    public $name;

    /**
     * @description 机器人的robotCode。
     *
     * @var string
     */
    public $robotCode;

    /**
     * @description 更新名字或头像时是否更新群里已添加机器人的名字或头像。
     * 1-更新群里机器人名字或头像
     * @var int
     */
    public $updateType;
    protected $_name = [
        'brief'       => 'brief',
        'description' => 'description',
        'icon'        => 'icon',
        'name'        => 'name',
        'robotCode'   => 'robotCode',
        'updateType'  => 'updateType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }
        if (null !== $this->updateType) {
            $res['updateType'] = $this->updateType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateInstalledRobotRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
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
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }
        if (isset($map['updateType'])) {
            $model->updateType = $map['updateType'];
        }

        return $model;
    }
}
