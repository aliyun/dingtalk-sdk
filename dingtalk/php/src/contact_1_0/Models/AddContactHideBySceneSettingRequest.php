<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\AddContactHideBySceneSettingRequest\nodeListSceneConfig;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\AddContactHideBySceneSettingRequest\profileSceneConfig;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\AddContactHideBySceneSettingRequest\searchSceneConfig;
use AlibabaCloud\Tea\Model;

class AddContactHideBySceneSettingRequest extends Model
{
    /**
     * @description 设置描述信息
     *
     * @var string
     */
    public $description;

    /**
     * @description 允许查看的部门列表
     *
     * @var int[]
     */
    public $excludeDeptIds;

    /**
     * @description 允许查看的角色列表
     *
     * @var int[]
     */
    public $excludeTagIds;

    /**
     * @description 允许查看的员工列表
     *
     * @var string[]
     */
    public $excludeUserIds;

    /**
     * @description 设置名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 浏览组织架构与选人组件场景下的配置
     *
     * @var nodeListSceneConfig
     */
    public $nodeListSceneConfig;

    /**
     * @description 被隐藏的部门列表
     *
     * @var int[]
     */
    public $objectDeptIds;

    /**
     * @description 被隐藏的角色列表
     *
     * @var int[]
     */
    public $objectTagIds;

    /**
     * @description 被隐藏的员工UserId列表
     *
     * @var string[]
     */
    public $objectUserIds;

    /**
     * @description 用户详情场景下的配置
     *
     * @var profileSceneConfig
     */
    public $profileSceneConfig;

    /**
     * @description 搜索的场景配置（包括搜索部门、搜索员工）
     *
     * @var searchSceneConfig
     */
    public $searchSceneConfig;
    protected $_name = [
        'description'         => 'description',
        'excludeDeptIds'      => 'excludeDeptIds',
        'excludeTagIds'       => 'excludeTagIds',
        'excludeUserIds'      => 'excludeUserIds',
        'name'                => 'name',
        'nodeListSceneConfig' => 'nodeListSceneConfig',
        'objectDeptIds'       => 'objectDeptIds',
        'objectTagIds'        => 'objectTagIds',
        'objectUserIds'       => 'objectUserIds',
        'profileSceneConfig'  => 'profileSceneConfig',
        'searchSceneConfig'   => 'searchSceneConfig',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->excludeDeptIds) {
            $res['excludeDeptIds'] = $this->excludeDeptIds;
        }
        if (null !== $this->excludeTagIds) {
            $res['excludeTagIds'] = $this->excludeTagIds;
        }
        if (null !== $this->excludeUserIds) {
            $res['excludeUserIds'] = $this->excludeUserIds;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nodeListSceneConfig) {
            $res['nodeListSceneConfig'] = null !== $this->nodeListSceneConfig ? $this->nodeListSceneConfig->toMap() : null;
        }
        if (null !== $this->objectDeptIds) {
            $res['objectDeptIds'] = $this->objectDeptIds;
        }
        if (null !== $this->objectTagIds) {
            $res['objectTagIds'] = $this->objectTagIds;
        }
        if (null !== $this->objectUserIds) {
            $res['objectUserIds'] = $this->objectUserIds;
        }
        if (null !== $this->profileSceneConfig) {
            $res['profileSceneConfig'] = null !== $this->profileSceneConfig ? $this->profileSceneConfig->toMap() : null;
        }
        if (null !== $this->searchSceneConfig) {
            $res['searchSceneConfig'] = null !== $this->searchSceneConfig ? $this->searchSceneConfig->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddContactHideBySceneSettingRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
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
        if (isset($map['excludeUserIds'])) {
            if (!empty($map['excludeUserIds'])) {
                $model->excludeUserIds = $map['excludeUserIds'];
            }
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nodeListSceneConfig'])) {
            $model->nodeListSceneConfig = nodeListSceneConfig::fromMap($map['nodeListSceneConfig']);
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
        if (isset($map['objectUserIds'])) {
            if (!empty($map['objectUserIds'])) {
                $model->objectUserIds = $map['objectUserIds'];
            }
        }
        if (isset($map['profileSceneConfig'])) {
            $model->profileSceneConfig = profileSceneConfig::fromMap($map['profileSceneConfig']);
        }
        if (isset($map['searchSceneConfig'])) {
            $model->searchSceneConfig = searchSceneConfig::fromMap($map['searchSceneConfig']);
        }

        return $model;
    }
}
