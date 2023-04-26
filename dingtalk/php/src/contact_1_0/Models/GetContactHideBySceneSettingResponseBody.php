<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetContactHideBySceneSettingResponseBody\nodeListSceneConfig;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetContactHideBySceneSettingResponseBody\profileSceneConfig;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetContactHideBySceneSettingResponseBody\searchSceneConfig;
use AlibabaCloud\Tea\Model;

class GetContactHideBySceneSettingResponseBody extends Model
{
    /**
     * @example description info
     *
     * @var string
     */
    public $description;

    /**
     * @var int[]
     */
    public $excludeDeptIds;

    /**
     * @var int[]
     */
    public $excludeTagIds;

    /**
     * @var string[]
     */
    public $excludeUserIds;

    /**
     * @example 123456
     *
     * @var int
     */
    public $id;

    /**
     * @example abc
     *
     * @var string
     */
    public $name;

    /**
     * @var nodeListSceneConfig
     */
    public $nodeListSceneConfig;

    /**
     * @var int[]
     */
    public $objectDeptIds;

    /**
     * @var int[]
     */
    public $objectTagIds;

    /**
     * @var string[]
     */
    public $objectUserIds;

    /**
     * @var profileSceneConfig
     */
    public $profileSceneConfig;

    /**
     * @var searchSceneConfig
     */
    public $searchSceneConfig;
    protected $_name = [
        'description'         => 'description',
        'excludeDeptIds'      => 'excludeDeptIds',
        'excludeTagIds'       => 'excludeTagIds',
        'excludeUserIds'      => 'excludeUserIds',
        'id'                  => 'id',
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
        if (null !== $this->id) {
            $res['id'] = $this->id;
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
     * @return GetContactHideBySceneSettingResponseBody
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
        if (isset($map['id'])) {
            $model->id = $map['id'];
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
