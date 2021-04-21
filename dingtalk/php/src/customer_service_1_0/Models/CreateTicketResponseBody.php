<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateTicketResponseBody extends Model
{
    /**
     * @description 新创建工单ID
     *
     * @var string
     */
    public $ticketId;
    protected $_name = [
        'ticketId' => 'ticketId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->ticketId) {
            $res['ticketId'] = $this->ticketId;
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
        if (isset($map['ticketId'])) {
            $model->ticketId = $map['ticketId'];
        }

        return $model;
    }
}
