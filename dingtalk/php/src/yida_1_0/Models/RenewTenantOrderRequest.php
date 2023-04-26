<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class RenewTenantOrderRequest extends Model
{
    /**
     * @example hexaaaa
     *
     * @var string
     */
    public $accessKey;

    /**
     * @example 44234122
     *
     * @var string
     */
    public $callerUnionId;

    /**
     * @example 1234567891234
     *
     * @var int
     */
    public $endTimeGMT;
    protected $_name = [
        'accessKey'     => 'accessKey',
        'callerUnionId' => 'callerUnionId',
        'endTimeGMT'    => 'endTimeGMT',
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
        if (null !== $this->callerUnionId) {
            $res['callerUnionId'] = $this->callerUnionId;
        }
        if (null !== $this->endTimeGMT) {
            $res['endTimeGMT'] = $this->endTimeGMT;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RenewTenantOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accessKey'])) {
            $model->accessKey = $map['accessKey'];
        }
        if (isset($map['callerUnionId'])) {
            $model->callerUnionId = $map['callerUnionId'];
        }
        if (isset($map['endTimeGMT'])) {
            $model->endTimeGMT = $map['endTimeGMT'];
        }

        return $model;
    }
}
