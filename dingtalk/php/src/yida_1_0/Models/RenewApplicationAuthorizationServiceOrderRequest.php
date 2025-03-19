<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class RenewApplicationAuthorizationServiceOrderRequest extends Model
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

    /**
     * @example 12
     *
     * @var string
     */
    public $instanceId;
    protected $_name = [
        'accessKey' => 'accessKey',
        'callerUnionId' => 'callerUnionId',
        'endTimeGMT' => 'endTimeGMT',
        'instanceId' => 'instanceId',
    ];

    public function validate() {}

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
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RenewApplicationAuthorizationServiceOrderRequest
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
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }

        return $model;
    }
}
