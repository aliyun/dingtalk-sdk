<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetUserStayLengthResponseBody;

use AlibabaCloud\Tea\Model;

class itemList extends Model
{
    /**
     * @example 小张
     *
     * @var string
     */
    public $name;

    /**
     * @example 20220501
     *
     * @var string
     */
    public $statDate;

    /**
     * @example 1000
     *
     * @var int
     */
    public $stayTimeLenApp1d;

    /**
     * @example 2000
     *
     * @var int
     */
    public $stayTimeLenPc1d;

    /**
     * @example 123***
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'name'             => 'name',
        'statDate'         => 'statDate',
        'stayTimeLenApp1d' => 'stayTimeLenApp1d',
        'stayTimeLenPc1d'  => 'stayTimeLenPc1d',
        'userId'           => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->statDate) {
            $res['statDate'] = $this->statDate;
        }
        if (null !== $this->stayTimeLenApp1d) {
            $res['stayTimeLenApp1d'] = $this->stayTimeLenApp1d;
        }
        if (null !== $this->stayTimeLenPc1d) {
            $res['stayTimeLenPc1d'] = $this->stayTimeLenPc1d;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return itemList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['statDate'])) {
            $model->statDate = $map['statDate'];
        }
        if (isset($map['stayTimeLenApp1d'])) {
            $model->stayTimeLenApp1d = $map['stayTimeLenApp1d'];
        }
        if (isset($map['stayTimeLenPc1d'])) {
            $model->stayTimeLenPc1d = $map['stayTimeLenPc1d'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
