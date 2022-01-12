<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateVideoConferenceRequest extends Model
{
    /**
     * @description 会议发起人UID
     *
     * @var string
     */
    public $userId;

    /**
     * @description 会议主题： 文字，不超过20中文
     *
     * @var string
     */
    public $confTitle;

    /**
     * @description 邀请参会人员UID列表（必须好友或同事）
     *
     * @var string[]
     */
    public $inviteUserIds;

    /**
     * @description 是否邀请主叫
     *
     * @var bool
     */
    public $inviteCaller;
    protected $_name = [
        'userId'        => 'userId',
        'confTitle'     => 'confTitle',
        'inviteUserIds' => 'inviteUserIds',
        'inviteCaller'  => 'inviteCaller',
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
        if (null !== $this->confTitle) {
            $res['confTitle'] = $this->confTitle;
        }
        if (null !== $this->inviteUserIds) {
            $res['inviteUserIds'] = $this->inviteUserIds;
        }
        if (null !== $this->inviteCaller) {
            $res['inviteCaller'] = $this->inviteCaller;
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['confTitle'])) {
            $model->confTitle = $map['confTitle'];
        }
        if (isset($map['inviteUserIds'])) {
            if (!empty($map['inviteUserIds'])) {
                $model->inviteUserIds = $map['inviteUserIds'];
            }
        }
        if (isset($map['inviteCaller'])) {
            $model->inviteCaller = $map['inviteCaller'];
        }

        return $model;
    }
}
