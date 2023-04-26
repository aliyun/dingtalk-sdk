<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SearchTeachersResponseBody;

use AlibabaCloud\Tea\Model;

class users extends Model
{
    /**
     * @example 123
     *
     * @var int
     */
    public $classId;

    /**
     * @example 紫金港校区-小学-二年级2019级-二年级8班
     *
     * @var string
     */
    public $deptName;

    /**
     * @example 李老师
     *
     * @var string
     */
    public $name;

    /**
     * @example 12345678
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'classId'  => 'classId',
        'deptName' => 'deptName',
        'name'     => 'name',
        'userId'   => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return users
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
