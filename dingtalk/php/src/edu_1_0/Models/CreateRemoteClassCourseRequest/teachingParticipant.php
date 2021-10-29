<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateRemoteClassCourseRequest;

use AlibabaCloud\Tea\Model;

class teachingParticipant extends Model
{
    /**
     * @description 参与方ID
     *
     * @var string
     */
    public $participantId;

    /**
     * @description 组织ID
     *
     * @var string
     */
    public $corpId;
    protected $_name = [
        'participantId' => 'participantId',
        'corpId'        => 'corpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->participantId) {
            $res['participantId'] = $this->participantId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return teachingParticipant
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['participantId'])) {
            $model->participantId = $map['participantId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }

        return $model;
    }
}
