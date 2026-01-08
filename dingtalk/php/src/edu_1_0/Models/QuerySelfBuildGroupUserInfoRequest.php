<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QuerySelfBuildGroupUserInfoRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $classId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $roles;
    protected $_name = [
        'classId' => 'classId',
        'corpId' => 'corpId',
        'roles' => 'roles',
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
        if (null !== $this->roles) {
            $res['roles'] = $this->roles;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySelfBuildGroupUserInfoRequest
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
        if (isset($map['roles'])) {
            if (!empty($map['roles'])) {
                $model->roles = $map['roles'];
            }
        }

        return $model;
    }
}
