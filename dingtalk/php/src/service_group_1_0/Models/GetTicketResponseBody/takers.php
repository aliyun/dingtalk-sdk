<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetTicketResponseBody;

use AlibabaCloud\Tea\Model;

class takers extends Model
{
    /**
     * @var string
     */
    public $nickName;

    /**
     * @var string
     */
    public $unionId;
    protected $_name = [
        'nickName' => 'nickName',
        'unionId'  => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nickName) {
            $res['nickName'] = $this->nickName;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return takers
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nickName'])) {
            $model->nickName = $map['nickName'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
