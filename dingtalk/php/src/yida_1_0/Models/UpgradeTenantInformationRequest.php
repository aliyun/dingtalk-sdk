<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpgradeTenantInformationRequest extends Model
{
    /**
     * @description 访问秘钥
     *
     * @var string
     */
    public $accessKey;

    /**
     * @description 账户号
     *
     * @var string
     */
    public $accountNumber;

    /**
     * @description 调用者unionId
     *
     * @var string
     */
    public $callerUnionId;

    /**
     * @description 商品类型
     *
     * @var string
     */
    public $commodityType;
    protected $_name = [
        'accessKey'     => 'accessKey',
        'accountNumber' => 'accountNumber',
        'callerUnionId' => 'callerUnionId',
        'commodityType' => 'commodityType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accessKey) {
            $res['accessKey'] = $this->accessKey;
        }
        if (null !== $this->accountNumber) {
            $res['accountNumber'] = $this->accountNumber;
        }
        if (null !== $this->callerUnionId) {
            $res['callerUnionId'] = $this->callerUnionId;
        }
        if (null !== $this->commodityType) {
            $res['commodityType'] = $this->commodityType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpgradeTenantInformationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accessKey'])) {
            $model->accessKey = $map['accessKey'];
        }
        if (isset($map['accountNumber'])) {
            $model->accountNumber = $map['accountNumber'];
        }
        if (isset($map['callerUnionId'])) {
            $model->callerUnionId = $map['callerUnionId'];
        }
        if (isset($map['commodityType'])) {
            $model->commodityType = $map['commodityType'];
        }

        return $model;
    }
}
