<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetEmpAttributeHideBySceneSettingResponseBody\chatSubtitleConfig;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetEmpAttributeHideBySceneSettingResponseBody\profileSceneConfig;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetEmpAttributeHideBySceneSettingResponseBody\searchSceneConfig;
use AlibabaCloud\Tea\Model;

class GetEmpAttributeHideBySceneSettingResponseBody extends Model
{
    /**
     * @description 单聊副标题场景配置，开启时单聊中相关的员工字段不显示
     *
     * @var chatSubtitleConfig
     */
    public $chatSubtitleConfig;

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
     * @description 隐藏字段id列表
     * job_number：工号
     * @var string[]
     */
    public $hideFields;

    /**
     * @description 设置id
     *
     * @var int
     */
    public $id;

    /**
     * @description 设置名称
     *
     * @var string
     */
    public $name;

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
     * @description 用户资料页场景配置，开启时相关的员工字段不在资料页中显示
     *
     * @var profileSceneConfig
     */
    public $profileSceneConfig;

    /**
     * @description 搜索场景配置，开启时隐藏的字段不在搜索结果中展示，并且不允许根据这些字段搜索到。
     *
     * @var searchSceneConfig
     */
    public $searchSceneConfig;
    protected $_name = [
        'chatSubtitleConfig' => 'chatSubtitleConfig',
        'description'        => 'description',
        'excludeDeptIds'     => 'excludeDeptIds',
        'excludeTagIds'      => 'excludeTagIds',
        'excludeUserIds'     => 'excludeUserIds',
        'hideFields'         => 'hideFields',
        'id'                 => 'id',
        'name'               => 'name',
        'objectDeptIds'      => 'objectDeptIds',
        'objectTagIds'       => 'objectTagIds',
        'objectUserIds'      => 'objectUserIds',
        'profileSceneConfig' => 'profileSceneConfig',
        'searchSceneConfig'  => 'searchSceneConfig',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->chatSubtitleConfig) {
            $res['chatSubtitleConfig'] = null !== $this->chatSubtitleConfig ? $this->chatSubtitleConfig->toMap() : null;
        }
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
        if (null !== $this->hideFields) {
            $res['hideFields'] = $this->hideFields;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
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
     * @return GetEmpAttributeHideBySceneSettingResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['chatSubtitleConfig'])) {
            $model->chatSubtitleConfig = chatSubtitleConfig::fromMap($map['chatSubtitleConfig']);
        }
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
        if (isset($map['hideFields'])) {
            if (!empty($map['hideFields'])) {
                $model->hideFields = $map['hideFields'];
            }
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
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
