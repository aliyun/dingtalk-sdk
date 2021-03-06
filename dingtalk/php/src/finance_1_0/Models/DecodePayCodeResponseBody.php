<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class DecodePayCodeResponseBody extends Model
{
    /**
     * @description 企业id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 员工id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 用户是否还在组织内
     *
     * @var bool
     */
    public $userInCorp;

    /**
     * @description 码类型
     *
     * @var string
     */
    public $codeType;

    /**
     * @description 支付宝付款码
     *
     * @var string
     */
    public $alipayCode;
    protected $_name = [
        'corpId'     => 'corpId',
        'userId'     => 'userId',
        'userInCorp' => 'userInCorp',
        'codeType'   => 'codeType',
        'alipayCode' => 'alipayCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userInCorp) {
            $res['userInCorp'] = $this->userInCorp;
        }
        if (null !== $this->codeType) {
            $res['codeType'] = $this->codeType;
        }
        if (null !== $this->alipayCode) {
            $res['alipayCode'] = $this->alipayCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DecodePayCodeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userInCorp'])) {
            $model->userInCorp = $map['userInCorp'];
        }
        if (isset($map['codeType'])) {
            $model->codeType = $map['codeType'];
        }
        if (isset($map['alipayCode'])) {
            $model->alipayCode = $map['alipayCode'];
        }

        return $model;
    }
}
