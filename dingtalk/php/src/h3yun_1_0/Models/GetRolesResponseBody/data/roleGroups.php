<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetRolesResponseBody\data;

use AlibabaCloud\Tea\Model;

class roleGroups extends Model
{
    /**
     * @example 18f923a7-5a5e-426d-94ae-a55ad1a4b240
     *
     * @var string
     */
    public $companyId;

    /**
     * @example 这是一个游客体验组
     *
     * @var string
     */
    public $description;

    /**
     * @example 261befb8-728d-4b79-a0b4-7b6ddfb3f94e
     *
     * @var string
     */
    public $groupCode;

    /**
     * @example 261befb8-728d-4b79-a0b4-7b6ddfb3f94e
     *
     * @var string
     */
    public $groupId;

    /**
     * @example 游客体验组
     *
     * @var string
     */
    public $groupName;

    /**
     * @example Active
     *
     * @var string
     */
    public $state;

    /**
     * @example All
     *
     * @var string
     */
    public $visibility;
    protected $_name = [
        'companyId' => 'companyId',
        'description' => 'description',
        'groupCode' => 'groupCode',
        'groupId' => 'groupId',
        'groupName' => 'groupName',
        'state' => 'state',
        'visibility' => 'visibility',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->companyId) {
            $res['companyId'] = $this->companyId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->groupCode) {
            $res['groupCode'] = $this->groupCode;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->state) {
            $res['state'] = $this->state;
        }
        if (null !== $this->visibility) {
            $res['visibility'] = $this->visibility;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return roleGroups
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['companyId'])) {
            $model->companyId = $map['companyId'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['groupCode'])) {
            $model->groupCode = $map['groupCode'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }
        if (isset($map['visibility'])) {
            $model->visibility = $map['visibility'];
        }

        return $model;
    }
}
