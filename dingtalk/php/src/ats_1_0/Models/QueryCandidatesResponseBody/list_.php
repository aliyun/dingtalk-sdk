<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\QueryCandidatesResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @example 64167133e3394c6b9959eexxxxxxxxxx
     *
     * @var string
     */
    public $candidateId;

    /**
     * @example ding2c0158xxxxxxxxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 1701014400000
     *
     * @var int
     */
    public $entryDate;

    /**
     * @example 013224566462xxxxxxxxxx
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'candidateId' => 'candidateId',
        'corpId' => 'corpId',
        'entryDate' => 'entryDate',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->candidateId) {
            $res['candidateId'] = $this->candidateId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->entryDate) {
            $res['entryDate'] = $this->entryDate;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['candidateId'])) {
            $model->candidateId = $map['candidateId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['entryDate'])) {
            $model->entryDate = $map['entryDate'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
