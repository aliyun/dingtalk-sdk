<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryVerifyResultResponseBody extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $factorCode;

    /**
     * @var string
     */
    public $factorDesc;

    /**
     * @var string
     */
    public $resultCode;

    /**
     * @var string
     */
    public $resultDesc;

    /**
     * @var string
     */
    public $state;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var int
     */
    public $verifyTimestamp;
    protected $_name = [
        'corpId' => 'corpId',
        'factorCode' => 'factorCode',
        'factorDesc' => 'factorDesc',
        'resultCode' => 'resultCode',
        'resultDesc' => 'resultDesc',
        'state' => 'state',
        'userId' => 'userId',
        'verifyTimestamp' => 'verifyTimestamp',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->factorCode) {
            $res['factorCode'] = $this->factorCode;
        }
        if (null !== $this->factorDesc) {
            $res['factorDesc'] = $this->factorDesc;
        }
        if (null !== $this->resultCode) {
            $res['resultCode'] = $this->resultCode;
        }
        if (null !== $this->resultDesc) {
            $res['resultDesc'] = $this->resultDesc;
        }
        if (null !== $this->state) {
            $res['state'] = $this->state;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->verifyTimestamp) {
            $res['verifyTimestamp'] = $this->verifyTimestamp;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryVerifyResultResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['factorCode'])) {
            $model->factorCode = $map['factorCode'];
        }
        if (isset($map['factorDesc'])) {
            $model->factorDesc = $map['factorDesc'];
        }
        if (isset($map['resultCode'])) {
            $model->resultCode = $map['resultCode'];
        }
        if (isset($map['resultDesc'])) {
            $model->resultDesc = $map['resultDesc'];
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['verifyTimestamp'])) {
            $model->verifyTimestamp = $map['verifyTimestamp'];
        }

        return $model;
    }
}
