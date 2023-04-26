<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\AddEmpAttributeHideBySceneSettingRequest\chatSubtitleConfig;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\AddEmpAttributeHideBySceneSettingRequest\profileSceneConfig;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\AddEmpAttributeHideBySceneSettingRequest\searchSceneConfig;
use AlibabaCloud\Tea\Model;

class AddEmpAttributeHideBySceneSettingRequest extends Model
{
    /**
     * @var chatSubtitleConfig
     */
    public $chatSubtitleConfig;

    /**
     * @example description text
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
     * @var string[]
     */
    public $hideFields;

    /**
     * @example test name
     *
     * @var string
     */
    public $name;

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
        'chatSubtitleConfig' => 'chatSubtitleConfig',
        'description'        => 'description',
        'excludeDeptIds'     => 'excludeDeptIds',
        'excludeTagIds'      => 'excludeTagIds',
        'excludeUserIds'     => 'excludeUserIds',
        'hideFields'         => 'hideFields',
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
     * @return AddEmpAttributeHideBySceneSettingRequest
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
