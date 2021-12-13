<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class DecodePayCodeRequest extends Model
{
    /**
     * @description payCode
     *
     * @var string
     */
    public $payCode;

    /**
     * @description requestId
     *
     * @var string
     */
    public $requestId;

    /**
     * @description ISV组织ID
     *
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @description 组织ID
     *
     * @var int
     */
    public $dingOrgId;
    protected $_name = [
        'payCode'      => 'payCode',
        'requestId'    => 'requestId',
        'dingIsvOrgId' => 'dingIsvOrgId',
        'dingOrgId'    => 'dingOrgId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->payCode) {
            $res['payCode'] = $this->payCode;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DecodePayCodeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['payCode'])) {
            $model->payCode = $map['payCode'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }

        return $model;
    }
}
