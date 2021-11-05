<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupRequest;

use AlibabaCloud\Tea\Model;

class teacherInfos extends Model
{
    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 角色类型
     *
     * @var string
     */
    public $participantRole;
    protected $_name = [
        'userId'          => 'userId',
        'participantRole' => 'participantRole',
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
        if (null !== $this->participantRole) {
            $res['participantRole'] = $this->participantRole;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return teacherInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['participantRole'])) {
            $model->participantRole = $map['participantRole'];
        }

        return $model;
    }
}
