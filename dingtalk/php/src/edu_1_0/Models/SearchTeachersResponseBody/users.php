<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SearchTeachersResponseBody;

use AlibabaCloud\Tea\Model;

class users extends Model
{
    /**
     * @description 用户ID
     *
     * @var string
     */
    public $userId;

    /**
     * @description 名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 所在其中一个班级ID
     *
     * @var int
     */
    public $classId;

    /**
     * @description 所在其中一个班级名称
     *
     * @var string
     */
    public $deptName;
    protected $_name = [
        'userId'   => 'userId',
        'name'     => 'name',
        'classId'  => 'classId',
        'deptName' => 'deptName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }

        return $model;
    }
}
