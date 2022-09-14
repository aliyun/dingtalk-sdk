<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CreateTeamRequest\members;
use AlibabaCloud\Tea\Model;

class CreateTeamRequest extends Model
{
    /**
     * @description 小组封面。
     *
     * @var string
     */
    public $cover;

    /**
     * @description 小组介绍。
     *
     * @var string
     */
    public $description;

    /**
     * @description 小组图标。
     *
     * @var string
     */
    public $icon;

    /**
     * @description 小组成员列表。
     *
     * @var members[]
     */
    public $members;

    /**
     * @description 小组名称。
     *
     * @var string
     */
    public $name;

    /**
     * @description 操作人unionId。
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description 小组类型。
     * 3-兴趣小组。
     * @var int
     */
    public $teamType;
    protected $_name = [
        'cover'       => 'cover',
        'description' => 'description',
        'icon'        => 'icon',
        'members'     => 'members',
        'name'        => 'name',
        'operatorId'  => 'operatorId',
        'teamType'    => 'teamType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cover) {
            $res['cover'] = $this->cover;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->members) {
            $res['members'] = [];
            if (null !== $this->members && \is_array($this->members)) {
                $n = 0;
                foreach ($this->members as $item) {
                    $res['members'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->teamType) {
            $res['teamType'] = $this->teamType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTeamRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cover'])) {
            $model->cover = $map['cover'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['members'])) {
            if (!empty($map['members'])) {
                $model->members = [];
                $n              = 0;
                foreach ($map['members'] as $item) {
                    $model->members[$n++] = null !== $item ? members::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['teamType'])) {
            $model->teamType = $map['teamType'];
        }

        return $model;
    }
}
