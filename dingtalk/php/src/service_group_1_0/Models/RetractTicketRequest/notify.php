<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\RetractTicketRequest;

use AlibabaCloud\Tea\Model;

class notify extends Model
{
    /**
     * @var string[]
     */
    public $workNoticeReceiverUnionIds;

    /**
     * @var string[]
     */
    public $groupNoticeReceiverUnionIds;

    /**
     * @description 是否向群内推送一个全员可见工单通知卡片
     *
     * @var bool
     */
    public $noticeAllGroupMember;
    protected $_name = [
        'workNoticeReceiverUnionIds'  => 'workNoticeReceiverUnionIds',
        'groupNoticeReceiverUnionIds' => 'groupNoticeReceiverUnionIds',
        'noticeAllGroupMember'        => 'noticeAllGroupMember',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->workNoticeReceiverUnionIds) {
            $res['workNoticeReceiverUnionIds'] = $this->workNoticeReceiverUnionIds;
        }
        if (null !== $this->groupNoticeReceiverUnionIds) {
            $res['groupNoticeReceiverUnionIds'] = $this->groupNoticeReceiverUnionIds;
        }
        if (null !== $this->noticeAllGroupMember) {
            $res['noticeAllGroupMember'] = $this->noticeAllGroupMember;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return notify
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['workNoticeReceiverUnionIds'])) {
            if (!empty($map['workNoticeReceiverUnionIds'])) {
                $model->workNoticeReceiverUnionIds = $map['workNoticeReceiverUnionIds'];
            }
        }
        if (isset($map['groupNoticeReceiverUnionIds'])) {
            if (!empty($map['groupNoticeReceiverUnionIds'])) {
                $model->groupNoticeReceiverUnionIds = $map['groupNoticeReceiverUnionIds'];
            }
        }
        if (isset($map['noticeAllGroupMember'])) {
            $model->noticeAllGroupMember = $map['noticeAllGroupMember'];
        }

        return $model;
    }
}
