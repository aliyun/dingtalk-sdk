<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateVideoConferenceRequest extends Model
{
    /**
     * @example XXX的视频会议
     *
     * @var string
     */
    public $confTitle;

    /**
     * @example false
     *
     * @var bool
     */
    public $inviteCaller;

    /**
     * @var string[]
     */
    public $inviteUserIds;

    /**
     * @example 27SaQ3iiHLN0uwqcPisedfreNwiEiE
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'confTitle'     => 'confTitle',
        'inviteCaller'  => 'inviteCaller',
        'inviteUserIds' => 'inviteUserIds',
        'userId'        => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->confTitle) {
            $res['confTitle'] = $this->confTitle;
        }
        if (null !== $this->inviteCaller) {
            $res['inviteCaller'] = $this->inviteCaller;
        }
        if (null !== $this->inviteUserIds) {
            $res['inviteUserIds'] = $this->inviteUserIds;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateVideoConferenceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['confTitle'])) {
            $model->confTitle = $map['confTitle'];
        }
        if (isset($map['inviteCaller'])) {
            $model->inviteCaller = $map['inviteCaller'];
        }
        if (isset($map['inviteUserIds'])) {
            if (!empty($map['inviteUserIds'])) {
                $model->inviteUserIds = $map['inviteUserIds'];
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
