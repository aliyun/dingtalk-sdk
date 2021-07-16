<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateTicketResponseBody extends Model
{
    /**
     * @description 工单开放ID
     *
     * @var string
     */
    public $openTicketId;
    protected $_name = [
        'openTicketId' => 'openTicketId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openTicketId) {
            $res['openTicketId'] = $this->openTicketId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTicketResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openTicketId'])) {
            $model->openTicketId = $map['openTicketId'];
        }

        return $model;
    }
}
