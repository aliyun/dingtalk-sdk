<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddTicketMemoRequest;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddTicketMemoRequest\ticketMemo\attachments;
use AlibabaCloud\Tea\Model;

class ticketMemo extends Model
{
    /**
     * @description 文字备注
     *
     * @var string
     */
    public $memo;

    /**
     * @description 备注相关的附件
     *
     * @var attachments[]
     */
    public $attachments;
    protected $_name = [
        'memo'        => 'memo',
        'attachments' => 'attachments',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
        }
        if (null !== $this->attachments) {
            $res['attachments'] = [];
            if (null !== $this->attachments && \is_array($this->attachments)) {
                $n = 0;
                foreach ($this->attachments as $item) {
                    $res['attachments'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ticketMemo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }
        if (isset($map['attachments'])) {
            if (!empty($map['attachments'])) {
                $model->attachments = [];
                $n                  = 0;
                foreach ($map['attachments'] as $item) {
                    $model->attachments[$n++] = null !== $item ? attachments::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
