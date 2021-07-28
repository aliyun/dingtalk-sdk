<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleByTimeSchoolResponseBody\result;

use AlibabaCloud\Tea\Model;

class eduUserModels extends Model
{
    /**
     * @description 用户userid
     *
     * @var string
     */
    public $userId;

    /**
     * @description 用户uid
     *
     * @var int
     */
    public $uid;

    /**
     * @var string
     */
    public $name;
    protected $_name = [
        'userId' => 'userId',
        'uid'    => 'uid',
        'name'   => 'name',
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
        if (null !== $this->uid) {
            $res['uid'] = $this->uid;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return eduUserModels
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['uid'])) {
            $model->uid = $map['uid'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
