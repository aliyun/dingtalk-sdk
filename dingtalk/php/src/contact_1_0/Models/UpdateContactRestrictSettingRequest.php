<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateContactRestrictSettingRequest extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $active;

    /**
     * @example rule description
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
     * @example 1000
     *
     * @var int
     */
    public $id;

    /**
     * @example contact restrict name
     *
     * @var string
     */
    public $name;

    /**
     * @var bool
     */
    public $restrictInSearch;

    /**
     * @var bool
     */
    public $restrictInUserProfile;

    /**
     * @var int[]
     */
    public $subjectDeptIds;

    /**
     * @var int[]
     */
    public $subjectTagIds;

    /**
     * @var string[]
     */
    public $subjectUserIds;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'active'                => 'active',
        'description'           => 'description',
        'excludeDeptIds'        => 'excludeDeptIds',
        'excludeTagIds'         => 'excludeTagIds',
        'excludeUserIds'        => 'excludeUserIds',
        'id'                    => 'id',
        'name'                  => 'name',
        'restrictInSearch'      => 'restrictInSearch',
        'restrictInUserProfile' => 'restrictInUserProfile',
        'subjectDeptIds'        => 'subjectDeptIds',
        'subjectTagIds'         => 'subjectTagIds',
        'subjectUserIds'        => 'subjectUserIds',
        'type'                  => 'type',
    ];

    public function validate()
    {
    }

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
        if (null !== $this->restrictInSearch) {
            $res['restrictInSearch'] = $this->restrictInSearch;
        }
        if (null !== $this->restrictInUserProfile) {
            $res['restrictInUserProfile'] = $this->restrictInUserProfile;
        }
        if (null !== $this->subjectDeptIds) {
            $res['subjectDeptIds'] = $this->subjectDeptIds;
        }
        if (null !== $this->subjectTagIds) {
            $res['subjectTagIds'] = $this->subjectTagIds;
        }
        if (null !== $this->subjectUserIds) {
            $res['subjectUserIds'] = $this->subjectUserIds;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateContactRestrictSettingRequest
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
        if (isset($map['restrictInSearch'])) {
            $model->restrictInSearch = $map['restrictInSearch'];
        }
        if (isset($map['restrictInUserProfile'])) {
            $model->restrictInUserProfile = $map['restrictInUserProfile'];
        }
        if (isset($map['subjectDeptIds'])) {
            if (!empty($map['subjectDeptIds'])) {
                $model->subjectDeptIds = $map['subjectDeptIds'];
            }
        }
        if (isset($map['subjectTagIds'])) {
            if (!empty($map['subjectTagIds'])) {
                $model->subjectTagIds = $map['subjectTagIds'];
            }
        }
        if (isset($map['subjectUserIds'])) {
            if (!empty($map['subjectUserIds'])) {
                $model->subjectUserIds = $map['subjectUserIds'];
            }
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
