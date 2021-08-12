<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListEmpAttributeVisibilityResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description id
     *
     * @var int
     */
    public $id;

    /**
     * @description 设置时间
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description 修改时间
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @description 名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 设置描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 被查看的用户id列表
     *
     * @var string[]
     */
    public $objectStaffIds;

    /**
     * @description 被查看的部门id列表
     *
     * @var int[]
     */
    public $objectDeptIds;

    /**
     * @description 被查看的角色id列表
     *
     * @var int[]
     */
    public $objectTagIds;

    /**
     * @description 隐藏的字段id列表
     *
     * @var string[]
     */
    public $hideFields;

    /**
     * @description 白名单用户id列表
     *
     * @var string[]
     */
    public $excludeStaffIds;

    /**
     * @description 白名单部门id列表
     *
     * @var int[]
     */
    public $excludeDeptIds;

    /**
     * @description 白名单角色id列表
     *
     * @var int[]
     */
    public $excludeTagIds;

    /**
     * @description 是否生效
     *
     * @var bool
     */
    public $active;
    protected $_name = [
        'id'              => 'id',
        'gmtCreate'       => 'gmtCreate',
        'gmtModified'     => 'gmtModified',
        'name'            => 'name',
        'description'     => 'description',
        'objectStaffIds'  => 'objectStaffIds',
        'objectDeptIds'   => 'objectDeptIds',
        'objectTagIds'    => 'objectTagIds',
        'hideFields'      => 'hideFields',
        'excludeStaffIds' => 'excludeStaffIds',
        'excludeDeptIds'  => 'excludeDeptIds',
        'excludeTagIds'   => 'excludeTagIds',
        'active'          => 'active',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->objectStaffIds) {
            $res['objectStaffIds'] = $this->objectStaffIds;
        }
        if (null !== $this->objectDeptIds) {
            $res['objectDeptIds'] = $this->objectDeptIds;
        }
        if (null !== $this->objectTagIds) {
            $res['objectTagIds'] = $this->objectTagIds;
        }
        if (null !== $this->hideFields) {
            $res['hideFields'] = $this->hideFields;
        }
        if (null !== $this->excludeStaffIds) {
            $res['excludeStaffIds'] = $this->excludeStaffIds;
        }
        if (null !== $this->excludeDeptIds) {
            $res['excludeDeptIds'] = $this->excludeDeptIds;
        }
        if (null !== $this->excludeTagIds) {
            $res['excludeTagIds'] = $this->excludeTagIds;
        }
        if (null !== $this->active) {
            $res['active'] = $this->active;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['objectStaffIds'])) {
            if (!empty($map['objectStaffIds'])) {
                $model->objectStaffIds = $map['objectStaffIds'];
            }
        }
        if (isset($map['objectDeptIds'])) {
            if (!empty($map['objectDeptIds'])) {
                $model->objectDeptIds = $map['objectDeptIds'];
            }
        }
        if (isset($map['objectTagIds'])) {
            if (!empty($map['objectTagIds'])) {
                $model->objectTagIds = $map['objectTagIds'];
            }
        }
        if (isset($map['hideFields'])) {
            if (!empty($map['hideFields'])) {
                $model->hideFields = $map['hideFields'];
            }
        }
        if (isset($map['excludeStaffIds'])) {
            if (!empty($map['excludeStaffIds'])) {
                $model->excludeStaffIds = $map['excludeStaffIds'];
            }
        }
        if (isset($map['excludeDeptIds'])) {
            if (!empty($map['excludeDeptIds'])) {
                $model->excludeDeptIds = $map['excludeDeptIds'];
            }
        }
        if (isset($map['excludeTagIds'])) {
            if (!empty($map['excludeTagIds'])) {
                $model->excludeTagIds = $map['excludeTagIds'];
            }
        }
        if (isset($map['active'])) {
            $model->active = $map['active'];
        }

        return $model;
    }
}
