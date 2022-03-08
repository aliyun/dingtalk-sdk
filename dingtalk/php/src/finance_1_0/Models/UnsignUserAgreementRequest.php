<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class UnsignUserAgreementRequest extends Model
{
    /**
     * @description 协议编号
     *
     * @var string
     */
    public $agreementNo;

    /**
     * @description 业务代码
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description 业务场景
     *
     * @var string
     */
    public $bizScene;

    /**
     * @description 主机构编号
     *
     * @var string
     */
    public $instId;

    /**
     * @description 子机构编号
     *
     * @var string
     */
    public $subInstId;

    /**
     * @description 付款人staffId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'agreementNo' => 'agreementNo',
        'bizCode'     => 'bizCode',
        'bizScene'    => 'bizScene',
        'instId'      => 'instId',
        'subInstId'   => 'subInstId',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->agreementNo) {
            $res['agreementNo'] = $this->agreementNo;
        }
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
     * @return UnsignUserAgreementRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agreementNo'])) {
            $model->agreementNo = $map['agreementNo'];
        }
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
