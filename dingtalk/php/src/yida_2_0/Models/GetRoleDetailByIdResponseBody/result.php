<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetRoleDetailByIdResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetRoleDetailByIdResponseBody\result\members;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var mixed
     */
    public $canModifyOwners;

    /**
     * @var string
     */
    public $description;

    /**
     * @var int
     */
    public $memberTotalCount;

    /**
     * @var members
     */
    public $members;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $parentUuid;

    /**
     * @var string
     */
    public $roleUuid;
    protected $_name = [
        'canModifyOwners' => 'canModifyOwners',
        'description' => 'description',
        'memberTotalCount' => 'memberTotalCount',
        'members' => 'members',
        'name' => 'name',
        'parentUuid' => 'parentUuid',
        'roleUuid' => 'roleUuid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->canModifyOwners) {
            $res['canModifyOwners'] = $this->canModifyOwners;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->memberTotalCount) {
            $res['memberTotalCount'] = $this->memberTotalCount;
        }
        if (null !== $this->members) {
            $res['members'] = null !== $this->members ? $this->members->toMap() : null;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->parentUuid) {
            $res['parentUuid'] = $this->parentUuid;
        }
        if (null !== $this->roleUuid) {
            $res['roleUuid'] = $this->roleUuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['canModifyOwners'])) {
            $model->canModifyOwners = $map['canModifyOwners'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['memberTotalCount'])) {
            $model->memberTotalCount = $map['memberTotalCount'];
        }
        if (isset($map['members'])) {
            $model->members = members::fromMap($map['members']);
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['parentUuid'])) {
            $model->parentUuid = $map['parentUuid'];
        }
        if (isset($map['roleUuid'])) {
            $model->roleUuid = $map['roleUuid'];
        }

        return $model;
    }
}
