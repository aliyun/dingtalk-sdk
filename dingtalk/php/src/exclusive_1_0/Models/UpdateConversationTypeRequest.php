<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateConversationTypeRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $manageSign;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'manageSign'         => 'manageSign',
        'openConversationId' => 'openConversationId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->manageSign) {
            $res['manageSign'] = $this->manageSign;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateConversationTypeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['manageSign'])) {
            $model->manageSign = $map['manageSign'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
