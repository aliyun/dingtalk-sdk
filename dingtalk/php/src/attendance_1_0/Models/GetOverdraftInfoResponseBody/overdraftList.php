<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetOverdraftInfoResponseBody;

use AlibabaCloud\Tea\Model;

class overdraftList extends Model
{
    /**
     * @var int
     */
    public $overdraft;

    /**
     * @var string
     */
    public $unit;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'overdraft' => 'overdraft',
        'unit'      => 'unit',
        'userId'    => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->overdraft) {
            $res['overdraft'] = $this->overdraft;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return overdraftList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['overdraft'])) {
            $model->overdraft = $map['overdraft'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
