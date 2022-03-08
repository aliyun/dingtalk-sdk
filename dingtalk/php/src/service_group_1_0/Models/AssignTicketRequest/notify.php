<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AssignTicketRequest;

use AlibabaCloud\Tea\Model;

class notify extends Model
{
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

    /**
     * @var string[]
     */
    public $workNoticeReceiverUnionIds;
    protected $_name = [
        'groupNoticeReceiverUnionIds' => 'groupNoticeReceiverUnionIds',
        'noticeAllGroupMember'        => 'noticeAllGroupMember',
        'workNoticeReceiverUnionIds'  => 'workNoticeReceiverUnionIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupNoticeReceiverUnionIds) {
            $res['groupNoticeReceiverUnionIds'] = $this->groupNoticeReceiverUnionIds;
        }
        if (null !== $this->noticeAllGroupMember) {
            $res['noticeAllGroupMember'] = $this->noticeAllGroupMember;
        }
        if (null !== $this->workNoticeReceiverUnionIds) {
            $res['workNoticeReceiverUnionIds'] = $this->workNoticeReceiverUnionIds;
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
        if (isset($map['groupNoticeReceiverUnionIds'])) {
            if (!empty($map['groupNoticeReceiverUnionIds'])) {
                $model->groupNoticeReceiverUnionIds = $map['groupNoticeReceiverUnionIds'];
            }
        }
        if (isset($map['noticeAllGroupMember'])) {
            $model->noticeAllGroupMember = $map['noticeAllGroupMember'];
        }
        if (isset($map['workNoticeReceiverUnionIds'])) {
            if (!empty($map['workNoticeReceiverUnionIds'])) {
                $model->workNoticeReceiverUnionIds = $map['workNoticeReceiverUnionIds'];
            }
        }

        return $model;
    }
}
