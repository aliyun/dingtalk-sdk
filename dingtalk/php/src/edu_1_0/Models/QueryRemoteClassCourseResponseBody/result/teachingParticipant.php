<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryRemoteClassCourseResponseBody\result;

use AlibabaCloud\Tea\Model;

class teachingParticipant extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $orgName;

    /**
     * @var string
     */
    public $participantId;

    /**
     * @var string
     */
    public $participantName;
    protected $_name = [
        'corpId'          => 'corpId',
        'orgName'         => 'orgName',
        'participantId'   => 'participantId',
        'participantName' => 'participantName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->orgName) {
            $res['orgName'] = $this->orgName;
        }
        if (null !== $this->participantId) {
            $res['participantId'] = $this->participantId;
        }
        if (null !== $this->participantName) {
            $res['participantName'] = $this->participantName;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['orgName'])) {
            $model->orgName = $map['orgName'];
        }
        if (isset($map['participantId'])) {
            $model->participantId = $map['participantId'];
        }
        if (isset($map['participantName'])) {
            $model->participantName = $map['participantName'];
        }

        return $model;
    }
}
