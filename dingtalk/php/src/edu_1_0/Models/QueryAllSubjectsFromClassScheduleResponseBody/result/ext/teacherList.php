<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryAllSubjectsFromClassScheduleResponseBody\result\ext;

use AlibabaCloud\Tea\Model;

class teacherList extends Model
{
    /**
     * @description 老师的头像url
     *
     * @var string
     */
    public $avator;

    /**
     * @description 老师名称。
     *
     * @var string
     */
    public $name;

    /**
     * @description 老师的uid。
     *
     * @var int
     */
    public $uid;

    /**
     * @description 老师的userid。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'avator' => 'avator',
        'name'   => 'name',
        'uid'    => 'uid',
        'userId' => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->avator) {
            $res['avator'] = $this->avator;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->uid) {
            $res['uid'] = $this->uid;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return teacherList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avator'])) {
            $model->avator = $map['avator'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['uid'])) {
            $model->uid = $map['uid'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
