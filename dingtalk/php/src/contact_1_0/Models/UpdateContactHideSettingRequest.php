<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateContactHideSettingRequest extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $active;

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
     * @var string[]
     */
    public $excludeStaffIds;

    /**
     * @var int[]
     */
    public $excludeTagIds;

    /**
     * @var bool
     */
    public $hideInSearch;

    /**
     * @var bool
     */
    public $hideInUserProfile;

    /**
     * @example 11234
     *
     * @var int
     */
    public $id;

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
     * @var string[]
     */
    public $objectStaffIds;

    /**
     * @var int[]
     */
    public $objectTagIds;
    protected $_name = [
        'active' => 'active',
        'description' => 'description',
        'excludeDeptIds' => 'excludeDeptIds',
        'excludeStaffIds' => 'excludeStaffIds',
        'excludeTagIds' => 'excludeTagIds',
        'hideInSearch' => 'hideInSearch',
        'hideInUserProfile' => 'hideInUserProfile',
        'id' => 'id',
        'name' => 'name',
        'objectDeptIds' => 'objectDeptIds',
        'objectStaffIds' => 'objectStaffIds',
        'objectTagIds' => 'objectTagIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->active) {
            $res['active'] = $this->active;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->excludeDeptIds) {
            $res['excludeDeptIds'] = $this->excludeDeptIds;
        }
        if (null !== $this->excludeStaffIds) {
            $res['excludeStaffIds'] = $this->excludeStaffIds;
        }
        if (null !== $this->excludeTagIds) {
            $res['excludeTagIds'] = $this->excludeTagIds;
        }
        if (null !== $this->hideInSearch) {
            $res['hideInSearch'] = $this->hideInSearch;
        }
        if (null !== $this->hideInUserProfile) {
            $res['hideInUserProfile'] = $this->hideInUserProfile;
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
        if (null !== $this->objectStaffIds) {
            $res['objectStaffIds'] = $this->objectStaffIds;
        }
        if (null !== $this->objectTagIds) {
            $res['objectTagIds'] = $this->objectTagIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateContactHideSettingRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['active'])) {
            $model->active = $map['active'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['excludeDeptIds'])) {
            if (!empty($map['excludeDeptIds'])) {
                $model->excludeDeptIds = $map['excludeDeptIds'];
            }
        }
        if (isset($map['excludeStaffIds'])) {
            if (!empty($map['excludeStaffIds'])) {
                $model->excludeStaffIds = $map['excludeStaffIds'];
            }
        }
        if (isset($map['excludeTagIds'])) {
            if (!empty($map['excludeTagIds'])) {
                $model->excludeTagIds = $map['excludeTagIds'];
            }
        }
        if (isset($map['hideInSearch'])) {
            $model->hideInSearch = $map['hideInSearch'];
        }
        if (isset($map['hideInUserProfile'])) {
            $model->hideInUserProfile = $map['hideInUserProfile'];
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
        if (isset($map['objectStaffIds'])) {
            if (!empty($map['objectStaffIds'])) {
                $model->objectStaffIds = $map['objectStaffIds'];
            }
        }
        if (isset($map['objectTagIds'])) {
            if (!empty($map['objectTagIds'])) {
                $model->objectTagIds = $map['objectTagIds'];
            }
        }

        return $model;
    }
}
