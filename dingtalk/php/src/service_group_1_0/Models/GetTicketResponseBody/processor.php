<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetTicketResponseBody;

use AlibabaCloud\Tea\Model;

class processor extends Model
{
    /**
     * @var string
     */
    public $unionId;

    /**
     * @var string
     */
    public $nickName;
    protected $_name = [
        'unionId'  => 'unionId',
        'nickName' => 'nickName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->nickName) {
            $res['nickName'] = $this->nickName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return processor
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['nickName'])) {
            $model->nickName = $map['nickName'];
        }

        return $model;
    }
}
