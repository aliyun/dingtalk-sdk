<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\PushFeedRequest\content;
use AlibabaCloud\Tea\Model;

class PushFeedRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var content
     */
    public $content;

    /**
     * @description This parameter is required.
     *
     * @example 1772177962000
     *
     * @var int
     */
    public $expireTime;

    /**
     * @description This parameter is required.
     *
     * @var mixed[]
     */
    public $feedFeature;

    /**
     * @description This parameter is required.
     *
     * @example iwElAqN6aXADBgQABQAGsO9WlNbxvoXaCN
     *
     * @var string
     */
    public $idempotentKey;

    /**
     * @description This parameter is required.
     *
     * @example ntThCP2X44Fw73IXPUQiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'content' => 'content',
        'expireTime' => 'expireTime',
        'feedFeature' => 'feedFeature',
        'idempotentKey' => 'idempotentKey',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = null !== $this->content ? $this->content->toMap() : null;
        }
        if (null !== $this->expireTime) {
            $res['expireTime'] = $this->expireTime;
        }
        if (null !== $this->feedFeature) {
            $res['feedFeature'] = $this->feedFeature;
        }
        if (null !== $this->idempotentKey) {
            $res['idempotentKey'] = $this->idempotentKey;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PushFeedRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = content::fromMap($map['content']);
        }
        if (isset($map['expireTime'])) {
            $model->expireTime = $map['expireTime'];
        }
        if (isset($map['feedFeature'])) {
            $model->feedFeature = $map['feedFeature'];
        }
        if (isset($map['idempotentKey'])) {
            $model->idempotentKey = $map['idempotentKey'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
