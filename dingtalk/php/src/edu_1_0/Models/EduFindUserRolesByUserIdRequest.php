<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class EduFindUserRolesByUserIdRequest extends Model
{
    /**
     * @example 666666
     *
     * @var int
     */
    public $classId;

    /**
     * @example ding123456
     *
     * @var string
     */
    public $corpId;

    /**
     * @var bool
     */
    public $hasOrgRole;

    /**
     * @example 123456
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'classId' => 'classId',
        'corpId' => 'corpId',
        'hasOrgRole' => 'hasOrgRole',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->hasOrgRole) {
            $res['hasOrgRole'] = $this->hasOrgRole;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EduFindUserRolesByUserIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['hasOrgRole'])) {
            $model->hasOrgRole = $map['hasOrgRole'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
