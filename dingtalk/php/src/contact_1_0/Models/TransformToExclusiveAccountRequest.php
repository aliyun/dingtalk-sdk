<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class TransformToExclusiveAccountRequest extends Model
{
    /**
     * @description idpDingTalk
     *
     * @var bool
     */
    public $idpDingTalk;

    /**
     * @description initPassword
     *
     * @var string
     */
    public $initPassword;

    /**
     * @description loginId
     *
     * @var string
     */
    public $loginId;

    /**
     * @description transformType
     *
     * @var string
     */
    public $transformType;

    /**
     * @description userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'idpDingTalk'   => 'idpDingTalk',
        'initPassword'  => 'initPassword',
        'loginId'       => 'loginId',
        'transformType' => 'transformType',
        'userId'        => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->idpDingTalk) {
            $res['idpDingTalk'] = $this->idpDingTalk;
        }
        if (null !== $this->initPassword) {
            $res['initPassword'] = $this->initPassword;
        }
        if (null !== $this->loginId) {
            $res['loginId'] = $this->loginId;
        }
        if (null !== $this->transformType) {
            $res['transformType'] = $this->transformType;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TransformToExclusiveAccountRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['idpDingTalk'])) {
            $model->idpDingTalk = $map['idpDingTalk'];
        }
        if (isset($map['initPassword'])) {
            $model->initPassword = $map['initPassword'];
        }
        if (isset($map['loginId'])) {
            $model->loginId = $map['loginId'];
        }
        if (isset($map['transformType'])) {
            $model->transformType = $map['transformType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
