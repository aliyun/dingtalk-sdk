<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\InviteUsersRequest\inviteeList;
use AlibabaCloud\Tea\Model;

class InviteUsersRequest extends Model
{
    /**
     * @var inviteeList[]
     */
    public $inviteeList;

    /**
     * @example qzR1iSMDvzR9iPXXXXXXXXXXXXXX
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'inviteeList' => 'inviteeList',
        'unionId'     => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->inviteeList) {
            $res['inviteeList'] = [];
            if (null !== $this->inviteeList && \is_array($this->inviteeList)) {
                $n = 0;
                foreach ($this->inviteeList as $item) {
                    $res['inviteeList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InviteUsersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['inviteeList'])) {
            if (!empty($map['inviteeList'])) {
                $model->inviteeList = [];
                $n                  = 0;
                foreach ($map['inviteeList'] as $item) {
                    $model->inviteeList[$n++] = null !== $item ? inviteeList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
