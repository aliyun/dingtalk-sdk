<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class RenewTenantOrderRequest extends Model
{
    /**
     * @description 访问秘钥
     *
     * @var string
     */
    public $accessKey;

    /**
     * @description 调用者unionId
     *
     * @var string
     */
    public $callerUnionId;

    /**
     * @description 结束时间
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
