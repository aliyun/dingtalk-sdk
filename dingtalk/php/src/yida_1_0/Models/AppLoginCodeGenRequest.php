<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class AppLoginCodeGenRequest extends Model
{
    /**
     * @var string
     */
    public $appKey;

    /**
     * @var string
     */
    public $signTimestampStr;

    /**
     * @var string
     */
    public $signature;

    /**
     * @example https://www.aliwork.com/APP_xx/workbench
     *
     * @var string
     */
    public $fullUrl;

    /**
     * @example 123456
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appKey'           => 'appKey',
        'signTimestampStr' => 'signTimestampStr',
        'signature'        => 'signature',
        'fullUrl'          => 'fullUrl',
        'userId'           => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appKey) {
            $res['appKey'] = $this->appKey;
        }
        if (null !== $this->signTimestampStr) {
            $res['signTimestampStr'] = $this->signTimestampStr;
        }
        if (null !== $this->signature) {
            $res['signature'] = $this->signature;
        }
        if (null !== $this->fullUrl) {
            $res['fullUrl'] = $this->fullUrl;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AppLoginCodeGenRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appKey'])) {
            $model->appKey = $map['appKey'];
        }
        if (isset($map['signTimestampStr'])) {
            $model->signTimestampStr = $map['signTimestampStr'];
        }
        if (isset($map['signature'])) {
            $model->signature = $map['signature'];
        }
        if (isset($map['fullUrl'])) {
            $model->fullUrl = $map['fullUrl'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
