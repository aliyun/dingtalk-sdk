<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchOrgCreateHWRequest\openSelectItemList\classList;

use AlibabaCloud\Tea\Model;

class students extends Model
{
    /**
     * @description 学生姓名
     *
     * @var string
     */
    public $name;

    /**
     * @description 学生userid
     *
     * @var string
     */
    public $staffId;

    /**
     * @description 学生头像
     *
     * @var string
     */
    public $avatar;
    protected $_name = [
        'name'    => 'name',
        'staffId' => 'staffId',
        'avatar'  => 'avatar',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }
        if (null !== $this->avatar) {
            $res['avatar'] = $this->avatar;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return students
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }
        if (isset($map['avatar'])) {
            $model->avatar = $map['avatar'];
        }

        return $model;
    }
}
