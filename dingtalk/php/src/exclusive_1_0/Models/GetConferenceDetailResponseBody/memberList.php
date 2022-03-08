<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConferenceDetailResponseBody;

use AlibabaCloud\Tea\Model;

class memberList extends Model
{
    /**
     * @description 参会时长
     *
     * @var float
     */
    public $attendDuration;

    /**
     * @description 用户昵称
     *
     * @var string
     */
    public $name;

    /**
     * @description 员工id
     *
     * @var string
     */
    public $staffId;

    /**
     * @description 用户uid
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'attendDuration' => 'attendDuration',
        'name'           => 'name',
        'staffId'        => 'staffId',
        'unionId'        => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attendDuration) {
            $res['attendDuration'] = $this->attendDuration;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return memberList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attendDuration'])) {
            $model->attendDuration = $map['attendDuration'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
