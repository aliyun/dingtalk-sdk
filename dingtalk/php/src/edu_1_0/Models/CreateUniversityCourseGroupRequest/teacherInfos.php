<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupRequest;

use AlibabaCloud\Tea\Model;

class teacherInfos extends Model
{
    /**
     * @description 角色类型
     *
     * @var string
     */
    public $participantRole;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'participantRole' => 'participantRole',
        'userId'          => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->participantRole) {
            $res['participantRole'] = $this->participantRole;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['participantRole'])) {
            $model->participantRole = $map['participantRole'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
