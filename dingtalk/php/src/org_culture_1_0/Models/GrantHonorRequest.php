<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models;

use AlibabaCloud\Tea\Model;

class GrantHonorRequest extends Model
{
    /**
     * @description 有效期到期时间 时间戳. 会处理成到期那天的23:59:59秒的时间戳
     *
     * @var string
     */
    public $expirationTime;

    /**
     * @description 颁奖词，最多可以填50字
     *
     * @var string
     */
    public $grantReason;

    /**
     * @description 颁奖人名字，最多15个字
     *
     * @var string
     */
    public $granterName;

    /**
     * @description 是否使用官宣号通知获奖人
     *
     * @var bool
     */
    public $noticeAnnouncer;

    /**
     * @description 是否触达单聊会话通知
     *
     * @var bool
     */
    public $noticeSingle;

    /**
     * @description 接受人staffId
     *
     * @var string[]
     */
    public $receiverUserIds;

    /**
     * @description 发送人userId
     *
     * @var string
     */
    public $senderUserId;
    protected $_name = [
        'expirationTime'  => 'expirationTime',
        'grantReason'     => 'grantReason',
        'granterName'     => 'granterName',
        'noticeAnnouncer' => 'noticeAnnouncer',
        'noticeSingle'    => 'noticeSingle',
        'receiverUserIds' => 'receiverUserIds',
        'senderUserId'    => 'senderUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->expirationTime) {
            $res['expirationTime'] = $this->expirationTime;
        }
        if (null !== $this->grantReason) {
            $res['grantReason'] = $this->grantReason;
        }
        if (null !== $this->granterName) {
            $res['granterName'] = $this->granterName;
        }
        if (null !== $this->noticeAnnouncer) {
            $res['noticeAnnouncer'] = $this->noticeAnnouncer;
        }
        if (null !== $this->noticeSingle) {
            $res['noticeSingle'] = $this->noticeSingle;
        }
        if (null !== $this->receiverUserIds) {
            $res['receiverUserIds'] = $this->receiverUserIds;
        }
        if (null !== $this->senderUserId) {
            $res['senderUserId'] = $this->senderUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GrantHonorRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['expirationTime'])) {
            $model->expirationTime = $map['expirationTime'];
        }
        if (isset($map['grantReason'])) {
            $model->grantReason = $map['grantReason'];
        }
        if (isset($map['granterName'])) {
            $model->granterName = $map['granterName'];
        }
        if (isset($map['noticeAnnouncer'])) {
            $model->noticeAnnouncer = $map['noticeAnnouncer'];
        }
        if (isset($map['noticeSingle'])) {
            $model->noticeSingle = $map['noticeSingle'];
        }
        if (isset($map['receiverUserIds'])) {
            if (!empty($map['receiverUserIds'])) {
                $model->receiverUserIds = $map['receiverUserIds'];
            }
        }
        if (isset($map['senderUserId'])) {
            $model->senderUserId = $map['senderUserId'];
        }

        return $model;
    }
}
