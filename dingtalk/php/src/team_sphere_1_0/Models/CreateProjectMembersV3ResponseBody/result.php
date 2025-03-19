<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateProjectMembersV3ResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $boundToObjectId;

    /**
     * @var string
     */
    public $boundToObjectType;

    /**
     * @var string
     */
    public $joined;

    /**
     * @var int
     */
    public $role;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'boundToObjectId' => 'boundToObjectId',
        'boundToObjectType' => 'boundToObjectType',
        'joined' => 'joined',
        'role' => 'role',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->boundToObjectId) {
            $res['boundToObjectId'] = $this->boundToObjectId;
        }
        if (null !== $this->boundToObjectType) {
            $res['boundToObjectType'] = $this->boundToObjectType;
        }
        if (null !== $this->joined) {
            $res['joined'] = $this->joined;
        }
        if (null !== $this->role) {
            $res['role'] = $this->role;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['boundToObjectId'])) {
            $model->boundToObjectId = $map['boundToObjectId'];
        }
        if (isset($map['boundToObjectType'])) {
            $model->boundToObjectType = $map['boundToObjectType'];
        }
        if (isset($map['joined'])) {
            $model->joined = $map['joined'];
        }
        if (isset($map['role'])) {
            $model->role = $map['role'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
