<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchOrgCreateHWRequest\openSelectItemList\classList;

use AlibabaCloud\Tea\Model;

class students extends Model
{
    /**
     * @var string
     */
    public $avatar;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $staffId;
    protected $_name = [
        'avatar'  => 'avatar',
        'name'    => 'name',
        'staffId' => 'staffId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->avatar) {
            $res['avatar'] = $this->avatar;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
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
        if (isset($map['avatar'])) {
            $model->avatar = $map['avatar'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }

        return $model;
    }
}
