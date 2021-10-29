<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryRemoteClassCourseResponseBody\result;

use AlibabaCloud\Tea\Model;

class teachingParticipant extends Model
{
    /**
     * @description 参与方名称
     *
     * @var string
     */
    public $participantName;

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

    /**
     * @description 组织名称
     *
     * @var string
     */
    public $orgName;
    protected $_name = [
        'participantName' => 'participantName',
        'participantId'   => 'participantId',
        'corpId'          => 'corpId',
        'orgName'         => 'orgName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->participantName) {
            $res['participantName'] = $this->participantName;
        }
        if (null !== $this->participantId) {
            $res['participantId'] = $this->participantId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->orgName) {
            $res['orgName'] = $this->orgName;
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
        if (isset($map['participantName'])) {
            $model->participantName = $map['participantName'];
        }
        if (isset($map['participantId'])) {
            $model->participantId = $map['participantId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['orgName'])) {
            $model->orgName = $map['orgName'];
        }

        return $model;
    }
}
