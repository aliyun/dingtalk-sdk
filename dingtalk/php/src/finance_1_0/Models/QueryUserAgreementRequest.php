<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryUserAgreementRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example TRADE
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description This parameter is required.
     *
     * @example WITHHOLDING
     *
     * @var string
     */
    public $bizScene;

    /**
     * @description This parameter is required.
     *
     * @example 202111090001
     *
     * @var string
     */
    public $instId;

    /**
     * @description This parameter is required.
     *
     * @example 1001
     *
     * @var string
     */
    public $subInstId;

    /**
     * @description This parameter is required.
     *
     * @example 2120493284
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizCode'   => 'bizCode',
        'bizScene'  => 'bizScene',
        'instId'    => 'instId',
        'subInstId' => 'subInstId',
        'userId'    => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->bizScene) {
            $res['bizScene'] = $this->bizScene;
        }
        if (null !== $this->instId) {
            $res['instId'] = $this->instId;
        }
        if (null !== $this->subInstId) {
            $res['subInstId'] = $this->subInstId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUserAgreementRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['bizScene'])) {
            $model->bizScene = $map['bizScene'];
        }
        if (isset($map['instId'])) {
            $model->instId = $map['instId'];
        }
        if (isset($map['subInstId'])) {
            $model->subInstId = $map['subInstId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
